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
            view.MouseDown += View_MouseDown;
            view.MouseUp += View_MouseUp;

            view.RenderCall = () =>
            {

                TrinityEdit.CConsole.DebugMsg("Rendering...");
//                Environment.Exit(1);

            };
            View = view;
        
        }

        public virtual void BindView()
        {
         //  ' View.MakeCurrent();
        }
        private void View_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseUp(0);
            }
            else if (e.Button == MouseButtons.Right)
            {
                MouseUp(1);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                MouseUp(2);
            }
            else if (e.Button == MouseButtons.XButton1)
            {
                MouseUp(3);
            }
            else if (e.Button == MouseButtons.XButton2)
            {
                MouseUp(4);
            }

            //    throw new NotImplementedException();
        }


        private void View_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDown(0);
            }
            else if (e.Button == MouseButtons.Right)
            {
                MouseDown(1);
            }
            else if(e.Button == MouseButtons.Middle)
            {
                MouseDown(2);
            }else if(e.Button == MouseButtons.XButton1)
            {
                MouseDown(3);
            }else if(e.Button == MouseButtons.XButton2)
            {
                MouseDown(4);
            }
            //throw new NotImplementedException();
        }

        public virtual void MouseMove(int mx,int my,int dx,int dy)
        {

        }
        public virtual void MouseDown(int b)
        {

        }

        public virtual void MouseUp(int b)
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
    
        public virtual void SaveState(string path)
        {

        }

        public virtual void LoadState(string path)
        {

        }
            
    }
}
