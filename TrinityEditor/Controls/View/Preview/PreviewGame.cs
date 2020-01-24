using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityEditor.Controls.View.Preview
{
    public partial class PreviewGame : Form
    {
        public Controls.Graphics.GLView View = null;
        public TrinityEngine.Game.GameInfo IGameInfo;

        private TrinityEngine.Resonance.UI pUI;


        public PreviewGame()
        {
            InitializeComponent();

            Size = new Size(800, 600);

            View = new Graphics.GLView();
            View.Dock = DockStyle.Fill;
            Controls.Add(View);

            pUI = new TrinityEngine.Resonance.UI();

            pUI.Root = new TrinityEngine.Resonance.Forms.VideoForm().Set(0, 0, Size.Width, Size.Height) as TrinityEngine.Resonance.Forms.VideoForm;
            // pUI.Root.SetImage(new TrinityEngine.Texture.Texture2D("Corona/Img/Icon/BigShotIcon.png", TrinityEngine.Texture.LoadMethod.Single, true));

            var vidf = pUI.Root as TrinityEngine.Resonance.Forms.VideoForm;

            vidf.SetVideo("Corona/video/intro2.mov");

        }

        public void UpdatePreview()
         {
            pUI.Update();
        }

        public void RenderPreview()
        {
          //  Console.WriteLine("RenderPreview!");
            pUI.Render();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            View.Invalidate();
        }
    }
}
