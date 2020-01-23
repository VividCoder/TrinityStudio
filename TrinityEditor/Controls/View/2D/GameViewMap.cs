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

        public OpenTK.Matrix4 ViewMat;

        public float CamX, CamY, CamZ;
        public float CamRotation = 0;

        public bool DragOn = false;
        public bool RotOn = false;

        public override void SetGameGraph(TrinityEngine.Graph.GameGraph graph)
        {
            GGraph = graph;
            GGraph2D = (TrinityEngine.Graph.GameGraph2D)graph;
        }

        private TrinityEngine.Texture.Texture2D tex1;
        int x = 20;
        bool resources = false;


        public override void MouseDown(int b)
        {
            if (b == 1)
            {
                DragOn = true;
            }
            if (b == 2)
            {
                
                RotOn = true;
            }
        }

        public override void MouseUp(int b)
        {
            if (b == 1)
            {
                DragOn = false;
            }
            if (b == 2)
            {
                RotOn = false;
            }
        }

        public override void MouseMove(int mx, int my, int dx, int dy)
        {

            if (DragOn)
            {

                CamX -= dx;
                CamY -= dy;


            }

            if (RotOn)
            {

                CamRotation += dx;

            }

            //Console.WriteLine("MX:" + mx + " MY:" + my + " DX:" + dx + " DY:" + dy);

            var hit = GGraph.Pick(mx, my);

            if (hit != null)
            {
                //Console.WriteLine("Hit. X:" + hit.X + " Y:" + hit.Y);

                if(hit is TrinityEngine.Graph.GraphMapHit)
                {
                    var hm = hit as TrinityEngine.Graph.GraphMapHit;

                    hm.Map.ClearHighlights();

                     hm.Map.HighlightTile(hm.TileX, hm.TileY);

                    //Console.WriteLine("Yep");

                }

            }

            //ase.MouseMove(mx, my, dx, dy);
            //CamX = CamX + dx;
            //CamY = CamY + dy;


        }

        public void UpdateViewMatrix()
        {

            ViewMat = OpenTK.Matrix4.CreateRotationZ(OpenTK.MathHelper.DegreesToRadians(CamRotation));
            OpenTK.Matrix4 tm = OpenTK.Matrix4.CreateTranslation(new OpenTK.Vector3((View.ClientSize.Width/2)-CamX,(View.ClientSize.Height/2)-CamY, 0));

            ViewMat = ViewMat * tm;

        }
        TrinityEngine.Texture.Texture2D testc = null;
        public GameViewMap()
        {
            InitializeComponent();

            View.UpdateCall = () =>
            {
                GGraph.Update();
                View.Invalidate();
                UpdateViewMatrix();
                GGraph.SetViewMatrix(ViewMat);
                //TrinityEdit.CConsole.DebugMsg("update");
                //TrinityEngine.Texture.Texture2D.UpdateLoading();
            };
            View.RenderCall = () =>
            {
                if(!resources)
                {
                    resources = true;
                    GGraph.CreateResources();
                }
                GGraph.CenterX = View.ClientSize.Width / 2;
                GGraph.CenterY = View.ClientSize.Height / 2;
                GGraph.ViewMatrix = ViewMat;
                GGraph.PreRender();
               GGraph.Render();

                if (testc == null)
                {
                    testc = new TrinityEngine.Texture.Texture2D("Content/edit/marker.png", TrinityEngine.Texture.LoadMethod.Single, true);
                }

                if (TrinityEngine.Graph.GraphNode2DMap.NM != null)
                {


                    OpenTK.Vector2[] rpos = TrinityEngine.Graph.GraphNode2DMap.NM.GetRenderPos(1, 1);

                    IntelliDraw.BeginDraw();
                    IntelliDraw.ViewMatrix = OpenTK.Matrix4.Identity;

                    IntelliDraw.DrawImg((int)rpos[3].X,(int)rpos[3].Y, 20, 20, testc, new OpenTK.Vector4(1, 1, 1, 1));

                    IntelliDraw.EndDraw2D();
                }
                //TrinityEdit.CConsole.DebugMsg("Rendered.");
                //IntelliDraw.
                View.AutoValidate = AutoValidate.Disable;
               // x = x + 1;



            };
            CamX = CamY = 0;
            CamZ = 1;
            CamRotation = 0;

        }
    }
}
