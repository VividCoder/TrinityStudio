﻿namespace TrinityEditor.Controls.View._2D
{
    partial class MapView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.glView1 = new TrinityEditor.Controls.Graphics.GLView();
            this.SuspendLayout();
            // 
            // glView1
            // 
            this.glView1.BackColor = System.Drawing.Color.Black;
            this.glView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glView1.Location = new System.Drawing.Point(0, 0);
            this.glView1.Name = "glView1";
            this.glView1.Size = new System.Drawing.Size(284, 261);
            this.glView1.TabIndex = 0;
            this.glView1.VSync = false;
            // 
            // MapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.glView1);
            this.Name = "MapView";
            this.ResumeLayout(false);

        }

        #endregion

        private TrinityEditor.Controls.Graphics.GLView glView1;
    }
}