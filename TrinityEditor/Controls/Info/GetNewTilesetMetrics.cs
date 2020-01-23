using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityEditor.Controls.Info
{
    public partial class GetNewTilesetMetrics : Form
    {
        public GetNewTilesetMetrics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var tse = new Controls.Editors.Tileset.TilesetEditor();

            tse.TilesetName = TilesetText.Text;

            var new_Set = new TrinityEngine.Map.TileSet.TileSet(TilesetText.Text);

            //new_Set.Name = TilesetText.Text;
            
            TrinityEdit.Sets.Add(new_Set);

            tse.Set = new_Set;

            tse.Text = "Editing:" + new_Set.Name;

            tse.Show();


            Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
