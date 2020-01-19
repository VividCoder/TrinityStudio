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
            Environment.Exit(1);
            return;
            throw new NotImplementedException();
        }
    }
}
