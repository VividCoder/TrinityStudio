using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityStudio.Forms;
using TrinityStudio.Forms.Feedback;
using TrinityStudio.Forms.Browser.Content;
using WeifenLuo;
using WeifenLuo.WinFormsUI;
using WeifenLuo.WinFormsUI.Docking;
namespace TrinityStudio
{
    public partial class TrinityIDE : Form
    {
        public static ConsoleOutput FormConsoleOutput;
        public static ContentBrowser FormContentBrowse;
        public TrinityIDE()
        {
            InitializeComponent();
            //    FormConsoleOutput = new ConsoleOutput();
            //      FormConsoleOutput.Show(this.dockPanel1, DockState.DockBottom);

            //      FormConsoleOutput.DebugMsg("Engine initiated.");
            FormConsoleOutput = new ConsoleOutput();
            FormConsoleOutput.Show();
            this.dockingManager1.DockControl(FormConsoleOutput, this, Syncfusion.Windows.Forms.Tools.DockingStyle.Bottom, 150);

            FormContentBrowse = new ContentBrowser();
            FormContentBrowse.Show();
            this.dockingManager1.DockControl(FormContentBrowse, FormConsoleOutput, Syncfusion.Windows.Forms.Tools.DockingStyle.Tabbed, 150);

        }

        private void dockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        private void dockingClientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
