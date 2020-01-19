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
        public GameView()
        {
            InitializeComponent();
            Text = "Game View";

            var view = new TrinityEditor.Controls.Graphics.GLView();
            Controls.Add(view);
            view.Dock = DockStyle.Fill;

            view.RenderCall = () =>
            {

                TrinityEdit.CConsole.DebugMsg("Rendering...");
//                Environment.Exit(1);

            };
            View = view;
        
        }
    }
}
