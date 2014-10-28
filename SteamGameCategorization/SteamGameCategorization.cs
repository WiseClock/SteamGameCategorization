using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SteamGameCategorization.JsonStruct;
using SteamGameCategorization.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using WiseClockie.Media;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using HtmlAgilityPack;

namespace SteamGameCategorization
{
    public partial class SteamGameCategorization : Form
    {
        private WaitingDialog waitingDialog = new WaitingDialog();
        private bool fetchSteamDataFailed = false;

        private VDF steamVDF;
        private VDF steamAppVDF;

        private Dictionary<string, App> apps = new Dictionary<string, App>();

        public SteamGameCategorization()
        {
            InitializeComponent();
        }

        private void SteamGameCategorization_Load(object sender, EventArgs e)
        {
            // WiseSoundPlayer.Play(WiseMidiFile.Nyancat, true);

            string steamPath = null;
            string steamProfile = null;
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null && regKey.GetValue("SourceModInstallPath") != null)
            {
                steamPath = regKey.GetValue("SourceModInstallPath").ToString();
                steamPath = Directory.GetParent(steamPath).Parent.FullName;
            }

            if (steamPath != null && steamPath.Length > 0)
            {
                string path = steamPath + @"\userdata\";
                string[] dirs = Directory.GetDirectories(path);

                if (dirs.Length == 1)
                {
                    steamProfile = "[U:1:" + dirs[0].Remove(0, path.Length) + "]";
                }
                else if (dirs.Length != 0)
                {
                    List<string> steamProfiles = new List<string>();
                    foreach (string s in dirs)
                        steamProfiles.Add(s.Remove(0, path.Length));
                    SteamProfileSelectorDialog profileSelector = new SteamProfileSelectorDialog();
                    foreach (string profile in steamProfiles)
                    {
                        profileSelector.steamProfiles.Items.Add(SteamDB.GetNickname("[U:1:" + profile + "]"));
                    }
                    profileSelector.steamProfiles.SelectedIndex = 0;
                    if (profileSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        steamProfile = "[U:1:" + steamProfiles[profileSelector.steamProfiles.SelectedIndex] + "]";
                    }
                    profileSelector.Dispose();
                }
            }

            string filePath = @"D:\CODE\VISUAL STUDIO\Projects\SteamGameCategorization\sharedconfig.vdf";

            StreamReader file = new StreamReader(filePath);
            string vdfString = file.ReadToEnd();

            steamVDF = VDFParser.parse(vdfString);
            steamAppVDF = steamVDF.GetKey("UserRoamingConfigStore").GetKey("Software").GetKey("Valve").GetKey("Steam").GetKey("apps");

            // Console.WriteLine(steamAppVDF);
            // makeTreeView(steamAppVDF);

            if (File.Exists(Application.StartupPath + "\\GameData.steam"))
            {
                apps = Deserialize<Dictionary<string, App>>("GameData.steam");
            }
            else
            {
                Serialize(apps, "GameData.steam");
            }

            /*
            Dictionary<string, string> cate = new Dictionary<string, string>();
            Dictionary<string, string> genre = new Dictionary<string, string>();
            foreach (App app in apps.Values)
            {
                if (app.success == true)
                {
                    AppData data = app.data;
                    if (data.categories != null)
                    {
                        foreach (IdDescriptionPair pair in data.categories)
                        {
                            if (!cate.ContainsKey(pair.id))
                                cate.Add(pair.id, pair.description);
                        }
                    }
                    if (data.genres != null)
                    {
                        foreach (IdDescriptionPair pair in data.genres)
                        {
                            if (!genre.ContainsKey(pair.id))
                                genre.Add(pair.id, pair.description);
                        }
                    }
                }
            }
            Console.WriteLine("Cate:\n");
            foreach (var pair in cate)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
            Console.WriteLine("\nGenre:\n");
            foreach (var pair in genre)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
            */

            //var ownedGames = getOwnedGames("WiseClock");
            //if (ownedGames.ContainsKey("ERROR"))
            //{
            //    Console.WriteLine(ownedGames["ERROR"][0]);
            //}
            //else
            //{
            //    Console.WriteLine(ownedGames["APP"][0]);
            //}

            this.Shown += new System.EventHandler(this.fetchSteamDataStart);
        }

