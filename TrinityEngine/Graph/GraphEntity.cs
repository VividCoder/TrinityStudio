using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityEngine.Data;
namespace TrinityEngine.Graph
{
    public class GraphEntity : GraphNode3D
    {

        public List<Mesh3D> Meshes
        {
            get;
            set;
        }

        public GraphEntity()
        {

            Meshes = new List<Mesh3D>();

        }

        public void AddMesh(Mesh3D mesh)
        {
            Meshes.Add(mesh);
        }

        public override void Render()
        {
            Console.WriteLine("Rendering Entity.");
            RenderNodes();
        }

    }
}
