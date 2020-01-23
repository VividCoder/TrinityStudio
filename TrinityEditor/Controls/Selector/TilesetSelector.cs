using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityEditor.Controls.Selector
{
    public partial class TilesetSelector : Form
    {
        public List<TrinityEngine.Map.TileSet.TileSet> Sets = new List<TrinityEngine.Map.TileSet.TileSet>();
        public TilesetSelector()
        {
            InitializeComponent();
        }

        public void Rebuild()
        {

            setList.Items.Clear();
            foreach(var set in Sets)
            {

                var item = setList.Items.Add(set.Name);

                item.Tag = set;

                //var new_item = 



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (setList.SelectedItems.Count == 0) return;
            if (setList.SelectedItems.Count > 1) return;
            var item = setList.SelectedItems[0];

            var tse = new Controls.Editors.Tileset.TilesetEditor();

            var set = item.Tag as TrinityEngine.Map.TileSet.TileSet;

            tse.TilesetName = set.Name;

            tse.Text = "Editing Set:" + set.Name;

            tse.Show();

             //foreach(var set in Sets)
            //{

            //}
        }
    }
}
