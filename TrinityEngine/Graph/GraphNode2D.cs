using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    class GraphNode2D : GraphNode
    {

        public float X
        {
            get;
            set;
        }

        public float Y
        {
            get;
            set;
        }

        public float Z
        {
            get;
            set;
        }

        public float Rotation
        {
            get;
            set;
        }

        public GraphNode2D()
        {

            X = Y = 0;
            Z = 1;
            Rotation = 0;

        }

    }
}
