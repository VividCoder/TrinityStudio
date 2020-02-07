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

        public float CamX
        {
            get;
            set;
        }

        public float CamY
        {
            get;
            set;
        }

        public float CamZ
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

        public void SetViewMatrix(OpenTK.Matrix4 mat)
        {
            ViewMatrix = mat;
        }

        public GameGraph()
        {

            Name = "Game Graph";
            RootNode = new GraphNode();

        }

        public virtual GraphHit Pick(int mx,int my)
        {

            GraphHit hit = new GraphHit();

            return PickNode(RootNode,mx,my);


            return hit;

        }

        public virtual void Write(System.IO.BinaryWriter w)
        {

        }

        public virtual void Read(System.IO.BinaryReader r)
        {

        }

        public virtual GraphHit PickNode(GraphNode node,int mx,int my)
        {

            if (node.InBounds(mx, my))
            {

                return node.Pick(mx, my);

            }

            foreach(var sub in node.Nodes)
            {
                var ret = PickNode(sub, mx, my);
                if (ret != null) return ret;
            }

            return null;

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
