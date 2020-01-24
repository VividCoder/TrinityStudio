using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace TrinityEditor.Controls.Splash
{
    public partial class VividSplash : Form
    {
        public float Alpha = 0.0f;
        SoundPlayer player;
        public VividSplash()
        {
            InitializeComponent();
            this.Opacity = 0;
            player = new SoundPlayer("Data/UI/splash.wav");
            player.Play();
        }
        bool a1 = true;
        bool a2 = false;
        bool a3 = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a1)
            {
           
                Alpha += 0.05f;
                TrinityEdit.FThis.Hide();
                if (Alpha > 3.0f)
                {
                    Alpha = 1.0f;
                    a2 = true;
                    a1 = false;
                }
            }
            if (a2)
            {
                Alpha = Alpha - 0.05f;
                if (Alpha < 0)
                {
                    TrinityEdit.FThis.Show();
                    timer1.Enabled = false;
                    Close();

                }
            }

            this.Opacity = Alpha;
        }
    }
}
