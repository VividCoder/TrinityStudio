﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GameGraph
    {


        public string Name
        {
            get;
            set;
        }

        public GraphNode RootNode
        {
            get;
            set;
        }

        public GameGraph()
        {

            Name = "Game Graph"; 
            RootNode = new GraphNode();

        }

    }
}