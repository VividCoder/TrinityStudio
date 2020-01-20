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

        }

        public override void Update()
        {

            UpdateNodes();
        }

        public override void Render()
        {
            
            

            RenderNodes();

        }

    }
}
