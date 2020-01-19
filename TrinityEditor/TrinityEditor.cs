using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityEditor.Controls.Feedback;
using TrinityEditor.Controls.View;
namespace TrinityEditor
{
    public partial class TrinityEditor : Form
    {
        public static ConsoleOutput CConsole;
        public static GameView CGameView;
        public TrinityEditor()
        {
            InitializeComponent();

            CConsole = new ConsoleOutput();
            CConsole.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);

            CGameView = new Controls.View._2D.MapView();
            CGameView.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
        
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
