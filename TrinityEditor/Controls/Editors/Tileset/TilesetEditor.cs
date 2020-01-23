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

        public TrinityEngine.Map.Map PreviewMap = null;

        public TilesetEditor()
        {
            InitializeComponent();
            PreviewMap = new TrinityEngine.Map.Map(1);
            PreviewMap.Layers.Add(new TrinityEngine.Map.Layer.MapLayer(8, 32,PreviewMap));
            PreviewMap.TileWidth = 64;
            PreviewMap.TileHeight = 64;
            //   Tools = new ToolStrip();


            //var addImage = Tools.Items.Add("Add Image");
           // var addFolder = Tools.Items.Add("Add Folder");

           // addImage.Click += AddImage_Click;

          //  Controls.Add(Tools);

            View = new TrinityEditor.Controls.Graphics.GLView();
            splitContainer1.Panel1.Controls.Add(View);
            // Controls.Add(View);
            View.Dock = DockStyle.Fill;

            View.MouseDown += View_MouseDown;
            View.MouseUp += View_MouseUp;
            View.MouseMove += View_MouseMove;

            View.RenderCall = () =>
            {

                if (!crResources)
                {
                    PreviewMap.CreateResources();
                    crResources = false;
                }
                //TrinityEngine.Draw.IntelliDraw.BeginDraw();
                var mat = OpenTK.Matrix4.Identity;
                PreviewMap.ViewMatrix = mat;
                PreviewMap.Render();


                //Console.WriteLine("Rendering tileset view.");

            };

        }
        bool firstM = true;
        private int lastMx, lastMy;
        private void View_MouseMove(object sender, MouseEventArgs e)
        {
            if (firstM)
            {
                lastMx = e.X;
                lastMy = e.Y;
                firstM = false;
            }
            if (DragOn)
            {

               

                PreviewMap.CamX -= (e.X - lastMx);
                PreviewMap.CamY -= (e.Y - lastMy);
                //MouseMove(e.X, e.Y, e.X - lastMx, e.Y - lastMy);

             
            }
            lastMx = e.X;
            lastMy = e.Y;
            View.Invalidate();
            //throw new NotImplementedException();
        }

        private void View_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                DragOn = false;
            }

            //throw new NotImplementedException();
        }

        bool DragOn = false;

        private void View_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                DragOn = true;
            }
            //throw new NotImplementedException();
        }

        bool crResources = false;
        private void AddImage_Click(object sender, EventArgs e)
        {

           
            
            



        //    throw new NotImplementedException();
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fd = new System.Windows.Forms.OpenFileDialog();

            fd.InitialDirectory = Environment.CurrentDirectory;

            fd.Title = "Select an image to add as a Tile";

            fd.CheckFileExists = true;

            fd.ShowDialog();

            if (System.IO.File.Exists(fd.FileName))
            {

                var new_Tile = new TrinityEngine.Map.Tile.Tile(fd.FileName);
                Set.Tiles.Add(new_Tile);
                RebuildMap();
            }
        }

        public void RebuildMap()
        {
            PreviewMap.Layers.Clear();
            PreviewMap.Layers.Add(new TrinityEngine.Map.Layer.MapLayer(8, 32, PreviewMap));
            int tx = 0;
            int ty = 0;
            foreach(var tile in Set.Tiles)
            {
                PreviewMap.Layers[0].Tiles[tx, ty] = tile;
                tx++;
                if (tx > 7)
                {
                    tx = 0;
                    ty++;
                }
            }

            View.Invalidate();
        }
    }
}
