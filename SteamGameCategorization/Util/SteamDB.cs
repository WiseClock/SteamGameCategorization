using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace SteamGameCategorization.Util
{
    internal class SteamDB
    {
        /// <summary>
        /// Gets the player nickname by given steam id.  Uses steamdb.info and only gets its title.
        /// </summary>
        /// <param name="steamID">player's steam id</param>
        /// <returns>player's nickname</returns>
        public static string GetNickname(string steamID)
        {
            string title = steamID;
            string url = @"https://steamdb.info/calculator/?player=" + steamID + "&currency=us";
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.CookieContainer = new CookieContainer();
                request.UserAgent = "SteamGameCategorization";
                request.Accept = "text/html";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    Regex titleCheck = new Regex(@"<title>\s*(.+?)\s*</title>", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    int bytesToRead = 250;
                    byte[] buffer = new byte[bytesToRead];
                    string contents = "";
                    int length = 0;
                    while ((length = stream.Read(buffer, 0, bytesToRead)) > 0)
                    {
                        contents += Encoding.UTF8.GetString(buffer, 0, length);
                        Match m = titleCheck.Match(contents);
                        if (m.Success)
                        {
                            title = m.Groups[1].Value.ToString();
                            break;
                        }
                        else if (contents.Contains("</head>"))
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return title.Replace("· Steam Calculator · Steam Database", "").Trim();
        }

        /// <summary>
        /// Gets a player's owned game appids.  Uses the calculator from steamdb.info.
        /// </summary>
        /// <param name="steamID">player's steam id.</param>
        /// <returns>a list of appids that the player owns.</returns>
        public static Dictionary<string, List<string>> GetOwnedGames(string steamID)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            string url = "https://steamdb.info/calculator/?player=" + steamID + "&currency=us";
            var Webget = new HtmlWeb();
            var doc = new HtmlAgilityPack.HtmlDocument();
            try
            {
                doc = Webget.Load(url);

                try
                {
                    List<string> appIDList = new List<string>();
                    var appIDs = doc.GetElementbyId("table-apps").SelectNodes("//tbody//tr//td//a");
                    foreach (var appID in appIDs)
                    {
                        appIDList.Add(appID.InnerHtml);
                    }
                    result.Add("APP", appIDList);
                }
                catch (NullReferenceException)
                {
                    try
                    {
                        var error = doc.DocumentNode.SelectNodes("//div[contains(@class, 'panel-error-calculator')]//p");
                        result.Add("ERROR", new List<string> { error[0].InnerHtml });
                    }
                    catch (NullReferenceException)
                    {
                        result.Add("ERROR", new List<string> { "网络有问题……" });
                    }
                }
            }
            catch (WebException)
            {
                result.Add("ERROR", new List<string> { "网络有问题……" });
            }

            return result;
        }
    }
}
