using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityEditor.Controls.Editors.Tileset
{
    public partial class TilesetEditor : Form
    {
        public ToolStrip Tools;
        public Controls.Graphics.GLView View;
        public string TilesetName = "Name";
        public List<TrinityEngine.Map.Tile.Tile> Tiles = new List<TrinityEngine.Map.Tile.Tile>();
        public TrinityEngine.Map.TileSet.TileSet Set = null;


        public TilesetEditor()
        {
            InitializeComponent();

            Tools = new ToolStrip();

            var addImage = Tools.Items.Add("Add Image");
            var addFolder = Tools.Items.Add("Add Folder");

            addImage.Click += AddImage_Click;

            Controls.Add(Tools);

            View = new TrinityEditor.Controls.Graphics.GLView();
            Controls.Add(View);
            View.Dock = DockStyle.Fill;

            View.RenderCall = () =>
            {

                Console.WriteLine("Rendering tileset view.");

            };

        }

        private void AddImage_Click(object sender, EventArgs e)
        {

            var fd = new System.Windows.Forms.OpenFileDialog();

            fd.InitialDirectory = Environment.CurrentDirectory;

            fd.Title = "Select an image to add as a Tile";

          
            fd.ShowDialog();

            




        //    throw new NotImplementedException();
        }
    }
}
