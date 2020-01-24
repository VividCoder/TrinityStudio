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
using TrinityEditor.Controls.Graph;
using TrinityEditor.Controls.Graph._2D;
using TrinityEngine.Graph;

namespace TrinityEditor
{


    public partial class TrinityEdit : Form
    {
        public static ConsoleOutput CConsole;
        public static GameView CGameView;
        public static GraphTree CGraphTree;
        public static GameGraph GGraph;
        public static Controls.Editors.Tileset.TilesetEditor FTilesetEdit;
        public static Controls.Splash.VividSplash FSplash = null;
        public static TrinityEdit FThis;
        public static List<TrinityEngine.Map.TileSet.TileSet> Sets = new List<TrinityEngine.Map.TileSet.TileSet>();

        public static void NewMap()
        {

        }

        public TrinityEdit()
        {
            InitializeComponent();

            CConsole = new ConsoleOutput();
            CConsole.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            FThis = this;
            Begin2DMapMode();
            Hide();

            FSplash = new Controls.Splash.VividSplash();
            FSplash.Show();


        }

        private void Begin2DMapMode()
        {
            CGameView = new Controls.View._2D.GameViewMap();
            CGameView.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
            CGraphTree = new Graph2D();
            CGraphTree.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);

            GGraph = new GameGraph2D();

            CGraphTree.SetGameGraph(GGraph);
            CGameView.SetGameGraph(GGraph);
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void tilesetEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selector = new TrinityEditor.Controls.Selector.TilesetSelector();

            selector.Sets = Sets;

            selector.Show();

            selector.Rebuild();
         
          //  FTilesetEdit = new Controls.Editors.Tileset.TilesetEditor();
         //   FTilesetEdit.Show();
        }

        private void newTilesetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newSet = new Controls.Info.GetNewTilesetMetrics();

            newSet.Show();

        }
    }
}
