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
    public delegate void RenderEvent();
    public delegate void UpdateEvent();
    public partial class GLView : OpenTK.GLControl
    {

        public RenderEvent RenderCall;
        public UpdateEvent UpdateCall;

        public GLView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
            GL.ClearColor(Color.LightBlue);
           
        }

       
        

        private void GLView_Paint(object sender, PaintEventArgs e)
        {
            MakeCurrent();

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            RenderCall?.Invoke();

            SwapBuffers();
        }

        private void GLView_Resize(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

        }
    }
}
