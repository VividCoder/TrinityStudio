using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityEngine.Map.Layer;
using TrinityEngine.Map;
using OpenTK;

namespace TrinityEngine.Map
{
    public class Map 
    {
        
        public class HighLightTile
        {

            public int X
            {
                get;
                set;
            }

            public int Y
            {
                get;
                set;
            }

           

        }

        public List<HighLightTile> ActiveTiles = new List<HighLightTile>();
        public List<MapLayer> Layers
        {
            get;
            set;
        }

        public OpenTK.Matrix4 ViewMatrix
        {
            get;
            set;
        }

        public float CamX
        {
            get;
            set;
        }

        public float CamY
        {
            get;
            set;
        }

        /*
        public List<GraphLight> Lights
        {
            get;
            set;
        }
        */
        public List<GraphMarker> Markers
        {
            get;
            set;
        }

        public Map()
        {

            Layers = new List<MapLayer>();
            TileWidth = TileHeight = 64;
           // Lights = new List<GraphLight>();
            Markers = new List<GraphMarker>();
            sceneChanged = true;
        }
        public void Read(System.IO.BinaryReader r)
        {

            TileWidth = r.ReadInt32();
            TileHeight = r.ReadInt32();
            int lc = r.ReadInt32();
            for(int i = 0; i < lc; i++)
            {
               // var l = new TrinityEngine.Scene.GraphLight();
                //l.Read(r);
               // Lights.Add(l);
            }
            int mc = r.ReadInt32();
            for (int i = 0; i < mc; i++)
            {
               // var m = new TrinityEngine.Scene.GraphMarker();
               // m.Read(r);
                //Markers.Add(m);
            }
            int layc = r.ReadInt32();
            Layers = new List<MapLayer>();
            for(int l = 0; l < layc; l++)
            {

                var ml = new MapLayer(1,1,this);
                ml.Read(r);
                Layers.Add(ml);



            }
            
        }
        public void Write(System.IO.BinaryWriter w)
        {

            /*
            w.Write(TileWidth);
            w.Write(TileHeight);
            w.Write(Lights.Count);
            foreach(TrinityEngine.Scene.GraphLight l in Lights)
            {
                l.Write(w);
            }
            w.Write(Markers.Count);
            foreach(TrinityEngine.Scene.GraphMarker m in Markers)
            {
                m.Write(w);
            }
            w.Write(Layers.Count);
            foreach(var lay in Layers)
            {
                lay.Write(w);
            }

    */
        }

        public void AddMarker(GraphMarker m)
        {
            Markers.Add(m);
            sceneChanged = true;
        }

        public int TileWidth

        {
            get;
            set;
        }

        public int TileHeight
        {
            get;
            set;
        }

        public MapLayer AddLayer(MapLayer layer)
        {
            Layers.Add(layer);
            return layer;
        }

        public Map(int numLayers)
        {

            Layers = new List<MapLayer>();

            for (int i = 0; i < numLayers; i++)
            {
            //    Layers.Add(new MapLayer());
            }


        }

        public Texture.Texture2D NoTileTex = null;

        public void SetActive(int tx,int ty)
        {
            ActiveTiles.Clear();
            ActiveTiles.Add(new HighLightTile() { X = tx, Y = ty });
        }

        private float sign(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }

        private bool PointInTriangle(Vector2 pt, Vector2 v1, Vector2 v2, Vector2 v3)
        {
            bool b1, b2, b3;

            b1 = sign(pt, v1, v2) < 0.0f;
            b2 = sign(pt, v2, v3) < 0.0f;
            b3 = sign(pt, v3, v1) < 0.0f;

            return ((b1 == b2) && (b2 == b3));
        }

        public Graph.GraphHit Pick(int mx,int my)
        {

            Vector2 mv = new Vector2(mx, my);

            Graph.GraphMapHit hit = new Graph.GraphMapHit();

            for(int y = 0; y < Layers[0].Height; y++)
            {
                for(int x = 0; x < Layers[0].Width; x++)
                {
                    var coords = GetRenderPos(x, y);

                    var h1 = PointInTriangle(mv, coords[0], coords[1], coords[2]);
                    var h2 = PointInTriangle(mv, coords[2], coords[3], coords[0]);

                    if(h1 || h2)
                    {


                        hit.Map = this;
                        
                        hit.TileX = x;
                        hit.TileY = y;
                        hit.Tile = Layers[0].Tiles[x, y];

                        hit.X = x;
                        hit.Y = y;

                        hit.Dist = 0;

                        return hit;


                    }

                }
            }

            return null;

        }

        public void ClearHighlights()
        {

            HL.Clear();

        }

