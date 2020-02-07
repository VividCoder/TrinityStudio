using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GameGraph3D : GameGraph
    {

         public GameGraph3D()
        {
            RootNode = new GraphNode3D();
        }

    }

}
