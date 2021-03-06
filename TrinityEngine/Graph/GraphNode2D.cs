﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GraphNode2D : GraphNode
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

        public override void Write(System.IO.BinaryWriter w)
        {
            w.Write(X);
            w.Write(Y);
            w.Write(Z);
            w.Write(Rotation);

            w.Write(Nodes.Count);

            foreach (var node in Nodes)
            {
                node.Write(w);
            }


            //base.Write(w);

        }

        public GraphNode2D()
        {

            X = Y = 0;
            Z = 1;
            Rotation = 0;

        }

        

    }
}
