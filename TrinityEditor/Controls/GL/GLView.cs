using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace TrinityEditor.Controls.Graphics
{
    public partial class GLView : OpenTK.GLControl
    {
        public GLView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
            GL.ClearColor(Color.Pink);
           
        }

        private void GLView_Paint(object sender, PaintEventArgs e)
        {
            MakeCurrent();

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            SwapBuffers();
        }
    }
}
