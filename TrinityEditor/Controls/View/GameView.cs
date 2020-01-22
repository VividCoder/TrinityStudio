using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityEditor.Controls.View
{
    public partial class GameView : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public TrinityEditor.Controls.Graphics.GLView View = null;

        public TrinityEngine.Graph.GameGraph GGraph = null;

        public virtual void SetGameGraph(TrinityEngine.Graph.GameGraph graph)
        {
            throw new NotImplementedException();
        }

        public GameView()
        {
            InitializeComponent();
            Text = "Game View";

            var view = new TrinityEditor.Controls.Graphics.GLView();
            Controls.Add(view);
            view.Dock = DockStyle.Fill;
            view.MouseMove += View_MouseMove;

            view.RenderCall = () =>
            {

                TrinityEdit.CConsole.DebugMsg("Rendering...");
//                Environment.Exit(1);

            };
            View = view;
        
        }
        public virtual void MouseMove(int mx,int my,int dx,int dy)
        {

        }
        bool firstM = true;
        private int lastMx, lastMy;
        private void View_MouseMove(object sender, MouseEventArgs e)
        {
            if (firstM)
            {
                lastMx = e.X;
                lastMy = e.Y;
                firstM = false;
            }
            
            MouseMove(e.X, e.Y, e.X - lastMx, e.Y - lastMy);
            
            lastMx = e.X;
            lastMy = e.Y;

            //throw new NotImplementedException();
        }
    }
}
