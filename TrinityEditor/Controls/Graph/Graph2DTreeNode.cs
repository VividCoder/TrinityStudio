using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEditor.Controls.Graph
{
    public class Graph2DTreeNode : System.Windows.Forms.TreeNode
    {
        public TrinityEngine.Graph.GraphNode2D Node2D;
        public Graph2DTreeNode(string name) : base(name)
        {
           // Text = name;

        }
        
    }
}
