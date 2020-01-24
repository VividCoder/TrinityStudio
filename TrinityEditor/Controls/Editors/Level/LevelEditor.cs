using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityEditor.Controls.Editors.Level
{
    public partial class LevelEditor : Form
    {

        public string IntroMoviePath = "";

        public LevelEditor()
        {
            InitializeComponent();
            GetLevelInfo();
        }

        public void SetLevelInfo()
        {
            TrinityEdit.IGameInfo.LevelInfo.IntroMoviePath = IntroMoviePath;
        }

        public void GetLevelInfo()
        {
            IntroMoviePath = TrinityEdit.IGameInfo.LevelInfo.IntroMoviePath;
            if (System.IO.File.Exists(IntroMoviePath))
            {
                moviePathText.Text = new System.IO.FileInfo(IntroMoviePath).Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fd = new System.Windows.Forms.OpenFileDialog();

            fd.Title = "Select movie to use as Intro.";

            fd.InitialDirectory = Environment.CurrentDirectory;

            fd.ShowDialog();

            if (System.IO.File.Exists(fd.FileName))
            {
                IntroMoviePath = fd.FileName;
                moviePathText.Text = new System.IO.FileInfo(fd.FileName).Name;
                TrinityEdit.CConsole.DebugMsg("Set movie:" + fd.FileName + " as intro movie for level.");
                SetLevelInfo();
            }
        }
    }
}
