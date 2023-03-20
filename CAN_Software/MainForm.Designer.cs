
namespace CAN_Software
{
	partial class CANAnalyser
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CANText = new System.Windows.Forms.RichTextBox();
			this.serialPort = new System.IO.Ports.SerialPort(this.components);
			this.openButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.portSelect = new System.Windows.Forms.ComboBox();
			this.baudSelect = new System.Windows.Forms.ComboBox();
			this.filterBox = new System.Windows.Forms.TextBox();
			this.filterButton = new System.Windows.Forms.Button();
			this.filterList = new System.Windows.Forms.TextBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.focusButton = new System.Windows.Forms.Button();
			this.focusBox = new System.Windows.Forms.TextBox();
			this.pauseButton = new System.Windows.Forms.Button();
			this.tabController = new System.Windows.Forms.TabControl();
			this.analyserTab = new System.Windows.Forms.TabPage();
			this.debuggerTab = new System.Windows.Forms.TabPage();
			this.grapherTab = new System.Windows.Forms.TabPage();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
			this.makeSelection = new System.Windows.Forms.ComboBox();
			this.modelSelection = new System.Windows.Forms.ComboBox();
			this.tranmissionType = new System.Windows.Forms.ComboBox();
			this.engineSize = new System.Windows.Forms.ComboBox();
			this.fuelType = new System.Windows.Forms.ComboBox();
			this.regYearSelection = new System.Windows.Forms.ComboBox();
			this.drivetrainBox = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.makeLabel = new System.Windows.Forms.Label();
			this.modelLabel = new System.Windows.Forms.Label();
			this.regYearLabel = new System.Windows.Forms.Label();
			this.engineSizeLabel = new System.Windows.Forms.Label();
			this.fuelTypeLabel = new System.Windows.Forms.Label();
			this.transmissionTypeLabel = new System.Windows.Forms.Label();
			this.drivetrainLabel = new System.Windows.Forms.Label();
			this.profileSave = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.tabController.SuspendLayout();
			this.analyserTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
			this.viewToolStripMenuItem.Text = "View";
			this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
			this.toolsToolStripMenuItem.Text = "Tools";
			this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// CANText
			// 
			this.CANText.EnableAutoDragDrop = true;
			this.CANText.Location = new System.Drawing.Point(5, 4);
			this.CANText.Margin = new System.Windows.Forms.Padding(2);
			this.CANText.Name = "CANText";
			this.CANText.ReadOnly = true;
			this.CANText.Size = new System.Drawing.Size(443, 905);
			this.CANText.TabIndex = 2;
			this.CANText.Text = "";
			this.CANText.TextChanged += new System.EventHandler(this.CANText_TextChanged);
			// 
			// serialPort
			// 
			this.serialPort.BaudRate = 500000;
			this.serialPort.PortName = "COM4";
			// 
			// openButton
			// 
			this.openButton.Location = new System.Drawing.Point(452, 83);
			this.openButton.Margin = new System.Windows.Forms.Padding(2);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(50, 51);
			this.openButton.TabIndex = 3;
			this.openButton.Text = "open";
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(588, 83);
			this.closeButton.Margin = new System.Windows.Forms.Padding(2);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(50, 51);
			this.closeButton.TabIndex = 4;
			this.closeButton.Text = "close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// portSelect
			// 
			this.portSelect.FormattingEnabled = true;
			this.portSelect.Location = new System.Drawing.Point(452, 4);
			this.portSelect.Margin = new System.Windows.Forms.Padding(2);
			this.portSelect.Name = "portSelect";
			this.portSelect.Size = new System.Drawing.Size(82, 21);
			this.portSelect.TabIndex = 5;
			this.portSelect.SelectedIndexChanged += new System.EventHandler(this.portSelect_SelectedIndexChanged);
			// 
			// baudSelect
			// 
			this.baudSelect.FormattingEnabled = true;
			this.baudSelect.Location = new System.Drawing.Point(452, 47);
			this.baudSelect.Margin = new System.Windows.Forms.Padding(2);
			this.baudSelect.Name = "baudSelect";
			this.baudSelect.Size = new System.Drawing.Size(82, 21);
			this.baudSelect.TabIndex = 6;
			this.baudSelect.SelectedIndexChanged += new System.EventHandler(this.baudSelect_SelectedIndexChanged);
			// 
			// filterBox
			// 
			this.filterBox.Location = new System.Drawing.Point(671, 146);
			this.filterBox.Margin = new System.Windows.Forms.Padding(2);
			this.filterBox.Name = "filterBox";
			this.filterBox.Size = new System.Drawing.Size(77, 20);
			this.filterBox.TabIndex = 7;
			this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
			// 
			// filterButton
			// 
			this.filterButton.Location = new System.Drawing.Point(588, 146);
			this.filterButton.Margin = new System.Windows.Forms.Padding(2);
			this.filterButton.Name = "filterButton";
			this.filterButton.Size = new System.Drawing.Size(50, 25);
			this.filterButton.TabIndex = 8;
			this.filterButton.Text = "filter";
			this.filterButton.UseVisualStyleBackColor = true;
			this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
			// 
			// filterList
			// 
			this.filterList.Location = new System.Drawing.Point(455, 146);
			this.filterList.Margin = new System.Windows.Forms.Padding(2);
			this.filterList.Multiline = true;
			this.filterList.Name = "filterList";
			this.filterList.Size = new System.Drawing.Size(116, 732);
			this.filterList.TabIndex = 9;
			this.filterList.TextChanged += new System.EventHandler(this.filterList_TextChanged);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(455, 882);
			this.clearButton.Margin = new System.Windows.Forms.Padding(2);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(116, 27);
			this.clearButton.TabIndex = 10;
			this.clearButton.Text = "clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// focusButton
			// 
			this.focusButton.Location = new System.Drawing.Point(588, 190);
			this.focusButton.Margin = new System.Windows.Forms.Padding(2);
			this.focusButton.Name = "focusButton";
			this.focusButton.Size = new System.Drawing.Size(50, 23);
			this.focusButton.TabIndex = 11;
			this.focusButton.Text = "focus";
			this.focusButton.UseVisualStyleBackColor = true;
			this.focusButton.Click += new System.EventHandler(this.focusButton_Click_1);
			// 
			// focusBox
			// 
			this.focusBox.Location = new System.Drawing.Point(671, 193);
			this.focusBox.Margin = new System.Windows.Forms.Padding(2);
			this.focusBox.Name = "focusBox";
			this.focusBox.Size = new System.Drawing.Size(77, 20);
			this.focusBox.TabIndex = 12;
			this.focusBox.TextChanged += new System.EventHandler(this.focusBox_TextChanged);
			// 
			// pauseButton
			// 
			this.pauseButton.Location = new System.Drawing.Point(521, 83);
			this.pauseButton.Margin = new System.Windows.Forms.Padding(2);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(50, 51);
			this.pauseButton.TabIndex = 13;
			this.pauseButton.Text = "start  stop";
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// tabController
			// 
			this.tabController.Controls.Add(this.analyserTab);
			this.tabController.Controls.Add(this.debuggerTab);
			this.tabController.Controls.Add(this.grapherTab);
			this.tabController.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabController.Location = new System.Drawing.Point(0, 24);
			this.tabController.Margin = new System.Windows.Forms.Padding(2);
			this.tabController.Multiline = true;
			this.tabController.Name = "tabController";
			this.tabController.SelectedIndex = 0;
			this.tabController.Size = new System.Drawing.Size(2052, 1017);
			this.tabController.TabIndex = 14;
			this.tabController.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// analyserTab
			// 
			this.analyserTab.BackColor = System.Drawing.Color.WhiteSmoke;
			this.analyserTab.Controls.Add(this.profileSave);
			this.analyserTab.Controls.Add(this.drivetrainLabel);
			this.analyserTab.Controls.Add(this.transmissionTypeLabel);
			this.analyserTab.Controls.Add(this.fuelTypeLabel);
			this.analyserTab.Controls.Add(this.engineSizeLabel);
			this.analyserTab.Controls.Add(this.regYearLabel);
			this.analyserTab.Controls.Add(this.modelLabel);
			this.analyserTab.Controls.Add(this.makeLabel);
			this.analyserTab.Controls.Add(this.button1);
			this.analyserTab.Controls.Add(this.drivetrainBox);
			this.analyserTab.Controls.Add(this.makeSelection);
			this.analyserTab.Controls.Add(this.modelSelection);
			this.analyserTab.Controls.Add(this.regYearSelection);
			this.analyserTab.Controls.Add(this.CANText);
			this.analyserTab.Controls.Add(this.fuelType);
			this.analyserTab.Controls.Add(this.pauseButton);
			this.analyserTab.Controls.Add(this.engineSize);
			this.analyserTab.Controls.Add(this.openButton);
			this.analyserTab.Controls.Add(this.tranmissionType);
			this.analyserTab.Controls.Add(this.focusBox);
			this.analyserTab.Controls.Add(this.closeButton);
			this.analyserTab.Controls.Add(this.focusButton);
			this.analyserTab.Controls.Add(this.portSelect);
			this.analyserTab.Controls.Add(this.clearButton);
			this.analyserTab.Controls.Add(this.baudSelect);
			this.analyserTab.Controls.Add(this.filterList);
			this.analyserTab.Controls.Add(this.filterBox);
			this.analyserTab.Controls.Add(this.filterButton);
			this.analyserTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.analyserTab.Location = new System.Drawing.Point(4, 22);
			this.analyserTab.Margin = new System.Windows.Forms.Padding(2);
			this.analyserTab.Name = "analyserTab";
			this.analyserTab.Padding = new System.Windows.Forms.Padding(2);
			this.analyserTab.Size = new System.Drawing.Size(2044, 991);
			this.analyserTab.TabIndex = 0;
			this.analyserTab.Text = "Analyser";
			this.analyserTab.Click += new System.EventHandler(this.analyserTab_Click);
			// 
			// debuggerTab
			// 
			this.debuggerTab.Location = new System.Drawing.Point(4, 22);
			this.debuggerTab.Margin = new System.Windows.Forms.Padding(2);
			this.debuggerTab.Name = "debuggerTab";
			this.debuggerTab.Padding = new System.Windows.Forms.Padding(2);
			this.debuggerTab.Size = new System.Drawing.Size(994, 616);
			this.debuggerTab.TabIndex = 1;
			this.debuggerTab.Text = "Debugger";
			this.debuggerTab.UseVisualStyleBackColor = true;
			this.debuggerTab.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// grapherTab
			// 
			this.grapherTab.Location = new System.Drawing.Point(4, 22);
			this.grapherTab.Margin = new System.Windows.Forms.Padding(2);
			this.grapherTab.Name = "grapherTab";
			this.grapherTab.Padding = new System.Windows.Forms.Padding(2);
			this.grapherTab.Size = new System.Drawing.Size(994, 616);
			this.grapherTab.TabIndex = 2;
			this.grapherTab.Text = "Grapher";
			this.grapherTab.UseVisualStyleBackColor = true;
			// 
			// makeSelection
			// 
			this.makeSelection.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.makeSelection.FormattingEnabled = true;
			this.makeSelection.Location = new System.Drawing.Point(1758, 150);
			this.makeSelection.Margin = new System.Windows.Forms.Padding(2);
			this.makeSelection.Name = "makeSelection";
			this.makeSelection.Size = new System.Drawing.Size(121, 21);
			this.makeSelection.TabIndex = 15;
			this.makeSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// modelSelection
			// 
			this.modelSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.modelSelection.FormattingEnabled = true;
			this.modelSelection.Location = new System.Drawing.Point(1758, 34);
			this.modelSelection.Margin = new System.Windows.Forms.Padding(2);
			this.modelSelection.Name = "modelSelection";
			this.modelSelection.Size = new System.Drawing.Size(121, 21);
			this.modelSelection.TabIndex = 16;
			this.modelSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
			// 
			// tranmissionType
			// 
			this.tranmissionType.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.tranmissionType.FormattingEnabled = true;
			this.tranmissionType.Location = new System.Drawing.Point(1758, 673);
			this.tranmissionType.Margin = new System.Windows.Forms.Padding(2);
			this.tranmissionType.Name = "tranmissionType";
			this.tranmissionType.Size = new System.Drawing.Size(121, 21);
			this.tranmissionType.TabIndex = 17;
			// 
			// engineSize
			// 
			this.engineSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.engineSize.FormattingEnabled = true;
			this.engineSize.Location = new System.Drawing.Point(1758, 532);
			this.engineSize.Margin = new System.Windows.Forms.Padding(2);
			this.engineSize.Name = "engineSize";
			this.engineSize.Size = new System.Drawing.Size(121, 21);
			this.engineSize.TabIndex = 18;
			// 
			// fuelType
			// 
			this.fuelType.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.fuelType.FormattingEnabled = true;
			this.fuelType.Location = new System.Drawing.Point(1758, 397);
			this.fuelType.Margin = new System.Windows.Forms.Padding(2);
			this.fuelType.Name = "fuelType";
			this.fuelType.Size = new System.Drawing.Size(121, 21);
			this.fuelType.TabIndex = 19;
			this.fuelType.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
			// 
			// regYearSelection
			// 
			this.regYearSelection.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.regYearSelection.FormattingEnabled = true;
			this.regYearSelection.Location = new System.Drawing.Point(1758, 269);
			this.regYearSelection.Margin = new System.Windows.Forms.Padding(2);
			this.regYearSelection.Name = "regYearSelection";
			this.regYearSelection.Size = new System.Drawing.Size(121, 21);
			this.regYearSelection.TabIndex = 20;
			this.regYearSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
			// 
			// drivetrainBox
			// 
			this.drivetrainBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.drivetrainBox.FormattingEnabled = true;
			this.drivetrainBox.Location = new System.Drawing.Point(1758, 804);
			this.drivetrainBox.Margin = new System.Windows.Forms.Padding(2);
			this.drivetrainBox.Name = "drivetrainBox";
			this.drivetrainBox.Size = new System.Drawing.Size(121, 21);
			this.drivetrainBox.TabIndex = 21;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(5, 914);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(443, 69);
			this.button1.TabIndex = 22;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// makeLabel
			// 
			this.makeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.makeLabel.AutoSize = true;
			this.makeLabel.Location = new System.Drawing.Point(1716, 37);
			this.makeLabel.Name = "makeLabel";
			this.makeLabel.Size = new System.Drawing.Size(37, 13);
			this.makeLabel.TabIndex = 23;
			this.makeLabel.Text = "Make:";
			// 
			// modelLabel
			// 
			this.modelLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.modelLabel.AutoSize = true;
			this.modelLabel.Location = new System.Drawing.Point(1714, 153);
			this.modelLabel.Name = "modelLabel";
			this.modelLabel.Size = new System.Drawing.Size(39, 13);
			this.modelLabel.TabIndex = 24;
			this.modelLabel.Text = "Model:";
			// 
			// regYearLabel
			// 
			this.regYearLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.regYearLabel.AutoSize = true;
			this.regYearLabel.Location = new System.Drawing.Point(1698, 272);
			this.regYearLabel.Name = "regYearLabel";
			this.regYearLabel.Size = new System.Drawing.Size(55, 13);
			this.regYearLabel.TabIndex = 25;
			this.regYearLabel.Text = "Reg Year:";
			// 
			// engineSizeLabel
			// 
			this.engineSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.engineSizeLabel.AutoSize = true;
			this.engineSizeLabel.Location = new System.Drawing.Point(1687, 400);
			this.engineSizeLabel.Name = "engineSizeLabel";
			this.engineSizeLabel.Size = new System.Drawing.Size(66, 13);
			this.engineSizeLabel.TabIndex = 26;
			this.engineSizeLabel.Text = "Engine Size:";
			// 
			// fuelTypeLabel
			// 
			this.fuelTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.fuelTypeLabel.AutoSize = true;
			this.fuelTypeLabel.Location = new System.Drawing.Point(1696, 535);
			this.fuelTypeLabel.Name = "fuelTypeLabel";
			this.fuelTypeLabel.Size = new System.Drawing.Size(57, 13);
			this.fuelTypeLabel.TabIndex = 27;
			this.fuelTypeLabel.Text = "Fuel Type:";
			// 
			// transmissionTypeLabel
			// 
			this.transmissionTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.transmissionTypeLabel.AutoSize = true;
			this.transmissionTypeLabel.Location = new System.Drawing.Point(1655, 676);
			this.transmissionTypeLabel.Name = "transmissionTypeLabel";
			this.transmissionTypeLabel.Size = new System.Drawing.Size(98, 13);
			this.transmissionTypeLabel.TabIndex = 28;
			this.transmissionTypeLabel.Text = "Transmission Type:";
			// 
			// drivetrainLabel
			// 
			this.drivetrainLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.drivetrainLabel.AutoSize = true;
			this.drivetrainLabel.Location = new System.Drawing.Point(1698, 807);
			this.drivetrainLabel.Name = "drivetrainLabel";
			this.drivetrainLabel.Size = new System.Drawing.Size(55, 13);
			this.drivetrainLabel.TabIndex = 29;
			this.drivetrainLabel.Text = "Drivetrain:";
			// 
			// profileSave
			// 
			this.profileSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.profileSave.Location = new System.Drawing.Point(1758, 937);
			this.profileSave.Name = "profileSave";
			this.profileSave.Size = new System.Drawing.Size(121, 23);
			this.profileSave.TabIndex = 30;
			this.profileSave.Text = "Save Profile";
			this.profileSave.UseVisualStyleBackColor = true;
			// 
			// CANAnalyser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1904, 1041);
			this.Controls.Add(this.tabController);
			this.Controls.Add(this.menuStrip1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.HelpButton = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "CANAnalyser";
			this.Text = "CANAnalyser";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabController.ResumeLayout(false);
			this.analyserTab.ResumeLayout(false);
			this.analyserTab.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.RichTextBox CANText;
		public System.IO.Ports.SerialPort serialPort;
		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.ComboBox portSelect;
		private System.Windows.Forms.ComboBox baudSelect;
		private System.Windows.Forms.TextBox filterBox;
		private System.Windows.Forms.Button filterButton;
		private System.Windows.Forms.TextBox filterList;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button focusButton;
		private System.Windows.Forms.TextBox focusBox;
		private System.Windows.Forms.Button pauseButton;
		private System.Windows.Forms.TabControl tabController;
		private System.Windows.Forms.TabPage analyserTab;
		private System.Windows.Forms.TabPage debuggerTab;
		private System.Windows.Forms.TabPage grapherTab;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.DirectoryServices.DirectoryEntry directoryEntry1;
		private System.Windows.Forms.ComboBox makeSelection;
		private System.Windows.Forms.ComboBox modelSelection;
		private System.Windows.Forms.ComboBox tranmissionType;
		private System.Windows.Forms.ComboBox engineSize;
		private System.Windows.Forms.ComboBox fuelType;
		private System.Windows.Forms.ComboBox regYearSelection;
		private System.Windows.Forms.ComboBox drivetrainBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label drivetrainLabel;
		private System.Windows.Forms.Label transmissionTypeLabel;
		private System.Windows.Forms.Label fuelTypeLabel;
		private System.Windows.Forms.Label engineSizeLabel;
		private System.Windows.Forms.Label regYearLabel;
		private System.Windows.Forms.Label modelLabel;
		private System.Windows.Forms.Label makeLabel;
		private System.Windows.Forms.Button profileSave;
	}
}

