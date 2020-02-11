using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityEditor.Controls.View._3D
{
    public partial class GameView3D : GameView
    {

        public TrinityEngine.Graph.GameGraph3D GGraph3D = null;

        bool resources = false;

        public GameView3D()
        {
            InitializeComponent();

            
            GGraph3D = new TrinityEngine.Graph.GameGraph3D();
            GGraph = GGraph3D;
            
            View.RenderCall = () =>
            {
                if (!resources)
                {
                    resources = true;
                    GGraph.CreateResources();
                }
                Console.WriteLine("Rendering 3D ");

                GGraph3D.Render();
                
            };

        }

        public override void SetGameGraph(TrinityEngine.Graph.GameGraph graph)
        {
            GGraph = graph;
            GGraph3D = (TrinityEngine.Graph.GameGraph3D)graph;
        }

    }
}
