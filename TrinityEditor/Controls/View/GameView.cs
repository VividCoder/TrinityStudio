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
        public GameView()
        {
            InitializeComponent();
            Text = "Game View";
        }
    }
}
