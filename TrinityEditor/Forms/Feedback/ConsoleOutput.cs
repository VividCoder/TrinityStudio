using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityEditor.Forms.Feedback
{
    public partial class ConsoleOutput : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public ConsoleOutput()
        {
            InitializeComponent();
            this.Text = "Console Output";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
