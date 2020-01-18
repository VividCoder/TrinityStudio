namespace TrinityStudio.Forms.View.Engine._2D
{
    partial class TrinityView2D
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trinityView1 = new TrinityControl.TrinityView();
            this.SuspendLayout();
            // 
            // trinityView1
            // 
            this.trinityView1.BackColor = System.Drawing.Color.Black;
            this.trinityView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trinityView1.Location = new System.Drawing.Point(0, 0);
            this.trinityView1.Name = "trinityView1";
            this.trinityView1.Size = new System.Drawing.Size(800, 450);
            this.trinityView1.TabIndex = 0;
            this.trinityView1.VSync = false;
            // 
            // TrinityView2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trinityView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrinityView2D";
            this.Text = "TrinityView2D";
            this.ResumeLayout(false);

        }

        #endregion

        private TrinityControl.TrinityView trinityView1;
    }
}