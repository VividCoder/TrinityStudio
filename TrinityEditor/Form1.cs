using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityEditor.Forms.Feedback;
using TrinityStudio.Forms.Browser.Content;
namespace TrinityEditor
{
    public partial class Form1 : Form
    {
        
        public static ConsoleOutput FormConsole;
        public static ContentBrowser FormContentBrowser;

        public Form1()
        {
            InitializeComponent();

            FormConsole = new ConsoleOutput();
            FormConsole.Show(this.dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);

            FormContentBrowser = new ContentBrowser();
            FormContentBrowser.Show(FormConsole.DockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);


        }
    }
}
