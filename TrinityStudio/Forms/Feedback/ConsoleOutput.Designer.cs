namespace TrinityStudio.Forms.Feedback
{
    partial class ConsoleOutput
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
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ConsoleTab = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.DebugTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsoleTab)).BeginInit();
            this.ConsoleTab.SuspendLayout();
            this.DebugTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(767, 166);
            this.textBoxExt1.Location = new System.Drawing.Point(0, 0);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(100, 20);
            this.textBoxExt1.TabIndex = 0;
            this.textBoxExt1.Text = "textBoxExt1";
            // 
            // ConsoleTab
            // 
            this.ConsoleTab.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ConsoleTab.BeforeTouchSize = new System.Drawing.Size(767, 166);
            this.ConsoleTab.Controls.Add(this.DebugTab);
            this.ConsoleTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleTab.Location = new System.Drawing.Point(0, 0);
            this.ConsoleTab.Name = "ConsoleTab";
            this.ConsoleTab.Size = new System.Drawing.Size(767, 166);
            this.ConsoleTab.TabIndex = 0;
            this.ConsoleTab.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016DarkGray);
            this.ConsoleTab.ThemeName = "TabRendererOffice2016DarkGray";
            // 
            // DebugTab
            // 
            this.DebugTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DebugTab.Controls.Add(this.richTextBox1);
            this.DebugTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DebugTab.Image = null;
            this.DebugTab.ImageSize = new System.Drawing.Size(16, 16);
            this.DebugTab.Location = new System.Drawing.Point(1, 22);
            this.DebugTab.Name = "DebugTab";
            this.DebugTab.ShowCloseButton = true;
            this.DebugTab.Size = new System.Drawing.Size(764, 142);
            this.DebugTab.TabIndex = 1;
            this.DebugTab.Text = "Debug Output";
            this.DebugTab.ThemesEnabled = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(764, 142);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ConsoleOutput
            // 
            this.ClientSize = new System.Drawing.Size(767, 166);
            this.Controls.Add(this.ConsoleTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ConsoleOutput";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsoleTab)).EndInit();
            this.ConsoleTab.ResumeLayout(false);
            this.DebugTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv ConsoleTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv DebugTab;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
