using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityEngine.Graph;

namespace TrinityEditor.Controls.Graph
{
    public partial class GraphTree : WeifenLuo.WinFormsUI.Docking.DockContent
    {

        public GameGraph GGraph;

        public GraphTree()
        {
            InitializeComponent();
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrinityEdit.NewMap();
        }

        public void SetGameGraph(GameGraph graph)
        {
            GGraph = graph;
            Rebuild();
        }

        public void Rebuild()
        {
            var node = projectTree.Nodes[0];

            node.Nodes.Clear();

            AddNode(GGraph.RootNode, node);

        }

        public void AddNode(GraphNode node,TreeNode tnode)
        {

            var new_node = new TreeNode(node.Name);
            tnode.Nodes.Add(new_node);
            foreach(var sub in node.Nodes)
            {
                AddNode(sub, new_node);
            }

        }


    }
}
