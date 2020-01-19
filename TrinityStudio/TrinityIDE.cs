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
using TrinityStudio.Forms.View.Engine._2D;
namespace TrinityStudio
{
    public partial class TrinityIDE : Form
    {
        public static ConsoleOutput FormConsoleOutput;
        public static ContentBrowser FormContentBrowse;
        public static TrinityView2D FormView2D;
        public TrinityIDE()
        {
            InitializeComponent();


            FormConsoleOutput = new ConsoleOutput();
            FormConsoleOutput.Show();
            dockingManager1.DockControl(FormConsoleOutput, this, Syncfusion.Windows.Forms.Tools.DockingStyle.Bottom,150);
            
            //   FormConsoleOutput = new ConsoleOutput();
            //     FormConsoleOutput.Show(this.dockPanel1, DockState.DockBottom);


            //      FormConsoleOutput.DebugMsg("Engine initiated.");


            //FormContentBrowse = new ContentBrowser();
            //FormContentBrowse.Show();
            //this.dockingManager1.DockControl(FormContentBrowse,this, Syncfusion.Windows.Forms.Tools.DockingStyle.Bottom, 150);
            //this.dockingManager1.dock



            //this.dockingManager1.DockAsDocument(FormContentBrowse);

           //FormConsoleOutput = new ConsoleOutput();
           //FormConsoleOutput.Show();
           // this.dockingManager1.DockAsDocument(FormConsoleOutput);
             



          //  FormConsoleOutput.DebugMsg("Starting Trinity Studio IDE.");

            FormView2D = new TrinityView2D();
            FormView2D.Show();
            this.dockingManager1.DockControl(FormView2D, this, Syncfusion.Windows.Forms.Tools.DockingStyle.Top, 200);

        }

        private void dockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        private void dockingClientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
