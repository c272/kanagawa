using System;
using System.Windows.Forms;

namespace kanagawa
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tree = new System.Windows.Forms.TreeView();
            this.treeGb = new System.Windows.Forms.GroupBox();
            this.editTabs = new System.Windows.Forms.TabControl();
            this.squadTab = new System.Windows.Forms.TabPage();
            this.robotTab = new System.Windows.Forms.TabPage();
            this.missionTab = new System.Windows.Forms.TabPage();
            this.waveTab = new System.Windows.Forms.TabPage();
            this.waveCheckpointCb = new System.Windows.Forms.CheckBox();
            this.waveSoundTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeNodeCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addChildBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.treeCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.treeGb.SuspendLayout();
            this.editTabs.SuspendLayout();
            this.waveTab.SuspendLayout();
            this.treeNodeCMenu.SuspendLayout();
            this.treeCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.addToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1343, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Location = new System.Drawing.Point(3, 18);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(274, 527);
            this.tree.TabIndex = 1;
            this.tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeItemClicked);
            this.tree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeClicked);
            // 
            // treeGb
            // 
            this.treeGb.Controls.Add(this.tree);
            this.treeGb.Location = new System.Drawing.Point(12, 31);
            this.treeGb.Name = "treeGb";
            this.treeGb.Size = new System.Drawing.Size(280, 548);
            this.treeGb.TabIndex = 2;
            this.treeGb.TabStop = false;
            this.treeGb.Text = "Popfile Viewer";
            // 
            // editTabs
            // 
            this.editTabs.Controls.Add(this.squadTab);
            this.editTabs.Controls.Add(this.robotTab);
            this.editTabs.Controls.Add(this.missionTab);
            this.editTabs.Controls.Add(this.waveTab);
            this.editTabs.Location = new System.Drawing.Point(298, 31);
            this.editTabs.Name = "editTabs";
            this.editTabs.SelectedIndex = 0;
            this.editTabs.Size = new System.Drawing.Size(1033, 545);
            this.editTabs.TabIndex = 3;
            // 
            // squadTab
            // 
            this.squadTab.Location = new System.Drawing.Point(4, 25);
            this.squadTab.Name = "squadTab";
            this.squadTab.Padding = new System.Windows.Forms.Padding(3);
            this.squadTab.Size = new System.Drawing.Size(1025, 516);
            this.squadTab.TabIndex = 0;
            this.squadTab.Text = "Squad Editor";
            // 
            // robotTab
            // 
            this.robotTab.Location = new System.Drawing.Point(4, 25);
            this.robotTab.Name = "robotTab";
            this.robotTab.Padding = new System.Windows.Forms.Padding(3);
            this.robotTab.Size = new System.Drawing.Size(1025, 516);
            this.robotTab.TabIndex = 1;
            this.robotTab.Text = "Robot Editor";
            // 
            // missionTab
            // 
            this.missionTab.Location = new System.Drawing.Point(4, 25);
            this.missionTab.Name = "missionTab";
            this.missionTab.Size = new System.Drawing.Size(1025, 516);
            this.missionTab.TabIndex = 2;
            this.missionTab.Text = "Mission Editor";
            // 
            // waveTab
            // 
            this.waveTab.Controls.Add(this.waveCheckpointCb);
            this.waveTab.Controls.Add(this.waveSoundTxt);
            this.waveTab.Controls.Add(this.label3);
            this.waveTab.Controls.Add(this.label2);
            this.waveTab.Controls.Add(this.label1);
            this.waveTab.Location = new System.Drawing.Point(4, 25);
            this.waveTab.Name = "waveTab";
            this.waveTab.Size = new System.Drawing.Size(1025, 516);
            this.waveTab.TabIndex = 3;
            this.waveTab.Text = " Wave Editor";
            this.waveTab.UseVisualStyleBackColor = true;
            // 
            // waveCheckpointCb
            // 
            this.waveCheckpointCb.AutoSize = true;
            this.waveCheckpointCb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.waveCheckpointCb.Location = new System.Drawing.Point(23, 125);
            this.waveCheckpointCb.Name = "waveCheckpointCb";
            this.waveCheckpointCb.Size = new System.Drawing.Size(108, 21);
            this.waveCheckpointCb.TabIndex = 5;
            this.waveCheckpointCb.Text = "Checkpoint?";
            this.waveCheckpointCb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.waveCheckpointCb.UseVisualStyleBackColor = true;
            this.waveCheckpointCb.CheckedChanged += new System.EventHandler(this.waveCheckpointChanged);
            // 
            // waveSoundTxt
            // 
            this.waveSoundTxt.Location = new System.Drawing.Point(152, 96);
            this.waveSoundTxt.Name = "waveSoundTxt";
            this.waveSoundTxt.Size = new System.Drawing.Size(210, 22);
            this.waveSoundTxt.TabIndex = 3;
            this.waveSoundTxt.TextChanged += new System.EventHandler(this.waveSoundChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wave Start Sound: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edit settings for this wave here, including sound and checkpointing.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wave Editor";
            // 
            // treeNodeCMenu
            // 
            this.treeNodeCMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.treeNodeCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChildBtn,
            this.deleteBtn});
            this.treeNodeCMenu.Name = "treeNodeCMenu";
            this.treeNodeCMenu.Size = new System.Drawing.Size(211, 80);
            this.treeNodeCMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.treeNodeCClicked);
            // 
            // addChildBtn
            // 
            this.addChildBtn.Name = "addChildBtn";
            this.addChildBtn.Size = new System.Drawing.Size(210, 24);
            this.addChildBtn.Text = "Add Child";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(210, 24);
            this.deleteBtn.Text = "Delete";
            // 
            // treeCMenu
            // 
            this.treeCMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.treeCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMissionToolStripMenuItem,
            this.newWaveToolStripMenuItem});
            this.treeCMenu.Name = "treeCMenu";
            this.treeCMenu.Size = new System.Drawing.Size(163, 52);
            this.treeCMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.treeCMenuClicked);
            // 
            // newMissionToolStripMenuItem
            // 
            this.newMissionToolStripMenuItem.Name = "newMissionToolStripMenuItem";
            this.newMissionToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.newMissionToolStripMenuItem.Text = "New Mission";
            // 
            // newWaveToolStripMenuItem
            // 
            this.newWaveToolStripMenuItem.Name = "newWaveToolStripMenuItem";
            this.newWaveToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.newWaveToolStripMenuItem.Text = "New Wave";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 591);
            this.Controls.Add(this.editTabs);
            this.Controls.Add(this.treeGb);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Main";
            this.Text = "Kanagawa";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.treeGb.ResumeLayout(false);
            this.editTabs.ResumeLayout(false);
            this.waveTab.ResumeLayout(false);
            this.waveTab.PerformLayout();
            this.treeNodeCMenu.ResumeLayout(false);
            this.treeCMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.GroupBox treeGb;
        private System.Windows.Forms.TabControl editTabs;
        private System.Windows.Forms.TabPage squadTab;
        private System.Windows.Forms.TabPage robotTab;
        private System.Windows.Forms.ContextMenuStrip treeNodeCMenu;
        private System.Windows.Forms.ToolStripMenuItem addChildBtn;
        private System.Windows.Forms.ToolStripMenuItem deleteBtn;
        private ContextMenuStrip treeCMenu;
        private ToolStripMenuItem newMissionToolStripMenuItem;
        private ToolStripMenuItem newWaveToolStripMenuItem;
        private TabPage missionTab;
        private TabPage waveTab;
        private CheckBox waveCheckpointCb;
        private TextBox waveSoundTxt;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}

