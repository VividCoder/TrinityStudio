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
    public class TileSelector : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public TrinityEngine.Map.Map TileMap;
        public Controls.Graphics.GLView View;
        public TrinityEngine.Map.TileSet.TileSet Set;
        public static TrinityEngine.Map.Tile.Tile ActiveTile = null;

        bool crResources;

        public TileSelector()
        {

            Text = "Tile Selector";

            TileMap = new TrinityEngine.Map.Map(1);
            TileMap.Layers.Add(new TrinityEngine.Map.Layer.MapLayer(8, 32, TileMap));
            TileMap.TileWidth = 64;
            TileMap.TileHeight = 64;


            View = new TrinityEditor.Controls.Graphics.GLView();
            Controls.Add(View);
            View.Dock = System.Windows.Forms.DockStyle.Fill;

            View.MouseDown += View_MouseDown;
            View.MouseUp += View_MouseUp;
            View.MouseMove += View_MouseMove;

            View.RenderCall = () =>
            {

                if (!crResources)
                {
                    TileMap.CreateResources();
                    crResources = false;
                }
                //TrinityEngine.Draw.IntelliDraw.BeginDraw();
                var mat = OpenTK.Matrix4.Identity;
                TileMap.ViewMatrix = mat;
                TileMap.Render();


                //Console.WriteLine("Rendering tileset view.");

            };

            RebuildMap();
        }

        bool firstM = true;
        private int lastMx, lastMy;
        TrinityEngine.Graph.GraphMapHit p_hit = null;
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



                TileMap.CamX -= (e.X - lastMx);
                TileMap.CamY -= (e.Y - lastMy);
                //MouseMove(e.X, e.Y, e.X - lastMx, e.Y - lastMy);


            }
            else
            {

                var hit = TileMap.Pick(e.X, e.Y);
                p_hit = null;
                if (hit != null)
                {
                    //Console.WriteLine("Hit. X:" + hit.X + " Y:" + hit.Y);

                    if (hit is TrinityEngine.Graph.GraphMapHit)
                    {
                        var hm = hit as TrinityEngine.Graph.GraphMapHit;

                        hm.Map.ClearHighlights();

                        hm.Map.HighlightTile(hm.TileX, hm.TileY);

                        //Console.WriteLine("Yep");

                        p_hit = hm;

                    }

                }


            }
            lastMx = e.X;
            lastMy = e.Y;
            View.Invalidate();
            //throw new NotImplementedException();
        }

        private void View_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DragOn = false;
            }
    

            //throw new NotImplementedException();
        }

        bool DragOn = false;

        private void View_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DragOn = true;
            }

            if (e.Button == MouseButtons.Left)
            {

                if (p_hit != null)
                {

                    var htile = p_hit.Tile;

                    TileMap.SetActive(p_hit.TileX, p_hit.TileY);

                    if (htile != null)
                    {
                        ActiveTile = htile;
                        //    propGrid.Text = htile.ImagePath;
                        //      propGrid.SelectedObject = htile;
                    }
                }

            }

            //throw new NotImplementedException();
        }

        public void RebuildMap()
        {
            if (Set == null) return;
            TileMap.Layers.Clear();
            TileMap.Layers.Add(new TrinityEngine.Map.Layer.MapLayer(8, 32, TileMap));
            int tx = 0;
            int ty = 0;
            foreach (var tile in Set.Tiles)
            {
                TileMap.Layers[0].Tiles[tx, ty] = tile;
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
