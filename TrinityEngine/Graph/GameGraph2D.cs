using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GameGraph2D : GameGraph
    {
        public GameGraph2D()
        {
            RootNode = new GraphNode2D();
        }
    }
}
