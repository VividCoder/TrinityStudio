using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GraphNode 
    {

        public List<Symbiosis.ObjectConnector> Connectors
        { get; set; }

        public float CenterX
        {
            get;
            set;
        }

        public float CenterY
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public GameGraph Owner
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
            Connectors = new List<Symbiosis.ObjectConnector>();
       

        }

        public virtual bool InBounds(int mx,int my)
        {
            return false;
        }

        public virtual GraphHit Pick(int mx,int my)
        {
            return null;
        }

        public virtual void Update() {

            UpdateNodes();
        }
        
        public virtual void PreRender() {
            PreRenderNodes();
        }
        public virtual void Render() {

            RenderNodes();
        }
      

        public void UpdateNodes()
        {
            foreach(var node in Nodes)
            {
                node.Update();
            }
        }
        public void RenderNodes()
        {
            foreach(var node in Nodes)
            {
                node.CenterX = CenterX;
                node.CenterY = CenterY;
                node.Render();
            }
        }

        public void PreRenderNodes()
        {
            foreach(var node in Nodes)
            {
                node.PreRender();
            }
        }

        public virtual void CreateResources()
        {

            CreateResourcesNodes();
        }

        public void CreateResourcesNodes()
        {
            foreach(var node in Nodes)
            {
                node.CreateResources();
            }
        }

    }
}