        public static void Serialize(object obj, string filename)
        {
            FileStream fs = new FileStream(Application.StartupPath + "\\" + filename, FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, obj);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public static T Deserialize<T>(string filename)
        {
            FileStream fs = new FileStream(Application.StartupPath + "\\" + filename, FileMode.Open);
            object obj;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                obj = formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            return (T)obj;
        }

        private void fetchSteamData(object sender, EventArgs e)
        {
            // get apps
            List<string> appids = new List<string>();
            foreach (VDF v in ((VDFValues)steamAppVDF).Value.Values)
            {
                if (!apps.ContainsKey(v.Key))
                {
                    appids.Add(v.Key);
                }
            }
            List<string> appsStrings = new List<string>();
            for (int i = 0; i < appids.Count; i += 5)
            {
                int count = 5;
                if (i + count - 1 > appids.Count)
                {
                    count = appids.Count - i;
                }
                appsStrings.Add(string.Join(",", appids.GetRange(i, count).ToArray()));
            }

            // fetch data using api
            List<Thread> threads = new List<Thread>();
            foreach (string appsString in appsStrings)
            {
                ThreadStart ts = (() => {
                    WebRequest request = WebRequest.Create("http://store.steampowered.com/api/appdetails?appids=" + appsString);
                    request.ContentType = "application/json; charset=utf-8";
                    request.Timeout = 30 * 1000;

                    try
                    {
                        WebResponse response = (HttpWebResponse)request.GetResponse();

                        string steamJson = "";
                        using (var sr = new StreamReader(response.GetResponseStream()))
                        {
                            steamJson = sr.ReadToEnd();
                        }

                        JObject jsonObject = JObject.Parse(steamJson);
                        foreach (var appJson in jsonObject)
                        {
                            App app = JsonConvert.DeserializeObject<App>(appJson.Value.ToString());
                            if (!apps.ContainsKey(appJson.Key))
                            {
                                apps.Add(appJson.Key, app);
                            }
                        }
                    }
                    catch (WebException)
                    {
                        Console.WriteLine("Faile: appid " + appsString);
                        fetchSteamDataFailed = true;
                    }
                });
                threads.Add(new Thread(ts));
            }
            foreach (Thread t in threads)
            {
                t.Start();
            }
            foreach (Thread t in threads)
            {
                t.Join();
            }
        }

        private void fetchSteamDataComplete(object sender, EventArgs e)
        {
            if (fetchSteamDataFailed)
            {
                MessageBox.Show(waitingDialog, "连接到Steam API失败，将在下次重新尝试获取。", "啊哦", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fetchSteamDataFailed = false;
            }

            try
            {
                Serialize(apps, "GameData.steam");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Enabled = true;
            waitingDialog.Close();
        }

        private void fetchSteamDataStart(object sender, EventArgs e)
        {
            Application.DoEvents();

            fetchSteamDataFailed = false;
            this.Enabled = false;
            waitingDialog.Show();
            waitingDialog.SetDesktopLocation(this.DesktopLocation.X + (this.Width - waitingDialog.Width) / 2, this.DesktopLocation.Y + (this.Height - waitingDialog.Height) / 2);

            BackgroundWorker fetchDataBW = new BackgroundWorker();
            fetchDataBW.DoWork += new DoWorkEventHandler(fetchSteamData);
            fetchDataBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(fetchSteamDataComplete);
            fetchDataBW.RunWorkerAsync();
        }
        
        private void makeTreeView(VDF vdf)
        {
            /*
            TreeNode n = new TreeNode(vdf.Key);
            foreach (VDF subVdf in ((VDFValues)vdf).Value.Values)
            {
                makeTreeView(subVdf, n);
            }
            categoryTree.Nodes.Add(n);
            */
            TreeNode node = new TreeNode(vdf.Key);
            makeTreeView(vdf, node);
            categoryTree.Nodes.Add(node.Nodes[0]);
        }

        private void makeTreeView(VDF vdf, TreeNode node)
        {
            TreeNode n = new TreeNode(vdf.Key);
            if (vdf is VDFValues)
            {
                foreach (VDF subVDF in ((VDFValues)vdf).Value.Values)
                {
                    makeTreeView(subVDF, n);
                }
            }
            else if (vdf is VDFValue)
            {
                n.Nodes.Add(((VDFValue)vdf).Value);
            }
            node.Nodes.Add(n);
        }

        private void btnSteamPath_Click(object sender, EventArgs e)
        {

        }

    }
}
