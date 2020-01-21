using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GraphNode2DMap : GraphNode2D
    {

        public TrinityEngine.Map.Map NodeMap
        {
            get;
            set;
        }

        public GraphNode2DMap(int mapWidth,int mapHeight,int tileWidth,int tileHeight,int layers=1,string name="")
        {

            Name = name;
            NodeMap = new Map.Map(layers);
            for(int i = 0; i < layers; i++)
            {
                NodeMap.Layers.Add(new Map.Layer.MapLayer(mapWidth, mapHeight, NodeMap));
            }
            NodeMap.TileWidth = tileWidth;
            NodeMap.TileHeight = tileHeight;

        }

        public override void Update()
        {

            UpdateNodes();
        }

        public override void Render()
        {

            NodeMap.Render();

            RenderNodes();

        }

        public override void CreateResources()
        {
            NodeMap.CreateResources();
            CreateResourcesNodes();
        }

    }
}
