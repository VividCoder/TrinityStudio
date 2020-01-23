using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GraphHit
    {

        public GraphNode Node
        {
            get;
            set;
        }

        public float Dist
        {
            get;
            set;
        }

        public OpenTK.Vector3 Pos
        {
            get;
            set;
        }

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

        public int Z
        {
            get;
            set;
        }

    }
}
