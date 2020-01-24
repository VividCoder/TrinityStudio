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
        public static Controls.Editors.Level.LevelEditor FLevelEditor;
        public static Controls.View.Preview.PreviewGame FPreviewGame;
        public static TrinityEdit FThis;
        public static List<TrinityEngine.Map.TileSet.TileSet> Sets = new List<TrinityEngine.Map.TileSet.TileSet>();
        public static TrinityEngine.Game.GameInfo IGameInfo = null;

        public static void NewMap()
        {

        }

        public TrinityEdit()
        {
            InitializeComponent();

            CConsole = new ConsoleOutput();
            CConsole.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            CConsole.DebugMsg("Vivid3D initializing.");
            FThis = this;
            Begin2DMapMode();
            Hide();

            FSplash = new Controls.Splash.VividSplash();
            FSplash.Show();

            CConsole.DebugMsg("Vivid3D Initialized.");
            IGameInfo = new TrinityEngine.Game.GameInfo();
            IGameInfo.LevelInfo = new TrinityEngine.Game.LevelInfo();
            IGameInfo.Levels.Add(IGameInfo.LevelInfo);

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

        private void levelEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FLevelEditor = new Controls.Editors.Level.LevelEditor();

            FLevelEditor.Show();
            

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var preview = new TrinityEditor.Controls.View.Preview.PreviewGame();

            preview.IGameInfo = IGameInfo;
            CConsole.DebugMsg("Begining game preview in seperate display.");

            preview.View.UpdateCall = () =>
            {
                preview.UpdatePreview();
            };

            preview.View.RenderCall = () =>
            {
                preview.RenderPreview();
            };

            preview.Show();

            

            //IGameInfo.Init = () =>
           // {

            //};

            //IGameInfo.BeginGame();

        }
    }
}
