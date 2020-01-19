namespace TrinityEditor.Controls.Graph
{
    partial class GraphTree
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Project Graph");
            this.projectTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // projectTree
            // 
            this.projectTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTree.Location = new System.Drawing.Point(0, 0);
            this.projectTree.Name = "projectTree";
            treeNode2.Name = "NodeProject";
            treeNode2.Text = "Project Graph";
            this.projectTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.projectTree.Size = new System.Drawing.Size(284, 261);
            this.projectTree.TabIndex = 1;
            // 
            // GraphTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.projectTree);
            this.Name = "GraphTree";
            this.Text = "Projet Tree";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView projectTree;
    }
}
