using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanagawa
{
    /// <summary>
    /// The main form in Kanagawa Editor.
    /// </summary>
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Triggered when an item is clicked in the popfile tree.
        /// </summary>
        private void treeItemClicked(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Only bothered with right clicks.
            if (e.Button != MouseButtons.Right) { return; }

            //Show the context menu, select the node.
            tree.SelectedNode = e.Node;
            treeNodeCMenu.Show(tree, e.Location);
        }

        /// <summary>
        /// Triggered when the background of the popfile tree is clicked.
        /// </summary>
        private void treeClicked(object sender, MouseEventArgs e)
        {
            //Only bothered with right clicks.
            if (e.Button != MouseButtons.Right) { return; }

            //If a node is being selected, do nothing.
            if (tree.GetNodeAt(e.Location.X, e.Location.Y) != null) { return; }

            //Otherwise, open the generic context menu.
            treeCMenu.Show(tree, e.Location);
        }
    }
}
