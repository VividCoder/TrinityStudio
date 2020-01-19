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
        private TrinityEngine.Texture.Texture2D tex1;
        int x = 20;
        public GameViewMap()
        {
            InitializeComponent();

            View.UpdateCall = () =>
            {
                x = x + 5;
                View.Invalidate();
                //TrinityEdit.CConsole.DebugMsg("update");
                //TrinityEngine.Texture.Texture2D.UpdateLoading();
            };
            View.RenderCall = () =>
            {

                if (tex1 == null)
                {
                    tex1 = new TrinityEngine.Texture.Texture2D("Corona/Img/Icon/BigShotIcon.png", TrinityEngine.Texture.LoadMethod.Single, true);
               //     TrinityEngine.Texture.Texture2D.UpdateLoading();

                }

                //View.UpdateCall?.Invoke();
                IntelliDraw.BeginDraw();
                IntelliDraw.DrawImg(x, 20, 200, 200, tex1, new OpenTK.Vector4(1, 1, 1, 1));
                IntelliDraw.DrawImg(180, 80, 150, 150, tex1, new OpenTK.Vector4(1, 1, 1, 1)); 
                IntelliDraw.EndDraw2D();
                //TrinityEdit.CConsole.DebugMsg("Rendered.");
                //IntelliDraw.
                View.AutoValidate = AutoValidate.Disable;
               // x = x + 1;



            };

        }
    }
}
