using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GameGraph
    {

        public OpenTK.Matrix4 ViewMatrix = OpenTK.Matrix4.Identity;
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

        public virtual void Update()
        {
            RootNode.Update();
        }
        public virtual void PreRender()
        {
            RootNode.PreRender();
        }
        public virtual void Render()
        {
            RootNode.CenterX = CenterX;
            RootNode.CenterY = CenterY;
            RootNode.Render();
        }
    
        public void CreateResources()
        {
            RootNode.CreateResources();
        }
    }
}
