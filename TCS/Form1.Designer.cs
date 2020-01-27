namespace TCS
{
    partial class TCSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCSForm));
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.DiscoverButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.BrowseFileButton = new System.Windows.Forms.Button();
            this.NextCueButton = new System.Windows.Forms.Button();
            this.ConsoleOutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectCueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playCueButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EndChangeAfterPulseNumberLabel = new System.Windows.Forms.Label();
            this.endChangeAfterPulseNumberDataLabel = new System.Windows.Forms.Label();
            this.startChangeAfterPulseNumberLabel = new System.Windows.Forms.Label();
            this.startChangeAfterPulseNumberDataLabel = new System.Windows.Forms.Label();
            this.endingPulseDurationLabel = new System.Windows.Forms.Label();
            this.endingPulseDurationDataLabel = new System.Windows.Forms.Label();
            this.startingPulseDurationLabel = new System.Windows.Forms.Label();
            this.startingPulseDurationDataLabel = new System.Windows.Forms.Label();
            this.endingISILabel = new System.Windows.Forms.Label();
            this.endingISIDataLabel = new System.Windows.Forms.Label();
            this.startingISILabel = new System.Windows.Forms.Label();
            this.startingISIDataLabel = new System.Windows.Forms.Label();
            this.endTactorLocationLabel = new System.Windows.Forms.Label();
            this.endTactorLocationDataLabel = new System.Windows.Forms.Label();
            this.startTactorLocationDataLabel = new System.Windows.Forms.Label();
            this.startTactorLocationLabel = new System.Windows.Forms.Label();
            this.endingFrequencyLabel = new System.Windows.Forms.Label();
            this.endingFrequencyDataLabel = new System.Windows.Forms.Label();
            this.endingGainLabel = new System.Windows.Forms.Label();
            this.endingGainDataLabel = new System.Windows.Forms.Label();
            this.startingFrequencyLabel = new System.Windows.Forms.Label();
            this.startingFrequencyDataLabel = new System.Windows.Forms.Label();
            this.startingGainLabel = new System.Windows.Forms.Label();
            this.startingGainDataLabel = new System.Windows.Forms.Label();
            this.TypeofchangeLabel = new System.Windows.Forms.Label();
            this.typeOfChangeDataLabel = new System.Windows.Forms.Label();
            this.cueNumberForInputLabel = new System.Windows.Forms.Label();
            this.cueNumberForInputDataLabel = new System.Windows.Forms.Label();
            this.newscreenNumberLabel = new System.Windows.Forms.Label();
            this.newScreenNumberDataLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeltaTimeLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectCueNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Location = new System.Drawing.Point(68, 13);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(204, 21);
            this.ComPortComboBox.TabIndex = 0;
            // 
            // ComPortLabel
            // 
            this.ComPortLabel.AutoSize = true;
            this.ComPortLabel.Location = new System.Drawing.Point(12, 16);
            this.ComPortLabel.Name = "ComPortLabel";
            this.ComPortLabel.Size = new System.Drawing.Size(50, 13);
            this.ComPortLabel.TabIndex = 1;
            this.ComPortLabel.Text = "Com Port";
            // 
            // DiscoverButton
            // 
            this.DiscoverButton.Location = new System.Drawing.Point(15, 40);
            this.DiscoverButton.Name = "DiscoverButton";
            this.DiscoverButton.Size = new System.Drawing.Size(257, 44);
            this.DiscoverButton.TabIndex = 2;
            this.DiscoverButton.Text = "Discover";
            this.DiscoverButton.UseVisualStyleBackColor = true;
            this.DiscoverButton.Click += new System.EventHandler(this.DiscoverButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Enabled = false;
            this.ConnectButton.Location = new System.Drawing.Point(15, 90);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(257, 44);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // BrowseFileButton
            // 
            this.BrowseFileButton.Enabled = false;
            this.BrowseFileButton.Location = new System.Drawing.Point(17, 140);
            this.BrowseFileButton.Name = "BrowseFileButton";
            this.BrowseFileButton.Size = new System.Drawing.Size(257, 44);
            this.BrowseFileButton.TabIndex = 4;
            this.BrowseFileButton.Text = "Browse File";
            this.BrowseFileButton.UseVisualStyleBackColor = true;
            this.BrowseFileButton.Click += new System.EventHandler(this.BrowseFileButton_Click);
            // 
            // NextCueButton
            // 
            this.NextCueButton.Enabled = false;
            this.NextCueButton.Location = new System.Drawing.Point(15, 190);
            this.NextCueButton.Name = "NextCueButton";
            this.NextCueButton.Size = new System.Drawing.Size(257, 44);
            this.NextCueButton.TabIndex = 5;
            this.NextCueButton.Text = "Next Cue";
            this.NextCueButton.UseVisualStyleBackColor = true;
            this.NextCueButton.Click += new System.EventHandler(this.NextCueButton_Click);
            // 
            // ConsoleOutputRichTextBox
            // 
            this.ConsoleOutputRichTextBox.Location = new System.Drawing.Point(15, 240);
            this.ConsoleOutputRichTextBox.Name = "ConsoleOutputRichTextBox";
            this.ConsoleOutputRichTextBox.ReadOnly = true;
            this.ConsoleOutputRichTextBox.Size = new System.Drawing.Size(259, 239);
            this.ConsoleOutputRichTextBox.TabIndex = 7;
            this.ConsoleOutputRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Go to Cue #:";
            // 
            // selectCueNumericUpDown
            // 
            this.selectCueNumericUpDown.Location = new System.Drawing.Point(377, 462);
            this.selectCueNumericUpDown.Name = "selectCueNumericUpDown";
            this.selectCueNumericUpDown.Size = new System.Drawing.Size(32, 20);
            this.selectCueNumericUpDown.TabIndex = 10;
            this.selectCueNumericUpDown.ValueChanged += new System.EventHandler(this.selectCueNumericUpDown_ValueChanged);
            // 
            // playCueButton
            // 
            this.playCueButton.Location = new System.Drawing.Point(415, 462);
            this.playCueButton.Name = "playCueButton";
            this.playCueButton.Size = new System.Drawing.Size(75, 20);
            this.playCueButton.TabIndex = 11;
            this.playCueButton.Text = "Play Cue";
            this.playCueButton.UseVisualStyleBackColor = true;
            this.playCueButton.Click += new System.EventHandler(this.playCueButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.1626F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.8374F));
            this.tableLayoutPanel1.Controls.Add(this.EndChangeAfterPulseNumberLabel, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.endChangeAfterPulseNumberDataLabel, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.startChangeAfterPulseNumberLabel, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.startChangeAfterPulseNumberDataLabel, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.endingPulseDurationLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.endingPulseDurationDataLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.startingPulseDurationLabel, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.startingPulseDurationDataLabel, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.endingISILabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.endingISIDataLabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.startingISILabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.startingISIDataLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.endTactorLocationLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.endTactorLocationDataLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.startTactorLocationDataLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.startTactorLocationLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.endingFrequencyLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.endingFrequencyDataLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.endingGainLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.endingGainDataLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.startingFrequencyLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.startingFrequencyDataLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.startingGainLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.startingGainDataLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TypeofchangeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.typeOfChangeDataLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cueNumberForInputLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cueNumberForInputDataLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.newscreenNumberLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newScreenNumberDataLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(306, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 397);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // EndChangeAfterPulseNumberLabel
            // 
            this.EndChangeAfterPulseNumberLabel.AutoSize = true;
            this.EndChangeAfterPulseNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EndChangeAfterPulseNumberLabel.Location = new System.Drawing.Point(4, 365);
            this.EndChangeAfterPulseNumberLabel.Name = "EndChangeAfterPulseNumberLabel";
            this.EndChangeAfterPulseNumberLabel.Size = new System.Drawing.Size(133, 31);
            this.EndChangeAfterPulseNumberLabel.TabIndex = 35;
            this.EndChangeAfterPulseNumberLabel.Text = "End Change After Label #:";
            this.EndChangeAfterPulseNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endChangeAfterPulseNumberDataLabel
            // 
            this.endChangeAfterPulseNumberDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endChangeAfterPulseNumberDataLabel.AutoSize = true;
            this.endChangeAfterPulseNumberDataLabel.Location = new System.Drawing.Point(191, 374);
            this.endChangeAfterPulseNumberDataLabel.Name = "endChangeAfterPulseNumberDataLabel";
            this.endChangeAfterPulseNumberDataLabel.Size = new System.Drawing.Size(10, 13);
            this.endChangeAfterPulseNumberDataLabel.TabIndex = 34;
            this.endChangeAfterPulseNumberDataLabel.Text = " ";
            this.endChangeAfterPulseNumberDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startChangeAfterPulseNumberLabel
            // 
            this.startChangeAfterPulseNumberLabel.AutoSize = true;
            this.startChangeAfterPulseNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startChangeAfterPulseNumberLabel.Location = new System.Drawing.Point(4, 339);
            this.startChangeAfterPulseNumberLabel.Name = "startChangeAfterPulseNumberLabel";
            this.startChangeAfterPulseNumberLabel.Size = new System.Drawing.Size(136, 25);
            this.startChangeAfterPulseNumberLabel.TabIndex = 33;
            this.startChangeAfterPulseNumberLabel.Text = "Start Change After Pulse #:";
            this.startChangeAfterPulseNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startChangeAfterPulseNumberDataLabel
            // 
            this.startChangeAfterPulseNumberDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startChangeAfterPulseNumberDataLabel.AutoSize = true;
            this.startChangeAfterPulseNumberDataLabel.Location = new System.Drawing.Point(191, 345);
            this.startChangeAfterPulseNumberDataLabel.Name = "startChangeAfterPulseNumberDataLabel";
            this.startChangeAfterPulseNumberDataLabel.Size = new System.Drawing.Size(10, 13);
            this.startChangeAfterPulseNumberDataLabel.TabIndex = 32;
            this.startChangeAfterPulseNumberDataLabel.Text = " ";
            this.startChangeAfterPulseNumberDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingPulseDurationLabel
            // 
            this.endingPulseDurationLabel.AutoSize = true;
            this.endingPulseDurationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.endingPulseDurationLabel.Location = new System.Drawing.Point(4, 313);
            this.endingPulseDurationLabel.Name = "endingPulseDurationLabel";
            this.endingPulseDurationLabel.Size = new System.Drawing.Size(115, 25);
            this.endingPulseDurationLabel.TabIndex = 31;
            this.endingPulseDurationLabel.Text = "Ending Pulse Duration:";
            this.endingPulseDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingPulseDurationDataLabel
            // 
            this.endingPulseDurationDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endingPulseDurationDataLabel.AutoSize = true;
            this.endingPulseDurationDataLabel.Location = new System.Drawing.Point(191, 319);
            this.endingPulseDurationDataLabel.Name = "endingPulseDurationDataLabel";
            this.endingPulseDurationDataLabel.Size = new System.Drawing.Size(10, 13);
            this.endingPulseDurationDataLabel.TabIndex = 30;
            this.endingPulseDurationDataLabel.Text = " ";
            this.endingPulseDurationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPulseDurationLabel
            // 
            this.startingPulseDurationLabel.AutoSize = true;
            this.startingPulseDurationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startingPulseDurationLabel.Location = new System.Drawing.Point(4, 287);
            this.startingPulseDurationLabel.Name = "startingPulseDurationLabel";
            this.startingPulseDurationLabel.Size = new System.Drawing.Size(118, 25);
            this.startingPulseDurationLabel.TabIndex = 29;
            this.startingPulseDurationLabel.Text = "Starting Pulse Duration:";
            this.startingPulseDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPulseDurationDataLabel
            // 
            this.startingPulseDurationDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startingPulseDurationDataLabel.AutoSize = true;
            this.startingPulseDurationDataLabel.Location = new System.Drawing.Point(191, 293);
            this.startingPulseDurationDataLabel.Name = "startingPulseDurationDataLabel";
            this.startingPulseDurationDataLabel.Size = new System.Drawing.Size(10, 13);
            this.startingPulseDurationDataLabel.TabIndex = 28;
            this.startingPulseDurationDataLabel.Text = " ";
            this.startingPulseDurationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingISILabel
            // 
            this.endingISILabel.AutoSize = true;
            this.endingISILabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.endingISILabel.Location = new System.Drawing.Point(4, 261);
            this.endingISILabel.Name = "endingISILabel";
            this.endingISILabel.Size = new System.Drawing.Size(59, 25);
            this.endingISILabel.TabIndex = 27;
            this.endingISILabel.Text = "Ending ISI:";
            this.endingISILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingISIDataLabel
            // 
            this.endingISIDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endingISIDataLabel.AutoSize = true;
            this.endingISIDataLabel.Location = new System.Drawing.Point(191, 267);
            this.endingISIDataLabel.Name = "endingISIDataLabel";
            this.endingISIDataLabel.Size = new System.Drawing.Size(10, 13);
            this.endingISIDataLabel.TabIndex = 26;
            this.endingISIDataLabel.Text = " ";
            this.endingISIDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingISILabel
            // 
            this.startingISILabel.AutoSize = true;
            this.startingISILabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startingISILabel.Location = new System.Drawing.Point(4, 235);
            this.startingISILabel.Name = "startingISILabel";
            this.startingISILabel.Size = new System.Drawing.Size(62, 25);
            this.startingISILabel.TabIndex = 25;
            this.startingISILabel.Text = "Starting ISI:";
            this.startingISILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingISIDataLabel
            // 
            this.startingISIDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startingISIDataLabel.AutoSize = true;
            this.startingISIDataLabel.Location = new System.Drawing.Point(191, 241);
            this.startingISIDataLabel.Name = "startingISIDataLabel";
            this.startingISIDataLabel.Size = new System.Drawing.Size(10, 13);
            this.startingISIDataLabel.TabIndex = 24;
            this.startingISIDataLabel.Text = " ";
            this.startingISIDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endTactorLocationLabel
            // 
            this.endTactorLocationLabel.AutoSize = true;
            this.endTactorLocationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.endTactorLocationLabel.Location = new System.Drawing.Point(4, 209);
            this.endTactorLocationLabel.Name = "endTactorLocationLabel";
            this.endTactorLocationLabel.Size = new System.Drawing.Size(107, 25);
            this.endTactorLocationLabel.TabIndex = 23;
            this.endTactorLocationLabel.Text = "End Tactor Location:";
            this.endTactorLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endTactorLocationDataLabel
            // 
            this.endTactorLocationDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endTactorLocationDataLabel.AutoSize = true;
            this.endTactorLocationDataLabel.Location = new System.Drawing.Point(191, 215);
            this.endTactorLocationDataLabel.Name = "endTactorLocationDataLabel";
            this.endTactorLocationDataLabel.Size = new System.Drawing.Size(10, 13);
            this.endTactorLocationDataLabel.TabIndex = 22;
            this.endTactorLocationDataLabel.Text = " ";
            this.endTactorLocationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTactorLocationDataLabel
            // 
            this.startTactorLocationDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTactorLocationDataLabel.AutoSize = true;
            this.startTactorLocationDataLabel.Location = new System.Drawing.Point(191, 189);
            this.startTactorLocationDataLabel.Name = "startTactorLocationDataLabel";
            this.startTactorLocationDataLabel.Size = new System.Drawing.Size(10, 13);
            this.startTactorLocationDataLabel.TabIndex = 21;
            this.startTactorLocationDataLabel.Text = " ";
            this.startTactorLocationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTactorLocationLabel
            // 
            this.startTactorLocationLabel.AutoSize = true;
            this.startTactorLocationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startTactorLocationLabel.Location = new System.Drawing.Point(4, 183);
            this.startTactorLocationLabel.Name = "startTactorLocationLabel";
            this.startTactorLocationLabel.Size = new System.Drawing.Size(110, 25);
            this.startTactorLocationLabel.TabIndex = 20;
            this.startTactorLocationLabel.Text = "Start Tactor Location:";
            this.startTactorLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingFrequencyLabel
            // 
            this.endingFrequencyLabel.AutoSize = true;
            this.endingFrequencyLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.endingFrequencyLabel.Location = new System.Drawing.Point(4, 157);
            this.endingFrequencyLabel.Name = "endingFrequencyLabel";
            this.endingFrequencyLabel.Size = new System.Drawing.Size(96, 25);
            this.endingFrequencyLabel.TabIndex = 19;
            this.endingFrequencyLabel.Text = "Ending Frequency:";
            this.endingFrequencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingFrequencyDataLabel
            // 
            this.endingFrequencyDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endingFrequencyDataLabel.AutoSize = true;
            this.endingFrequencyDataLabel.Location = new System.Drawing.Point(191, 163);
            this.endingFrequencyDataLabel.Name = "endingFrequencyDataLabel";
            this.endingFrequencyDataLabel.Size = new System.Drawing.Size(10, 13);
            this.endingFrequencyDataLabel.TabIndex = 18;
            this.endingFrequencyDataLabel.Text = " ";
            this.endingFrequencyDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingGainLabel
            // 
            this.endingGainLabel.AutoSize = true;
            this.endingGainLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.endingGainLabel.Location = new System.Drawing.Point(4, 131);
            this.endingGainLabel.Name = "endingGainLabel";
            this.endingGainLabel.Size = new System.Drawing.Size(68, 25);
            this.endingGainLabel.TabIndex = 17;
            this.endingGainLabel.Text = "Ending Gain:";
            this.endingGainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingGainDataLabel
            // 
            this.endingGainDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endingGainDataLabel.AutoSize = true;
            this.endingGainDataLabel.Location = new System.Drawing.Point(191, 137);
            this.endingGainDataLabel.Name = "endingGainDataLabel";
            this.endingGainDataLabel.Size = new System.Drawing.Size(10, 13);
            this.endingGainDataLabel.TabIndex = 16;
            this.endingGainDataLabel.Text = " ";
            this.endingGainDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingFrequencyLabel
            // 
            this.startingFrequencyLabel.AutoSize = true;
            this.startingFrequencyLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startingFrequencyLabel.Location = new System.Drawing.Point(4, 105);
            this.startingFrequencyLabel.Name = "startingFrequencyLabel";
            this.startingFrequencyLabel.Size = new System.Drawing.Size(99, 25);
            this.startingFrequencyLabel.TabIndex = 15;
            this.startingFrequencyLabel.Text = "Starting Frequency:";
            this.startingFrequencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingFrequencyDataLabel
            // 
            this.startingFrequencyDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startingFrequencyDataLabel.AutoSize = true;
            this.startingFrequencyDataLabel.Location = new System.Drawing.Point(191, 111);
            this.startingFrequencyDataLabel.Name = "startingFrequencyDataLabel";
            this.startingFrequencyDataLabel.Size = new System.Drawing.Size(10, 13);
            this.startingFrequencyDataLabel.TabIndex = 14;
            this.startingFrequencyDataLabel.Text = " ";
            this.startingFrequencyDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingGainLabel
            // 
            this.startingGainLabel.AutoSize = true;
            this.startingGainLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startingGainLabel.Location = new System.Drawing.Point(4, 79);
            this.startingGainLabel.Name = "startingGainLabel";
            this.startingGainLabel.Size = new System.Drawing.Size(71, 25);
            this.startingGainLabel.TabIndex = 13;
            this.startingGainLabel.Text = "Starting Gain:";
            this.startingGainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingGainDataLabel
            // 
            this.startingGainDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startingGainDataLabel.AutoSize = true;
            this.startingGainDataLabel.Location = new System.Drawing.Point(191, 85);
            this.startingGainDataLabel.Name = "startingGainDataLabel";
            this.startingGainDataLabel.Size = new System.Drawing.Size(10, 13);
            this.startingGainDataLabel.TabIndex = 12;
            this.startingGainDataLabel.Text = " ";
            this.startingGainDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeofchangeLabel
            // 
            this.TypeofchangeLabel.AutoSize = true;
            this.TypeofchangeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TypeofchangeLabel.Location = new System.Drawing.Point(4, 53);
            this.TypeofchangeLabel.Name = "TypeofchangeLabel";
            this.TypeofchangeLabel.Size = new System.Drawing.Size(88, 25);
            this.TypeofchangeLabel.TabIndex = 11;
            this.TypeofchangeLabel.Text = "Type Of Change:";
            this.TypeofchangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeOfChangeDataLabel
            // 
            this.typeOfChangeDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeOfChangeDataLabel.AutoSize = true;
            this.typeOfChangeDataLabel.Location = new System.Drawing.Point(191, 59);
            this.typeOfChangeDataLabel.Name = "typeOfChangeDataLabel";
            this.typeOfChangeDataLabel.Size = new System.Drawing.Size(10, 13);
            this.typeOfChangeDataLabel.TabIndex = 10;
            this.typeOfChangeDataLabel.Text = " ";
            this.typeOfChangeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cueNumberForInputLabel
            // 
            this.cueNumberForInputLabel.AutoSize = true;
            this.cueNumberForInputLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cueNumberForInputLabel.Location = new System.Drawing.Point(4, 27);
            this.cueNumberForInputLabel.Name = "cueNumberForInputLabel";
            this.cueNumberForInputLabel.Size = new System.Drawing.Size(111, 25);
            this.cueNumberForInputLabel.TabIndex = 9;
            this.cueNumberForInputLabel.Text = "Cue Number for Input:";
            this.cueNumberForInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cueNumberForInputDataLabel
            // 
            this.cueNumberForInputDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cueNumberForInputDataLabel.AutoSize = true;
            this.cueNumberForInputDataLabel.Location = new System.Drawing.Point(191, 33);
            this.cueNumberForInputDataLabel.Name = "cueNumberForInputDataLabel";
            this.cueNumberForInputDataLabel.Size = new System.Drawing.Size(10, 13);
            this.cueNumberForInputDataLabel.TabIndex = 8;
            this.cueNumberForInputDataLabel.Text = " ";
            this.cueNumberForInputDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newscreenNumberLabel
            // 
            this.newscreenNumberLabel.AutoSize = true;
            this.newscreenNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.newscreenNumberLabel.Location = new System.Drawing.Point(4, 1);
            this.newscreenNumberLabel.Name = "newscreenNumberLabel";
            this.newscreenNumberLabel.Size = new System.Drawing.Size(115, 25);
            this.newscreenNumberLabel.TabIndex = 7;
            this.newscreenNumberLabel.Text = "Cue # (New screen#) :";
            this.newscreenNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newScreenNumberDataLabel
            // 
            this.newScreenNumberDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newScreenNumberDataLabel.AutoSize = true;
            this.newScreenNumberDataLabel.Location = new System.Drawing.Point(196, 7);
            this.newScreenNumberDataLabel.Name = "newScreenNumberDataLabel";
            this.newScreenNumberDataLabel.Size = new System.Drawing.Size(0, 13);
            this.newScreenNumberDataLabel.TabIndex = 6;
            this.newScreenNumberDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Next Cue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Will be presented in:";
            // 
            // DeltaTimeLable
            // 
            this.DeltaTimeLable.AutoSize = true;
            this.DeltaTimeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeltaTimeLable.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeltaTimeLable.Location = new System.Drawing.Point(466, 32);
            this.DeltaTimeLable.Name = "DeltaTimeLable";
            this.DeltaTimeLable.Size = new System.Drawing.Size(71, 20);
            this.DeltaTimeLable.TabIndex = 15;
            this.DeltaTimeLable.Text = "00:00:00";
            // 
            // TCSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 486);
            this.Controls.Add(this.DeltaTimeLable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.playCueButton);
            this.Controls.Add(this.selectCueNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsoleOutputRichTextBox);
            this.Controls.Add(this.NextCueButton);
            this.Controls.Add(this.BrowseFileButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.DiscoverButton);
            this.Controls.Add(this.ComPortLabel);
            this.Controls.Add(this.ComPortComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TCSForm";
            this.Text = "Tactile Cues Sim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCS_FormClosed);
            this.Load += new System.EventHandler(this.TCSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectCueNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.Label ComPortLabel;
        private System.Windows.Forms.Button DiscoverButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button BrowseFileButton;
        private System.Windows.Forms.Button NextCueButton;
        private System.Windows.Forms.RichTextBox ConsoleOutputRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown selectCueNumericUpDown;
        private System.Windows.Forms.Button playCueButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label EndChangeAfterPulseNumberLabel;
        private System.Windows.Forms.Label endChangeAfterPulseNumberDataLabel;
        private System.Windows.Forms.Label startChangeAfterPulseNumberLabel;
        private System.Windows.Forms.Label startChangeAfterPulseNumberDataLabel;
        private System.Windows.Forms.Label endingPulseDurationLabel;
        private System.Windows.Forms.Label endingPulseDurationDataLabel;
        private System.Windows.Forms.Label startingPulseDurationLabel;
        private System.Windows.Forms.Label startingPulseDurationDataLabel;
        private System.Windows.Forms.Label endingISILabel;
        private System.Windows.Forms.Label endingISIDataLabel;
        private System.Windows.Forms.Label startingISILabel;
        private System.Windows.Forms.Label startingISIDataLabel;
        private System.Windows.Forms.Label endTactorLocationLabel;
        private System.Windows.Forms.Label endTactorLocationDataLabel;
        private System.Windows.Forms.Label startTactorLocationDataLabel;
        private System.Windows.Forms.Label startTactorLocationLabel;
        private System.Windows.Forms.Label endingFrequencyLabel;
        private System.Windows.Forms.Label endingFrequencyDataLabel;
        private System.Windows.Forms.Label endingGainLabel;
        private System.Windows.Forms.Label endingGainDataLabel;
        private System.Windows.Forms.Label startingFrequencyLabel;
        private System.Windows.Forms.Label startingFrequencyDataLabel;
        private System.Windows.Forms.Label startingGainLabel;
        private System.Windows.Forms.Label startingGainDataLabel;
        private System.Windows.Forms.Label TypeofchangeLabel;
        private System.Windows.Forms.Label typeOfChangeDataLabel;
        private System.Windows.Forms.Label cueNumberForInputLabel;
        private System.Windows.Forms.Label cueNumberForInputDataLabel;
        private System.Windows.Forms.Label newscreenNumberLabel;
        private System.Windows.Forms.Label newScreenNumberDataLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DeltaTimeLable;
    }
}

