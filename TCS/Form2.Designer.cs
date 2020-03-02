namespace TCS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TrialNumberLabel = new System.Windows.Forms.Label();
            this.InstructionsTextbox = new System.Windows.Forms.TextBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.EnterResponseLabel = new System.Windows.Forms.Label();
            this.ResponseTextbox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.Trial1Score = new System.Windows.Forms.Label();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.WarningsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrialNumberLabel
            // 
            this.TrialNumberLabel.AutoSize = true;
            this.TrialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TrialNumberLabel.Location = new System.Drawing.Point(175, 140);
            this.TrialNumberLabel.Name = "TrialNumberLabel";
            this.TrialNumberLabel.Size = new System.Drawing.Size(64, 17);
            this.TrialNumberLabel.TabIndex = 0;
            this.TrialNumberLabel.Text = "Trial #: 1";
            // 
            // InstructionsTextbox
            // 
            this.InstructionsTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InstructionsTextbox.CausesValidation = false;
            this.InstructionsTextbox.Location = new System.Drawing.Point(24, 48);
            this.InstructionsTextbox.Multiline = true;
            this.InstructionsTextbox.Name = "InstructionsTextbox";
            this.InstructionsTextbox.ReadOnly = true;
            this.InstructionsTextbox.Size = new System.Drawing.Size(361, 64);
            this.InstructionsTextbox.TabIndex = 1;
            this.InstructionsTextbox.Text = resources.GetString("InstructionsTextbox.Text");
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.Location = new System.Drawing.Point(45, 202);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(58, 60);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // EnterResponseLabel
            // 
            this.EnterResponseLabel.AutoSize = true;
            this.EnterResponseLabel.Location = new System.Drawing.Point(222, 202);
            this.EnterResponseLabel.Name = "EnterResponseLabel";
            this.EnterResponseLabel.Size = new System.Drawing.Size(138, 13);
            this.EnterResponseLabel.TabIndex = 3;
            this.EnterResponseLabel.Text = "Please enter your response:";
            // 
            // ResponseTextbox
            // 
            this.ResponseTextbox.Location = new System.Drawing.Point(239, 218);
            this.ResponseTextbox.Name = "ResponseTextbox";
            this.ResponseTextbox.Size = new System.Drawing.Size(100, 20);
            this.ResponseTextbox.TabIndex = 4;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(277, 273);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(108, 40);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Go To Next Trial";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Trial1Score
            // 
            this.Trial1Score.AutoSize = true;
            this.Trial1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Trial1Score.Location = new System.Drawing.Point(21, 175);
            this.Trial1Score.Name = "Trial1Score";
            this.Trial1Score.Size = new System.Drawing.Size(96, 15);
            this.Trial1Score.TabIndex = 6;
            this.Trial1Score.Text = "Trial 1 Score: __";
            this.Trial1Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InstructionsLabel.Location = new System.Drawing.Point(163, 18);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(80, 17);
            this.InstructionsLabel.TabIndex = 7;
            this.InstructionsLabel.Text = "Instructions";
            // 
            // WarningsLabel
            // 
            this.WarningsLabel.AutoSize = true;
            this.WarningsLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningsLabel.Location = new System.Drawing.Point(222, 249);
            this.WarningsLabel.Name = "WarningsLabel";
            this.WarningsLabel.Size = new System.Drawing.Size(0, 13);
            this.WarningsLabel.TabIndex = 8;
            this.WarningsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 336);
            this.Controls.Add(this.WarningsLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.Trial1Score);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ResponseTextbox);
            this.Controls.Add(this.EnterResponseLabel);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.InstructionsTextbox);
            this.Controls.Add(this.TrialNumberLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TrialNumberLabel;
        private System.Windows.Forms.TextBox InstructionsTextbox;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label EnterResponseLabel;
        private System.Windows.Forms.TextBox ResponseTextbox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label Trial1Score;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label WarningsLabel;
    }
    }