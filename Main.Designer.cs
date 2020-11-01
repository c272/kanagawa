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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.squadNameTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.squadCurrencyNum = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.squadFinishedSnd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.squadSpawnLastSnd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.squadSpawnSnd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.squadStartSnd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.squadWaitTillDeath = new System.Windows.Forms.TextBox();
            this.squadTotalCountNum = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.squadSpawnDelayNum = new System.Windows.Forms.NumericUpDown();
            this.squadWaitTillSpawn = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.squadStartDelayNum = new System.Windows.Forms.NumericUpDown();
            this.squadMaxActiveNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.squadSpawnCountNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.squadTitle = new System.Windows.Forms.Label();
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
            this.squadTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadCurrencyNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadTotalCountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadSpawnDelayNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadStartDelayNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadMaxActiveNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadSpawnCountNum)).BeginInit();
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
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.nodeSelectChanged);
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
            this.squadTab.Controls.Add(this.groupBox3);
            this.squadTab.Controls.Add(this.groupBox2);
            this.squadTab.Controls.Add(this.groupBox1);
            this.squadTab.Controls.Add(this.label5);
            this.squadTab.Controls.Add(this.squadTitle);
            this.squadTab.Location = new System.Drawing.Point(4, 25);
            this.squadTab.Name = "squadTab";
            this.squadTab.Padding = new System.Windows.Forms.Padding(3);
            this.squadTab.Size = new System.Drawing.Size(1025, 516);
            this.squadTab.TabIndex = 0;
            this.squadTab.Text = "Squad Editor";
            this.squadTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.squadNameTxt);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.squadCurrencyNum);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(23, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 138);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Settings";
            // 
            // squadNameTxt
            // 
            this.squadNameTxt.Location = new System.Drawing.Point(18, 97);
            this.squadNameTxt.Name = "squadNameTxt";
            this.squadNameTxt.Size = new System.Drawing.Size(262, 22);
            this.squadNameTxt.TabIndex = 9;
            this.squadNameTxt.TextChanged += new System.EventHandler(this.squadNameChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "Name";
            // 
            // squadCurrencyNum
            // 
            this.squadCurrencyNum.Location = new System.Drawing.Point(18, 47);
            this.squadCurrencyNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.squadCurrencyNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.squadCurrencyNum.Name = "squadCurrencyNum";
            this.squadCurrencyNum.Size = new System.Drawing.Size(262, 22);
            this.squadCurrencyNum.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Total Currency";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.squadFinishedSnd);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.squadSpawnLastSnd);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.squadSpawnSnd);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.squadStartSnd);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(23, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 237);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sound Settings";
            // 
            // squadFinishedSnd
            // 
            this.squadFinishedSnd.Location = new System.Drawing.Point(16, 196);
            this.squadFinishedSnd.Name = "squadFinishedSnd";
            this.squadFinishedSnd.Size = new System.Drawing.Size(224, 22);
            this.squadFinishedSnd.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Squad Finished Sound";
            // 
            // squadSpawnLastSnd
            // 
            this.squadSpawnLastSnd.Location = new System.Drawing.Point(16, 144);
            this.squadSpawnLastSnd.Name = "squadSpawnLastSnd";
            this.squadSpawnLastSnd.Size = new System.Drawing.Size(224, 22);
            this.squadSpawnLastSnd.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Last Spawn Sound";
            // 
            // squadSpawnSnd
            // 
            this.squadSpawnSnd.Location = new System.Drawing.Point(16, 93);
            this.squadSpawnSnd.Name = "squadSpawnSnd";
            this.squadSpawnSnd.Size = new System.Drawing.Size(224, 22);
            this.squadSpawnSnd.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "First Spawn Sound";
            // 
            // squadStartSnd
            // 
            this.squadStartSnd.Location = new System.Drawing.Point(16, 44);
            this.squadStartSnd.Name = "squadStartSnd";
            this.squadStartSnd.Size = new System.Drawing.Size(224, 22);
            this.squadStartSnd.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Squad Start Sound";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.squadWaitTillDeath);
            this.groupBox1.Controls.Add(this.squadTotalCountNum);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.squadSpawnDelayNum);
            this.groupBox1.Controls.Add(this.squadWaitTillSpawn);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.squadStartDelayNum);
            this.groupBox1.Controls.Add(this.squadMaxActiveNum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.squadSpawnCountNum);
            this.groupBox1.Location = new System.Drawing.Point(333, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 286);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spawning Robots";
            // 
            // squadWaitTillDeath
            // 
            this.squadWaitTillDeath.Location = new System.Drawing.Point(18, 251);
            this.squadWaitTillDeath.Name = "squadWaitTillDeath";
            this.squadWaitTillDeath.Size = new System.Drawing.Size(224, 22);
            this.squadWaitTillDeath.TabIndex = 11;
            // 
            // squadTotalCountNum
            // 
            this.squadTotalCountNum.Location = new System.Drawing.Point(18, 45);
            this.squadTotalCountNum.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.squadTotalCountNum.Name = "squadTotalCountNum";
            this.squadTotalCountNum.Size = new System.Drawing.Size(120, 22);
            this.squadTotalCountNum.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "Wait for this squad to die:";
            // 
            // squadSpawnDelayNum
            // 
            this.squadSpawnDelayNum.Location = new System.Drawing.Point(18, 145);
            this.squadSpawnDelayNum.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.squadSpawnDelayNum.Name = "squadSpawnDelayNum";
            this.squadSpawnDelayNum.Size = new System.Drawing.Size(120, 22);
            this.squadSpawnDelayNum.TabIndex = 11;
            // 
            // squadWaitTillSpawn
            // 
            this.squadWaitTillSpawn.Location = new System.Drawing.Point(18, 199);
            this.squadWaitTillSpawn.Name = "squadWaitTillSpawn";
            this.squadWaitTillSpawn.Size = new System.Drawing.Size(224, 22);
            this.squadWaitTillSpawn.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(190, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "Wait for this squad to spawn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Count";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Spawn Delay: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Max Active:";
            // 
            // squadStartDelayNum
            // 
            this.squadStartDelayNum.Location = new System.Drawing.Point(160, 94);
            this.squadStartDelayNum.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.squadStartDelayNum.Name = "squadStartDelayNum";
            this.squadStartDelayNum.Size = new System.Drawing.Size(120, 22);
            this.squadStartDelayNum.TabIndex = 9;
            // 
            // squadMaxActiveNum
            // 
            this.squadMaxActiveNum.Location = new System.Drawing.Point(160, 45);
            this.squadMaxActiveNum.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.squadMaxActiveNum.Name = "squadMaxActiveNum";
            this.squadMaxActiveNum.Size = new System.Drawing.Size(120, 22);
            this.squadMaxActiveNum.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Start Delay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Spawn Count:";
            // 
            // squadSpawnCountNum
            // 
            this.squadSpawnCountNum.Location = new System.Drawing.Point(18, 94);
            this.squadSpawnCountNum.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.squadSpawnCountNum.Name = "squadSpawnCountNum";
            this.squadSpawnCountNum.Size = new System.Drawing.Size(120, 22);
            this.squadSpawnCountNum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(553, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Configure top-level settings for your squad here. Bot-specific settings are not i" +
    "ncluded.";
            // 
            // squadTitle
            // 
            this.squadTitle.AutoSize = true;
            this.squadTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squadTitle.Location = new System.Drawing.Point(14, 17);
            this.squadTitle.Name = "squadTitle";
            this.squadTitle.Size = new System.Drawing.Size(446, 38);
            this.squadTitle.TabIndex = 0;
            this.squadTitle.Text = "Editing Squad \"New Squad\"";
            // 
            // robotTab
            // 
            this.robotTab.Location = new System.Drawing.Point(4, 25);
            this.robotTab.Name = "robotTab";
            this.robotTab.Padding = new System.Windows.Forms.Padding(3);
            this.robotTab.Size = new System.Drawing.Size(1025, 516);
            this.robotTab.TabIndex = 1;
            this.robotTab.Text = "Robot Editor";
            this.robotTab.UseVisualStyleBackColor = true;
            // 
            // missionTab
            // 
            this.missionTab.Location = new System.Drawing.Point(4, 25);
            this.missionTab.Name = "missionTab";
            this.missionTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.missionTab.Size = new System.Drawing.Size(1025, 516);
            this.missionTab.TabIndex = 2;
            this.missionTab.Text = "Mission Editor";
            this.missionTab.UseVisualStyleBackColor = true;
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
            this.waveCheckpointCb.Location = new System.Drawing.Point(26, 140);
            this.waveCheckpointCb.Name = "waveCheckpointCb";
            this.waveCheckpointCb.Size = new System.Drawing.Size(108, 21);
            this.waveCheckpointCb.TabIndex = 5;
            this.waveCheckpointCb.Text = "Checkpoint?";
            this.waveCheckpointCb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.waveCheckpointCb.UseVisualStyleBackColor = true;
            // 
            // waveSoundTxt
            // 
            this.waveSoundTxt.Location = new System.Drawing.Point(27, 112);
            this.waveSoundTxt.Name = "waveSoundTxt";
            this.waveSoundTxt.Size = new System.Drawing.Size(210, 22);
            this.waveSoundTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wave Start Sound";
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
            this.treeNodeCMenu.Size = new System.Drawing.Size(145, 52);
            this.treeNodeCMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.treeNodeCClicked);
            // 
            // addChildBtn
            // 
            this.addChildBtn.Name = "addChildBtn";
            this.addChildBtn.Size = new System.Drawing.Size(144, 24);
            this.addChildBtn.Text = "Add Child";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(144, 24);
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
            this.squadTab.ResumeLayout(false);
            this.squadTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadCurrencyNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadTotalCountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadSpawnDelayNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadStartDelayNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadMaxActiveNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadSpawnCountNum)).EndInit();
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
        private Label label5;
        private Label squadTitle;
        private NumericUpDown squadTotalCountNum;
        private Label label6;
        private Label label7;
        private NumericUpDown squadSpawnCountNum;
        private Label label8;
        private NumericUpDown squadStartDelayNum;
        private Label label9;
        private NumericUpDown squadSpawnDelayNum;
        private Label label10;
        private GroupBox groupBox2;
        private Label label11;
        private GroupBox groupBox1;
        private TextBox squadFinishedSnd;
        private Label label14;
        private TextBox squadSpawnLastSnd;
        private Label label13;
        private TextBox squadSpawnSnd;
        private Label label12;
        private GroupBox groupBox3;
        private NumericUpDown squadCurrencyNum;
        private Label label15;
        private TextBox squadNameTxt;
        private Label label16;
        private TextBox squadWaitTillDeath;
        private Label label17;
        private TextBox squadWaitTillSpawn;
        private Label label18;
        private TextBox squadStartSnd;
        private NumericUpDown squadMaxActiveNum;
    }
}

