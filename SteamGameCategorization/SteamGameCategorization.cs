using LittleToolLib.Media;
using SteamGameCategorization.Util;
using System;
using System.Windows.Forms;

namespace SteamGameCategorization
{
    public partial class SteamGameCategorization : Form
    {
        public SteamGameCategorization()
        {
            InitializeComponent();
        }

        private void SteamGameCategorization_Load(object sender, EventArgs e)
        {
            MidiPlayer.Play(MidiFile.Nyancat, true);
            string filePath = @"D:\CODE\VISUAL STUDIO\Projects\SteamGameCategorization\sharedconfig.vdf";

            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            string vdfString = file.ReadToEnd();

            VDF vdfObject = VDFParser.parse(vdfString);

            VDF vdfApps = vdfObject.GetKey("UserRoamingConfigStore").GetKey("Software").GetKey("Valve").GetKey("Steam").GetKey("apps");

            // VDFPrinter.printUserRoamingConfigStore(vdfObject);
            makeTreeView(vdfApps);
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
    }
}
