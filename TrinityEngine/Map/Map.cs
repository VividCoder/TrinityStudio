using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityEngine.Map.Layer;
using TrinityEngine.Map;
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
                    for(int x = 0; x < lay.Width; x++)
                    {

                        int renX = x * TileWidth - (int)CamX;
                        int renY = y * TileHeight - (int)CamY;

                        if (ln == Layers.Count - 1)
                        {
                            Draw.IntelliDraw.DrawImg(renX, renY, TileWidth, TileHeight, NoTileTex, new OpenTK.Vector4(1, 1, 1, 1));
                        }
                    }
                }
                ln++;
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
            NoTileTex = new Texture.Texture2D("Content/Edit/highlight1.png", Texture.LoadMethod.Single, true);

        }

        public bool sceneChanged = false;
        

    }
}
