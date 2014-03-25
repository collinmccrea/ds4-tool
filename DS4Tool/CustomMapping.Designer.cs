namespace ScpServer
{
    partial class CustomMapping
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.cbScanCode = new System.Windows.Forms.CheckBox();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.x360ControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keystrokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbR3 = new ScpServer.AdvancedComboBox();
            this.cbCross = new ScpServer.AdvancedComboBox();
            this.cbTriangle = new ScpServer.AdvancedComboBox();
            this.cbRY = new ScpServer.AdvancedComboBox();
            this.cbRX = new ScpServer.AdvancedComboBox();
            this.cbOptions = new ScpServer.AdvancedComboBox();
            this.cbTouchMulti = new ScpServer.AdvancedComboBox();
            this.cbTouchUpper = new ScpServer.AdvancedComboBox();
            this.cbTouchButton = new ScpServer.AdvancedComboBox();
            this.cbPS = new ScpServer.AdvancedComboBox();
            this.cbL1 = new ScpServer.AdvancedComboBox();
            this.cbR1 = new ScpServer.AdvancedComboBox();
            this.cbShare = new ScpServer.AdvancedComboBox();
            this.cbL3 = new ScpServer.AdvancedComboBox();
            this.cbL2 = new ScpServer.AdvancedComboBox();
            this.cbR2 = new ScpServer.AdvancedComboBox();
            this.cbDown = new ScpServer.AdvancedComboBox();
            this.cbCircle = new ScpServer.AdvancedComboBox();
            this.cbSquare = new ScpServer.AdvancedComboBox();
            this.cbUp = new ScpServer.AdvancedComboBox();
            this.cbLeft = new ScpServer.AdvancedComboBox();
            this.cbRight = new ScpServer.AdvancedComboBox();
            this.cbRX2 = new ScpServer.AdvancedComboBox();
            this.cbRY2 = new ScpServer.AdvancedComboBox();
            this.cbLY2 = new ScpServer.AdvancedComboBox();
            this.cbLY = new ScpServer.AdvancedComboBox();
            this.cbLX = new ScpServer.AdvancedComboBox();
            this.cbLX2 = new ScpServer.AdvancedComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = global::ScpServer.Properties.Resources.DS4_Control_Shadows__small_;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 278);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(12, 284);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(65, 21);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(83, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 21);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbRepeat.Location = new System.Drawing.Point(342, 287);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(61, 17);
            this.cbRepeat.TabIndex = 26;
            this.cbRepeat.Text = "Repeat";
            this.cbRepeat.UseVisualStyleBackColor = true;
            this.cbRepeat.CheckedChanged += new System.EventHandler(this.cbRepeat_CheckedChanged);
            // 
            // cbScanCode
            // 
            this.cbScanCode.AutoSize = true;
            this.cbScanCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbScanCode.Location = new System.Drawing.Point(409, 287);
            this.cbScanCode.Name = "cbScanCode";
            this.cbScanCode.Size = new System.Drawing.Size(79, 17);
            this.cbScanCode.TabIndex = 50;
            this.cbScanCode.Text = "Scan Code";
            this.cbScanCode.UseVisualStyleBackColor = true;
            this.cbScanCode.CheckedChanged += new System.EventHandler(this.cbScanCode_CheckedChanged);
            // 
            // txtZone
            // 
            this.txtZone.Enabled = false;
            this.txtZone.Location = new System.Drawing.Point(215, 285);
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(80, 20);
            this.txtZone.TabIndex = 53;
            this.txtZone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x360ControlsToolStripMenuItem,
            this.keystrokeToolStripMenuItem,
            this.mouseMovementToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 70);
            // 
            // x360ControlsToolStripMenuItem
            // 
            this.x360ControlsToolStripMenuItem.Name = "x360ControlsToolStripMenuItem";
            this.x360ControlsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.x360ControlsToolStripMenuItem.Text = "X360 Controls";
            this.x360ControlsToolStripMenuItem.Click += new System.EventHandler(this.x360ControlsToolStripMenuItem_Click);
            // 
            // keystrokeToolStripMenuItem
            // 
            this.keystrokeToolStripMenuItem.Name = "keystrokeToolStripMenuItem";
            this.keystrokeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.keystrokeToolStripMenuItem.Text = "Keystroke";
            this.keystrokeToolStripMenuItem.Click += new System.EventHandler(this.keystrokeToolStripMenuItem_Click);
            // 
            // mouseMovementToolStripMenuItem
            // 
            this.mouseMovementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseUpToolStripMenuItem,
            this.mouseLeftToolStripMenuItem,
            this.mouseRightToolStripMenuItem,
            this.mouseDownToolStripMenuItem});
            this.mouseMovementToolStripMenuItem.Name = "mouseMovementToolStripMenuItem";
            this.mouseMovementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mouseMovementToolStripMenuItem.Text = "Mouse Movement";
            // 
            // mouseUpToolStripMenuItem
            // 
            this.mouseUpToolStripMenuItem.Name = "mouseUpToolStripMenuItem";
            this.mouseUpToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mouseUpToolStripMenuItem.Text = "Mouse Up";
            this.mouseUpToolStripMenuItem.Click += new System.EventHandler(this.mouseMovementToolStripMenuItem_Click);
            // 
            // mouseLeftToolStripMenuItem
            // 
            this.mouseLeftToolStripMenuItem.Name = "mouseLeftToolStripMenuItem";
            this.mouseLeftToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mouseLeftToolStripMenuItem.Text = "Mouse Left";
            this.mouseLeftToolStripMenuItem.Click += new System.EventHandler(this.mouseMovementToolStripMenuItem_Click);
            // 
            // mouseRightToolStripMenuItem
            // 
            this.mouseRightToolStripMenuItem.Name = "mouseRightToolStripMenuItem";
            this.mouseRightToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mouseRightToolStripMenuItem.Text = "Mouse Right";
            this.mouseRightToolStripMenuItem.Click += new System.EventHandler(this.mouseMovementToolStripMenuItem_Click);
            // 
            // mouseDownToolStripMenuItem
            // 
            this.mouseDownToolStripMenuItem.Name = "mouseDownToolStripMenuItem";
            this.mouseDownToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mouseDownToolStripMenuItem.Text = "Mouse Down";
            this.mouseDownToolStripMenuItem.Click += new System.EventHandler(this.mouseMovementToolStripMenuItem_Click);
            // 
            // cbR3
            // 
            this.cbR3.Color = System.Drawing.Color.Blue;
            this.cbR3.DropDownWidth = 100;
            this.cbR3.FormattingEnabled = true;
            this.cbR3.Location = new System.Drawing.Point(311, 234);
            this.cbR3.MaxLength = 1;
            this.cbR3.Name = "cbR3";
            this.cbR3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbR3.Size = new System.Drawing.Size(52, 21);
            this.cbR3.TabIndex = 17;
            this.cbR3.Text = "Right Stick";
            // 
            // cbCross
            // 
            this.cbCross.Color = System.Drawing.Color.Blue;
            this.cbCross.DropDownWidth = 100;
            this.cbCross.FormattingEnabled = true;
            this.cbCross.Location = new System.Drawing.Point(403, 196);
            this.cbCross.MaxLength = 1;
            this.cbCross.Name = "cbCross";
            this.cbCross.Size = new System.Drawing.Size(32, 21);
            this.cbCross.TabIndex = 13;
            this.cbCross.Text = "A Button";
            // 
            // cbTriangle
            // 
            this.cbTriangle.Color = System.Drawing.Color.Blue;
            this.cbTriangle.DropDownWidth = 100;
            this.cbTriangle.FormattingEnabled = true;
            this.cbTriangle.Location = new System.Drawing.Point(419, 140);
            this.cbTriangle.MaxLength = 1;
            this.cbTriangle.Name = "cbTriangle";
            this.cbTriangle.Size = new System.Drawing.Size(32, 21);
            this.cbTriangle.TabIndex = 10;
            this.cbTriangle.Text = "Y Button";
            // 
            // cbRY
            // 
            this.cbRY.Color = System.Drawing.Color.Blue;
            this.cbRY.DropDownWidth = 100;
            this.cbRY.FormattingEnabled = true;
            this.cbRY.Location = new System.Drawing.Point(302, 212);
            this.cbRY.MaxLength = 1;
            this.cbRY.Name = "cbRY";
            this.cbRY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbRY.Size = new System.Drawing.Size(70, 21);
            this.cbRY.TabIndex = 16;
            this.cbRY.Text = "Right Y-Axis-";
            // 
            // cbRX
            // 
            this.cbRX.Color = System.Drawing.Color.Blue;
            this.cbRX.DropDownWidth = 100;
            this.cbRX.FormattingEnabled = true;
            this.cbRX.Location = new System.Drawing.Point(249, 234);
            this.cbRX.MaxLength = 1;
            this.cbRX.Name = "cbRX";
            this.cbRX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbRX.Size = new System.Drawing.Size(70, 21);
            this.cbRX.TabIndex = 15;
            this.cbRX.Text = "Right X-Axis-";
            // 
            // cbOptions
            // 
            this.cbOptions.Color = System.Drawing.Color.Blue;
            this.cbOptions.DropDownWidth = 100;
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Location = new System.Drawing.Point(359, 97);
            this.cbOptions.MaxLength = 1;
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(44, 21);
            this.cbOptions.TabIndex = 14;
            this.cbOptions.Text = "Start";
            // 
            // cbTouchMulti
            // 
            this.cbTouchMulti.Color = System.Drawing.Color.Blue;
            this.cbTouchMulti.DropDownWidth = 100;
            this.cbTouchMulti.FormattingEnabled = true;
            this.cbTouchMulti.Location = new System.Drawing.Point(219, 143);
            this.cbTouchMulti.MaxLength = 1;
            this.cbTouchMulti.Name = "cbTouchMulti";
            this.cbTouchMulti.Size = new System.Drawing.Size(72, 21);
            this.cbTouchMulti.TabIndex = 23;
            this.cbTouchMulti.Text = "Right Click";
            // 
            // cbTouchUpper
            // 
            this.cbTouchUpper.Color = System.Drawing.Color.Blue;
            this.cbTouchUpper.DropDownWidth = 100;
            this.cbTouchUpper.FormattingEnabled = true;
            this.cbTouchUpper.Location = new System.Drawing.Point(215, 84);
            this.cbTouchUpper.MaxLength = 1;
            this.cbTouchUpper.Name = "cbTouchUpper";
            this.cbTouchUpper.Size = new System.Drawing.Size(80, 21);
            this.cbTouchUpper.TabIndex = 22;
            this.cbTouchUpper.Text = "Middle Click";
            // 
            // cbTouchButton
            // 
            this.cbTouchButton.Color = System.Drawing.Color.Blue;
            this.cbTouchButton.DropDownWidth = 100;
            this.cbTouchButton.FormattingEnabled = true;
            this.cbTouchButton.Location = new System.Drawing.Point(232, 164);
            this.cbTouchButton.MaxLength = 1;
            this.cbTouchButton.Name = "cbTouchButton";
            this.cbTouchButton.Size = new System.Drawing.Size(45, 21);
            this.cbTouchButton.TabIndex = 21;
            this.cbTouchButton.Text = "Click";
            // 
            // cbPS
            // 
            this.cbPS.Color = System.Drawing.Color.Blue;
            this.cbPS.DropDownWidth = 100;
            this.cbPS.FormattingEnabled = true;
            this.cbPS.Location = new System.Drawing.Point(229, 205);
            this.cbPS.MaxLength = 1;
            this.cbPS.Name = "cbPS";
            this.cbPS.Size = new System.Drawing.Size(50, 21);
            this.cbPS.TabIndex = 20;
            this.cbPS.Text = "Guide";
            // 
            // cbL1
            // 
            this.cbL1.Color = System.Drawing.Color.Blue;
            this.cbL1.DropDownWidth = 100;
            this.cbL1.FormattingEnabled = true;
            this.cbL1.Location = new System.Drawing.Point(39, 60);
            this.cbL1.MaxLength = 1;
            this.cbL1.Name = "cbL1";
            this.cbL1.Size = new System.Drawing.Size(80, 21);
            this.cbL1.TabIndex = 7;
            this.cbL1.Text = "Left Bumper";
            // 
            // cbR1
            // 
            this.cbR1.Color = System.Drawing.Color.Blue;
            this.cbR1.DropDownWidth = 100;
            this.cbR1.FormattingEnabled = true;
            this.cbR1.Location = new System.Drawing.Point(398, 60);
            this.cbR1.MaxLength = 1;
            this.cbR1.Name = "cbR1";
            this.cbR1.Size = new System.Drawing.Size(87, 21);
            this.cbR1.TabIndex = 19;
            this.cbR1.Text = "Right Bumper";
            // 
            // cbShare
            // 
            this.cbShare.Color = System.Drawing.Color.Blue;
            this.cbShare.DropDownWidth = 100;
            this.cbShare.FormattingEnabled = true;
            this.cbShare.Location = new System.Drawing.Point(116, 98);
            this.cbShare.MaxLength = 1;
            this.cbShare.Name = "cbShare";
            this.cbShare.Size = new System.Drawing.Size(48, 21);
            this.cbShare.TabIndex = 4;
            this.cbShare.Text = "Back";
            // 
            // cbL3
            // 
            this.cbL3.Color = System.Drawing.Color.Blue;
            this.cbL3.DropDownWidth = 100;
            this.cbL3.FormattingEnabled = true;
            this.cbL3.Location = new System.Drawing.Point(144, 234);
            this.cbL3.MaxLength = 1;
            this.cbL3.Name = "cbL3";
            this.cbL3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbL3.Size = new System.Drawing.Size(52, 21);
            this.cbL3.TabIndex = 9;
            this.cbL3.Text = "Left Stick";
            // 
            // cbL2
            // 
            this.cbL2.Color = System.Drawing.Color.Blue;
            this.cbL2.DropDownWidth = 100;
            this.cbL2.FormattingEnabled = true;
            this.cbL2.Location = new System.Drawing.Point(54, 32);
            this.cbL2.MaxLength = 1;
            this.cbL2.Name = "cbL2";
            this.cbL2.Size = new System.Drawing.Size(77, 21);
            this.cbL2.TabIndex = 8;
            this.cbL2.Text = "Left Trigger";
            // 
            // cbR2
            // 
            this.cbR2.Color = System.Drawing.Color.Blue;
            this.cbR2.DropDownWidth = 100;
            this.cbR2.FormattingEnabled = true;
            this.cbR2.Location = new System.Drawing.Point(378, 32);
            this.cbR2.MaxLength = 1;
            this.cbR2.Name = "cbR2";
            this.cbR2.Size = new System.Drawing.Size(83, 21);
            this.cbR2.TabIndex = 18;
            this.cbR2.Text = "Right Trigger";
            // 
            // cbDown
            // 
            this.cbDown.Color = System.Drawing.Color.Blue;
            this.cbDown.DropDownWidth = 100;
            this.cbDown.FormattingEnabled = true;
            this.cbDown.Location = new System.Drawing.Point(65, 189);
            this.cbDown.MaxLength = 1;
            this.cbDown.Name = "cbDown";
            this.cbDown.Size = new System.Drawing.Size(52, 21);
            this.cbDown.TabIndex = 3;
            this.cbDown.Text = "Down Button";
            // 
            // cbCircle
            // 
            this.cbCircle.Color = System.Drawing.Color.Blue;
            this.cbCircle.DropDownWidth = 100;
            this.cbCircle.FormattingEnabled = true;
            this.cbCircle.Location = new System.Drawing.Point(449, 169);
            this.cbCircle.MaxLength = 1;
            this.cbCircle.Name = "cbCircle";
            this.cbCircle.Size = new System.Drawing.Size(32, 21);
            this.cbCircle.TabIndex = 12;
            this.cbCircle.Text = "B Button";
            // 
            // cbSquare
            // 
            this.cbSquare.Color = System.Drawing.Color.Blue;
            this.cbSquare.DropDownWidth = 100;
            this.cbSquare.FormattingEnabled = true;
            this.cbSquare.Location = new System.Drawing.Point(369, 169);
            this.cbSquare.MaxLength = 1;
            this.cbSquare.Name = "cbSquare";
            this.cbSquare.Size = new System.Drawing.Size(32, 21);
            this.cbSquare.TabIndex = 11;
            this.cbSquare.Text = "X Button";
            // 
            // cbUp
            // 
            this.cbUp.Color = System.Drawing.Color.Blue;
            this.cbUp.DropDownWidth = 100;
            this.cbUp.FormattingEnabled = true;
            this.cbUp.Location = new System.Drawing.Point(62, 149);
            this.cbUp.MaxLength = 1;
            this.cbUp.Name = "cbUp";
            this.cbUp.Size = new System.Drawing.Size(36, 21);
            this.cbUp.TabIndex = 0;
            this.cbUp.Text = "Up Button";
            // 
            // cbLeft
            // 
            this.cbLeft.Color = System.Drawing.Color.Blue;
            this.cbLeft.DropDownWidth = 100;
            this.cbLeft.FormattingEnabled = true;
            this.cbLeft.Location = new System.Drawing.Point(32, 169);
            this.cbLeft.MaxLength = 1;
            this.cbLeft.Name = "cbLeft";
            this.cbLeft.Size = new System.Drawing.Size(40, 21);
            this.cbLeft.TabIndex = 1;
            this.cbLeft.Text = "Left Button";
            // 
            // cbRight
            // 
            this.cbRight.Color = System.Drawing.Color.Blue;
            this.cbRight.DropDownWidth = 100;
            this.cbRight.FormattingEnabled = true;
            this.cbRight.Location = new System.Drawing.Point(93, 169);
            this.cbRight.MaxLength = 1;
            this.cbRight.Name = "cbRight";
            this.cbRight.Size = new System.Drawing.Size(47, 21);
            this.cbRight.TabIndex = 2;
            this.cbRight.Text = "Right Button";
            // 
            // cbRX2
            // 
            this.cbRX2.Color = System.Drawing.Color.Blue;
            this.cbRX2.DropDownWidth = 100;
            this.cbRX2.FormattingEnabled = true;
            this.cbRX2.Location = new System.Drawing.Point(354, 234);
            this.cbRX2.MaxLength = 1;
            this.cbRX2.Name = "cbRX2";
            this.cbRX2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbRX2.Size = new System.Drawing.Size(70, 21);
            this.cbRX2.TabIndex = 48;
            this.cbRX2.Text = "Right X-Axis+";
            // 
            // cbRY2
            // 
            this.cbRY2.Color = System.Drawing.Color.Blue;
            this.cbRY2.DropDownWidth = 100;
            this.cbRY2.FormattingEnabled = true;
            this.cbRY2.Location = new System.Drawing.Point(302, 256);
            this.cbRY2.MaxLength = 1;
            this.cbRY2.Name = "cbRY2";
            this.cbRY2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbRY2.Size = new System.Drawing.Size(70, 21);
            this.cbRY2.TabIndex = 49;
            this.cbRY2.Text = "Right Y-Axis+";
            // 
            // cbLY2
            // 
            this.cbLY2.Color = System.Drawing.Color.Blue;
            this.cbLY2.DropDownWidth = 100;
            this.cbLY2.FormattingEnabled = true;
            this.cbLY2.Location = new System.Drawing.Point(137, 256);
            this.cbLY2.MaxLength = 1;
            this.cbLY2.Name = "cbLY2";
            this.cbLY2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbLY2.Size = new System.Drawing.Size(70, 21);
            this.cbLY2.TabIndex = 47;
            this.cbLY2.Text = "Left Y-Axis+";
            // 
            // cbLY
            // 
            this.cbLY.Color = System.Drawing.Color.Blue;
            this.cbLY.DropDownWidth = 100;
            this.cbLY.FormattingEnabled = true;
            this.cbLY.Location = new System.Drawing.Point(137, 212);
            this.cbLY.MaxLength = 1;
            this.cbLY.Name = "cbLY";
            this.cbLY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbLY.Size = new System.Drawing.Size(70, 21);
            this.cbLY.TabIndex = 6;
            this.cbLY.Text = "Left Y-Axis-";
            // 
            // cbLX
            // 
            this.cbLX.Color = System.Drawing.Color.Blue;
            this.cbLX.DropDownWidth = 100;
            this.cbLX.FormattingEnabled = true;
            this.cbLX.Location = new System.Drawing.Point(80, 234);
            this.cbLX.MaxLength = 1;
            this.cbLX.Name = "cbLX";
            this.cbLX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbLX.Size = new System.Drawing.Size(70, 21);
            this.cbLX.TabIndex = 5;
            this.cbLX.Text = "Left X-Axis-";
            // 
            // cbLX2
            // 
            this.cbLX2.Color = System.Drawing.Color.Blue;
            this.cbLX2.DropDownWidth = 100;
            this.cbLX2.FormattingEnabled = true;
            this.cbLX2.Location = new System.Drawing.Point(187, 234);
            this.cbLX2.MaxLength = 1;
            this.cbLX2.Name = "cbLX2";
            this.cbLX2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbLX2.Size = new System.Drawing.Size(70, 21);
            this.cbLX2.TabIndex = 46;
            this.cbLX2.Text = "Left X-Axis+";
            // 
            // CustomMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ScpServer.Properties.Resources.DS4_Control_Shadows__small_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 311);
            this.Controls.Add(this.cbR3);
            this.Controls.Add(this.txtZone);
            this.Controls.Add(this.cbScanCode);
            this.Controls.Add(this.cbRepeat);
            this.Controls.Add(this.cbCross);
            this.Controls.Add(this.cbTriangle);
            this.Controls.Add(this.cbRY);
            this.Controls.Add(this.cbRX);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.cbTouchMulti);
            this.Controls.Add(this.cbTouchUpper);
            this.Controls.Add(this.cbTouchButton);
            this.Controls.Add(this.cbPS);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cbL1);
            this.Controls.Add(this.cbR1);
            this.Controls.Add(this.cbShare);
            this.Controls.Add(this.cbL3);
            this.Controls.Add(this.cbL2);
            this.Controls.Add(this.cbR2);
            this.Controls.Add(this.cbDown);
            this.Controls.Add(this.cbCircle);
            this.Controls.Add(this.cbSquare);
            this.Controls.Add(this.cbUp);
            this.Controls.Add(this.cbLeft);
            this.Controls.Add(this.cbRight);
            this.Controls.Add(this.cbRX2);
            this.Controls.Add(this.cbRY2);
            this.Controls.Add(this.cbLY2);
            this.Controls.Add(this.cbLY);
            this.Controls.Add(this.cbLX);
            this.Controls.Add(this.cbLX2);
            this.Controls.Add(this.pictureBox);
            this.Name = "CustomMapping";
            this.Text = "Custom Mapping";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private AdvancedComboBox cbSquare;
        private AdvancedComboBox cbCircle;
        private AdvancedComboBox cbTriangle;
        private AdvancedComboBox cbCross;
        private AdvancedComboBox cbDown;
        private AdvancedComboBox cbUp;
        private AdvancedComboBox cbRight;
        private AdvancedComboBox cbLeft;
        private AdvancedComboBox cbR1;
        private AdvancedComboBox cbR2;
        private AdvancedComboBox cbR3;
        private AdvancedComboBox cbL1;
        private AdvancedComboBox cbL2;
        private AdvancedComboBox cbL3;
        private AdvancedComboBox cbOptions;
        private AdvancedComboBox cbShare;
        private AdvancedComboBox cbPS;
        private AdvancedComboBox cbTouchButton;
        private AdvancedComboBox cbLX;
        private AdvancedComboBox cbLY;
        private AdvancedComboBox cbRX;
        private AdvancedComboBox cbRY;
        private AdvancedComboBox cbLY2;
        private AdvancedComboBox cbLX2;
        private AdvancedComboBox cbRY2;
        private AdvancedComboBox cbRX2;
        private AdvancedComboBox cbTouchUpper;
        private AdvancedComboBox cbTouchMulti;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbScanCode;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem x360ControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keystrokeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseMovementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseDownToolStripMenuItem;
    }
}