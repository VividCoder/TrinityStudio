using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityEditor.Controls.Graph._2D
{
    public partial class Graph2D : GraphTree
    {
        public Graph2D()
        {
            InitializeComponent();
            CreateContextMenu();
        }

        public void CreateContextMenu()
        {

            MContextMenu = new ContextMenuStrip();

            var m_new = MContextMenu.Items.Add("New") as ToolStripMenuItem;

            var new_map = m_new.DropDownItems.Add("2D Map") as ToolStripMenuItem;

            new_map.Click += New_map_Click;

          

            //var new_map = m_new.


            ContextMenuStrip = MContextMenu;


        }

        private void New_map_Click(object sender, EventArgs e)
        {


            Info.GetNewMapMetrics newMapWin = new Info.GetNewMapMetrics();

            newMapWin.Show();

            newMapWin.CreateMap = (mw, mh, tw, th, lc, name) =>
            {

                TrinityEngine.Graph.GraphNode2DMap new_node = new TrinityEngine.Graph.GraphNode2DMap(mw, mh, tw, th, lc, name);


                var curNode = View.SelectedNode;
                if (curNode == null) return;
                var p_node = curNode.Tag as TrinityEngine.Graph.GraphNode2D;

                p_node.AddNode(new_node);

                new_node.CreateResources();

                Rebuild();

                

            };



            
            /*
            //var new_node = new Graph2DTreeNode("New Map001");
            //curNode.Nodes.Add(new_node);
            */
            return;
            throw new NotImplementedException();
        }
    }
}
