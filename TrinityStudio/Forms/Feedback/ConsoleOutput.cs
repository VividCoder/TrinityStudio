using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityStudio.Forms.Feedback
{
    public partial class ConsoleOutput : Form
    {

        public List<string> Lines = new List<string>();

        public ConsoleOutput()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void DebugMsg(string text)
        {
            Lines.Add(text);



            debugText.Text = debugText.Text = "\n" + text;

            ///
            //Text = Text + text + "\n";
        //    richTextBox1.Text = richTextBox1.Text + text + "\n";
        }


    }
}
