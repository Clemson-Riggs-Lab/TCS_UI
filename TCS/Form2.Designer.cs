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
            this.enterResponseLabel = new System.Windows.Forms.Label();
            this.ResponseTextbox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrialNumberLabel
            // 
            this.TrialNumberLabel.AutoSize = true;
            this.TrialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TrialNumberLabel.Location = new System.Drawing.Point(12, 21);
            this.TrialNumberLabel.Name = "TrialNumberLabel";
            this.TrialNumberLabel.Size = new System.Drawing.Size(48, 17);
            this.TrialNumberLabel.TabIndex = 0;
            this.TrialNumberLabel.Text = "Trial #";
            // 
            // InstructionsTextbox
            // 
            this.InstructionsTextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InstructionsTextbox.Location = new System.Drawing.Point(81, 21);
            this.InstructionsTextbox.Multiline = true;
            this.InstructionsTextbox.Name = "InstructionsTextbox";
            this.InstructionsTextbox.ReadOnly = true;
            this.InstructionsTextbox.Size = new System.Drawing.Size(304, 71);
            this.InstructionsTextbox.TabIndex = 1;
            this.InstructionsTextbox.Text = "Instructions here";
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.Location = new System.Drawing.Point(81, 130);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(58, 60);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // enterResponseLabel
            // 
            this.enterResponseLabel.AutoSize = true;
            this.enterResponseLabel.Location = new System.Drawing.Point(208, 141);
            this.enterResponseLabel.Name = "enterResponseLabel";
            this.enterResponseLabel.Size = new System.Drawing.Size(138, 13);
            this.enterResponseLabel.TabIndex = 3;
            this.enterResponseLabel.Text = "Please enter your response:";
            // 
            // ResponseTextbox
            // 
            this.ResponseTextbox.Location = new System.Drawing.Point(224, 161);
            this.ResponseTextbox.Name = "ResponseTextbox";
            this.ResponseTextbox.Size = new System.Drawing.Size(100, 20);
            this.ResponseTextbox.TabIndex = 4;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(277, 248);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(108, 40);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Go To Next Trial";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 311);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ResponseTextbox);
            this.Controls.Add(this.enterResponseLabel);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.InstructionsTextbox);
            this.Controls.Add(this.TrialNumberLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TrialNumberLabel;
        private System.Windows.Forms.TextBox InstructionsTextbox;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label enterResponseLabel;
        private System.Windows.Forms.TextBox ResponseTextbox;
        private System.Windows.Forms.Button NextButton;

        }
    }