using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GraphNode 
    {
        public string Name
        {
            get;
            set;
        }



        public GraphNode Root
        {
            get;
            set;
        }

        public List<GraphNode> Nodes
        {
            get;
            set;
        }

        public GraphNode AddNode(GraphNode node)
        {
            Nodes.Add(node);
            node.Root = this;
            return node;
        }


        public GraphNode()
        {

            Root = null;
            Nodes = new List<GraphNode>();
            Name = "Node001";
       

        }

        public virtual void Update() { }
        
        public virtual void PoreRender() { }
        public virtual void Render() { }
      


    }
}
