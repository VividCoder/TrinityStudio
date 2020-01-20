namespace TrinityEditor.Controls.Info
{
    partial class GetNewMapMetrics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mapWidthNum = new System.Windows.Forms.NumericUpDown();
            this.mapHeightNum = new System.Windows.Forms.NumericUpDown();
            this.mapLayersNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tileWidthNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tileHeightNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.mapNameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapLayersNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Map Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Map Height";
            // 
            // mapWidthNum
            // 
            this.mapWidthNum.Location = new System.Drawing.Point(75, 16);
            this.mapWidthNum.Name = "mapWidthNum";
            this.mapWidthNum.Size = new System.Drawing.Size(120, 20);
            this.mapWidthNum.TabIndex = 2;
            this.mapWidthNum.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // mapHeightNum
            // 
            this.mapHeightNum.Location = new System.Drawing.Point(275, 16);
            this.mapHeightNum.Name = "mapHeightNum";
            this.mapHeightNum.Size = new System.Drawing.Size(120, 20);
            this.mapHeightNum.TabIndex = 3;
            this.mapHeightNum.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // mapLayersNum
            // 
            this.mapLayersNum.Location = new System.Drawing.Point(75, 114);
            this.mapLayersNum.Name = "mapLayersNum";
            this.mapLayersNum.Size = new System.Drawing.Size(120, 20);
            this.mapLayersNum.TabIndex = 5;
            this.mapLayersNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Map Layers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tileWidthNum
            // 
            this.tileWidthNum.Location = new System.Drawing.Point(75, 66);
            this.tileWidthNum.Name = "tileWidthNum";
            this.tileWidthNum.Size = new System.Drawing.Size(120, 20);
            this.tileWidthNum.TabIndex = 7;
            this.tileWidthNum.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tile Width";
            // 
            // tileHeightNum
            // 
            this.tileHeightNum.Location = new System.Drawing.Point(275, 66);
            this.tileHeightNum.Name = "tileHeightNum";
            this.tileHeightNum.Size = new System.Drawing.Size(120, 20);
            this.tileHeightNum.TabIndex = 9;
            this.tileHeightNum.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tile Height";
            // 
            // mapNameText
            // 
            this.mapNameText.Location = new System.Drawing.Point(75, 158);
            this.mapNameText.Name = "mapNameText";
            this.mapNameText.Size = new System.Drawing.Size(317, 20);
            this.mapNameText.TabIndex = 10;
            this.mapNameText.Text = "Map1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Map Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GetNewMapMetrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 250);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mapNameText);
            this.Controls.Add(this.tileHeightNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tileWidthNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mapLayersNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mapHeightNum);
            this.Controls.Add(this.mapWidthNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GetNewMapMetrics";
            this.Text = "Create New 2D Map";
            this.Load += new System.EventHandler(this.GetNewMapMetrics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapWidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapLayersNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mapWidthNum;
        private System.Windows.Forms.NumericUpDown mapHeightNum;
        private System.Windows.Forms.NumericUpDown mapLayersNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tileWidthNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tileHeightNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mapNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}