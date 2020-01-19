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
               // Layers.Add(new MapLayer());
            }

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

        public bool sceneChanged = false;
        

    }
}
