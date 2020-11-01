using kanagawa.Data;
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
        //The population file that is currently loaded.
        Population pop = new Population();

        public Main()
        {
            InitializeComponent();
            editTabs.Enabled = false;
        }

        /// <summary>
        /// Triggered when an item is clicked in the popfile tree.
        /// </summary>
        private void treeItemClicked(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Is it a right click?
            if (e.Button != MouseButtons.Right) { return; }

            //Show the context menu, select the node.
            tree.SelectedNode = e.Node;

            //What type is the selected node? Change based on type.
            if (e.Node.Tag is Wave)
            {
                treeNodeCMenu.Items[0].Enabled = true;
                treeNodeCMenu.Items[0].Text = "Add Squad";
            }
            else if (e.Node.Tag is Squad)
            {
                treeNodeCMenu.Items[0].Enabled = true;
                treeNodeCMenu.Items[0].Text = "Add Bot";
            }
            else if (e.Node.Tag is Bot)
            {
                treeNodeCMenu.Items[0].Enabled = false;
            }
            else
            {
                //Unknown.
                treeNodeCMenu.Items[0].Enabled = true;
                treeNodeCMenu.Items[0].Text = "Add Child";
            }

            treeNodeCMenu.Show(tree, e.Location);
        }

        /// <summary>
        /// Triggered when the selected node is changed in any way.
        /// </summary>
        private void nodeSelectChanged(object sender, TreeViewEventArgs e)
        {
            //If the selected node is nothing, ignore and disable.
            if (tree.SelectedNode == null)
            {
                editTabs.Enabled = false;
                return;
            }

            //New node selected. What type is the tag?
            editTabs.Enabled = true;
            editTabs.TabPages.Clear();
            if (e.Node.Tag is Wave)
            {
                //Wave, enable and update the wave editor.
                editTabs.TabPages.Add(waveTab);
                UpdateWave((Wave)e.Node.Tag);
            }
            else if (e.Node.Tag is Squad)
            {
                //Squad, enable and update.
                editTabs.TabPages.Add(squadTab);
                UpdateSquad((Squad)e.Node.Tag);
            }
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

        /// <summary>
        /// Triggered when the right click context menu for the tree background has an
        /// item clicked on.
        /// </summary>
        private void treeCMenuClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //What item is being created?
            if (e.ClickedItem.Text == "New Wave")
            {
                //Make a new wave.
                var wave = new Wave();
                pop.Waves.Add(wave);
                tree.Nodes.Add(new TreeNode("Wave")
                {
                    Tag = wave
                });
            }
        }

        /// <summary>
        /// Triggered when the right click context menu for a tree node has an item clicked on.
        /// </summary>
        private void treeNodeCClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //What node is being right clicked?

            //wave
            if (tree.SelectedNode.Tag is Wave)
            {
                //Trying to remove or add child?
                if (e.ClickedItem.Text == "Add Squad")
                {
                    var squad = new Squad();
                    ((Wave)tree.SelectedNode.Tag).Squads.Add(squad);
                    tree.SelectedNode.Nodes.Add(new TreeNode()
                    {
                        Text = squad.Name,
                        Tag = squad
                    });
                }
                else if (e.ClickedItem.Text == "Delete")
                {
                    pop.Waves.Remove((Wave)tree.SelectedNode.Tag);
                    tree.Nodes.Remove(tree.SelectedNode);
                }
            }

            //squad
            else if (tree.SelectedNode.Tag is Squad)
            {
                //Squad node being right clicked, check if adding or removing.
                if (e.ClickedItem.Text == "Add Bot")
                {
                    var bot = new Bot();
                    ((Squad)tree.SelectedNode.Tag).Robots.Add(bot);
                    tree.SelectedNode.Nodes.Add(new TreeNode()
                    {
                        Text = bot.Name,
                        Tag = bot
                    });
                }
                else if (e.ClickedItem.Text == "Delete")
                {
                    //get parent wave node and remove the squad from it
                    ((Wave)tree.SelectedNode.Parent.Tag).Squads.Remove((Squad)tree.SelectedNode.Tag);
                    tree.Nodes.Remove(tree.SelectedNode);
                }
            }
        }
    }
}
