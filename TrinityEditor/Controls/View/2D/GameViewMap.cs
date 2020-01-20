using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityEngine.Draw;
namespace TrinityEditor.Controls.View._2D
{
    public partial class GameViewMap : GameView
    {
        public TrinityEngine.Graph.GameGraph2D GGraph2D = null;

        public override void SetGameGraph(TrinityEngine.Graph.GameGraph graph)
        {
            GGraph = graph;
            GGraph2D = (TrinityEngine.Graph.GameGraph2D)graph;
        }

        private TrinityEngine.Texture.Texture2D tex1;
        int x = 20;
        public GameViewMap()
        {
            InitializeComponent();

            View.UpdateCall = () =>
            {
                GGraph.Update();
                View.Invalidate();
                //TrinityEdit.CConsole.DebugMsg("update");
                //TrinityEngine.Texture.Texture2D.UpdateLoading();
            };
            View.RenderCall = () =>
            {

                GGraph.PreRender();
                GGraph.Render();
                //TrinityEdit.CConsole.DebugMsg("Rendered.");
                //IntelliDraw.
                View.AutoValidate = AutoValidate.Disable;
               // x = x + 1;



            };

        }
    }
}
