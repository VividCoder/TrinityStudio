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
        public static string PActiveLevel = "";
        public static Controls.Selector.TileSelector CTileSelect;
        public static TrinityEngine.Map.TileSet.TileSet CurTiles
        {
            get
            {
                return _CurTiles;
            }
            set
            {
                _CurTiles = value;
                CTileSelect.Set = value;
                CTileSelect.RebuildMap();
            }
        }
        private static TrinityEngine.Map.TileSet.TileSet _CurTiles = null;

        public static EditorMode EditMode = EditorMode.Game2D;

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
            
            Begin3DMapMode();

            Hide();

            FSplash = new Controls.Splash.VividSplash();
            FSplash.Show();

            CConsole.DebugMsg("Vivid3D Initialized.");
            IGameInfo = new TrinityEngine.Game.GameInfo();
            IGameInfo.LevelInfo = new TrinityEngine.Game.LevelInfo();
            IGameInfo.Levels.Add(IGameInfo.LevelInfo);
            LoadActiveLevel();
            LoadEditorState();

        }

        public static void SaveEditorState()
        {

            CGameView.SaveState("EditState.edit");

        }

        public static void LoadEditorState()
        {
            if (System.IO.File.Exists("EditState.edit"))
            {
                CGameView.LoadState("EditState.edit");
            }
        }

        private void Begin3DMapMode()
        {

            CGameView = new Controls.View._3D.GameView3D();
            CGameView.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);
            CGraphTree = new Controls.Graph._3D.Graph3D();
            CGraphTree.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);

            GGraph = new GameGraph3D();
            CGraphTree.SetGameGraph(GGraph);



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

            CTileSelect = new Controls.Selector.TileSelector();

            CTileSelect.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            EditMode = EditorMode.Game2D;

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
            var preview = new TrinityEditor.Controls.View.Preview.PreviewGame(IGameInfo);

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

        private void saveSceneAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fd = new System.Windows.Forms.SaveFileDialog();

            fd.InitialDirectory = Environment.CurrentDirectory;

            fd.Title = "Save Level as...";

            fd.AddExtension = true;

            fd.DefaultExt = ".level";

            fd.ShowDialog();

            IGameInfo.LevelInfo.Save(fd.FileName);

            PActiveLevel = fd.FileName;

            SaveActiveLevel();





        }

        public void SaveActiveLevel()
        {
            System.IO.File.WriteAllText("activeLevel.info",PActiveLevel);
        }

        public void LoadActiveLevel()
        {
            if (System.IO.File.Exists("activeLevel.info"))
            {
                PActiveLevel = System.IO.File.ReadAllText("activeLevel.info");
                IGameInfo.LevelInfo = new TrinityEngine.Game.LevelInfo(PActiveLevel);
                
            }
        }

        private void selectTilesetForEditingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selector = new TrinityEditor.Controls.Selector.TilesetSelector();

            selector.Sets = Sets;

            selector.JustSelect = true;

            selector.Show();

            selector.Rebuild();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTileSelect.RebuildMap();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveEditorState();
            Environment.Exit(-1);
        }
    }
}
