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
            GL.ClearColor(Color.Black);
            
            GL.Disable(EnableCap.Blend);
            GL.Disable(EnableCap.Texture2D);
           // GL.Enable(EnableCap.CullFace);
            GL.CullFace(CullFaceMode.Back);
            GL.Disable(EnableCap.StencilTest);
            GL.Disable(EnableCap.ScissorTest);
         //   GL.Enable(EnableCap.DepthTest);
            GL.DepthRange(0, 1);
            GL.DepthFunc(DepthFunction.Less);

            GL.ClearDepth(1.0f);
            GL.DepthFunc(DepthFunction.Lequal);
        }



        bool cur = false;
        private void GLView_Paint(object sender, PaintEventArgs e)
        {
  //          if (cur == false)
//            {
                MakeCurrent();


            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            TrinityEngine.AppInfo.Info.ViewWidth = ClientSize.Width;
            TrinityEngine.AppInfo.Info.ViewHeight = ClientSize.Height;
            TrinityEngine.AppInfo.Info.CurWidth = ClientSize.Width;
            TrinityEngine.AppInfo.Info.CurHeight = ClientSize.Height;
            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

            RenderCall?.Invoke();

            SwapBuffers();


            //Invalidate();

            //if (Invalidated)
            //{
             //   Validate();
            //}

            //Invalidate();

        }

        private void GLView_Resize(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);
        //    GL.Scissor(0, 0, ClientSize.Width,ClientSize.Height);
            TrinityEngine.AppInfo.Info.ViewHeight = ClientSize.Width;
            TrinityEngine.AppInfo.Info.ViewHeight = ClientSize.Height;
            TrinityEngine.AppInfo.Info.CurWidth = ClientSize.Width;
            TrinityEngine.AppInfo.Info.CurHeight = ClientSize.Height;
            Invalidate();
            Console.WriteLine("ViewW:" + ClientSize.Width + " ViewH:" + ClientSize.Height);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateCall?.Invoke();
        }
    }
}