        public bool InBounds(int mx,int my)
        {

            var p1 = GetRenderPos(0, 0);
            var p2 = GetRenderPos(Layers[0].Width - 1,0);
            var p3 = GetRenderPos(Layers[0].Width-1, Layers[0].Height-1);
            var p4 = GetRenderPos(0, Layers[0].Height - 1);

            var mv = new Vector2(mx, my);

            var h1 = PointInTriangle(mv, p1[0], p2[1],p3[2]);
            var h2 = PointInTriangle(mv, p3[2], p4[3], p1[0]);

            if(h1 || h2)
            {
                return true;
            }

           // Console.WriteLine("Ok");
            return false;

            //var h1 = PointInTriangle(new Vector2(mx,my),p1[0],)
            



        }

        public OpenTK.Vector2[] GetRenderPos(int x,int y)
        {

            OpenTK.Vector2[] pos = new OpenTK.Vector2[4];

            int renX = x * TileWidth - (int)CamX;
            int renY = y * TileHeight - (int)CamY;

            var r = OpenTK.Vector3.TransformPosition(new OpenTK.Vector3(renX, renY, 0), ViewMatrix);

            pos[0].X = r.X;
            pos[0].Y = r.Y;

            r = OpenTK.Vector3.TransformPosition(new OpenTK.Vector3(renX + TileWidth, renY, 0), ViewMatrix);

            pos[1].X = r.X;
            pos[1].Y = r.Y;

            r = OpenTK.Vector3.TransformPosition(new OpenTK.Vector3(renX + TileWidth, renY + TileHeight, 0), ViewMatrix);

            pos[2].X = r.X;
            pos[2].Y = r.Y;

            r = OpenTK.Vector3.TransformPosition(new OpenTK.Vector3(renX, renY + TileHeight, 0), ViewMatrix);

            pos[3].X = r.X;
            pos[3].Y = r.Y;

            return pos;


        }

        public void Render()
        {
            if (NoTileTex == null)
            {
            }
            Draw.IntelliDraw.BeginDraw();
            Draw.IntelliDraw.ViewMatrix = ViewMatrix;

            int ln = 0;

            

            foreach(var lay in Layers)
            {

                for(int y = 0; y < lay.Height; y++)
                {
                    bool any = false;
                    for(int x = 0; x < lay.Width; x++)
                    {

                        int renX = x * TileWidth - (int)CamX;
                        int renY = y * TileHeight - (int)CamY;

                        var tile = lay.Tiles[x, y];

                        if (tile != null)
                        {

                            Draw.IntelliDraw.DrawImg(renX, renY, TileWidth, TileHeight, tile.ColorImage, new Vector4(1, 1, 1, 1));
                       //     any = true;

                        }
                        else
                        {
                           if (ln == 0)
                            {
                                Draw.IntelliDraw.DrawImg(renX, renY, TileWidth, TileHeight, NoTileTex, new OpenTK.Vector4(1, 1, 1, 1));
                            }
                        }
                        
                    }
                }
                ln++;
            }

            
            
            Draw.IntelliDraw.EndDraw2DViewMatrix();


            Draw.IntelliDraw.BeginDraw();

            foreach(var hl in HL)
            {

                int rx = hl.X * TileWidth - (int)CamX;
                int ry = hl.Y * TileHeight - (int)CamY;

                Draw.IntelliDraw.DrawImg(rx, ry, TileWidth, TileHeight, HLTileTex,new Vector4(1,1,1,1));

            }

            foreach(var at in ActiveTiles)
            {


                int rx = at.X * TileWidth - (int)CamX;
                int ry = at.Y * TileHeight - (int)CamY;

                Draw.IntelliDraw.DrawImg(rx+TileWidth/2-16, ry-16, 32, 32, ActiveTex, new Vector4(1, 1,1, 1));

            }

            Draw.IntelliDraw.EndDraw2DViewMatrix();

        }

        MapLayer GetLayer(int index)
        {

            return Layers[index];

        }
    
        void SetLayer(MapLayer layer,int index)
        {

            Layers[index] = layer;
            sceneChanged = true;
            
        }

        public List<HighLightTile> HL = new List<HighLightTile>();

        public void HighlightTile(int x,int y)
        {

            HL.Add(new HighLightTile() { X = x, Y = y });
            sceneChanged = true;

        }

        public void CreateResources()
        {
           HLTileTex = new Texture.Texture2D("Content/Edit/highlight1.png", Texture.LoadMethod.Single, true);
            NoTileTex = new Texture.Texture2D("Content/Edit/notile.png", Texture.LoadMethod.Single, true);
            ActiveTex = new Texture.Texture2D("Content/Edit/down.png", Texture.LoadMethod.Single, true);
        }
        public Texture.Texture2D HLTileTex = null;
        public Texture.Texture2D ActiveTex = null;
        public bool sceneChanged = false;
        

    }
}
