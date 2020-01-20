using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityEditor.Controls.Info
{

    public delegate void CreateNow(int mapW, int mapH, int tileW, int tileH, int layers, string name);

    public partial class GetNewMapMetrics : Form
    {
        public GetNewMapMetrics()
        {
            InitializeComponent();
        }

        public CreateNow CreateMap = null;

        private void button1_Click(object sender, EventArgs e)
        {
            CreateMap?.Invoke((int)mapWidthNum.Value,(int) mapHeightNum.Value, (int)tileWidthNum.Value, (int)tileHeightNum.Value, (int)mapLayersNum.Value, mapNameText.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetNewMapMetrics_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
