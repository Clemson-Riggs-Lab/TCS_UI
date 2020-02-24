namespace TCS
{
    partial class FormFinished
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
            this.FinishedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinishedLabel
            // 
            this.FinishedLabel.AutoSize = true;
            this.FinishedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FinishedLabel.ForeColor = System.Drawing.Color.Black;
            this.FinishedLabel.Location = new System.Drawing.Point(193, 136);
            this.FinishedLabel.Name = "FinishedLabel";
            this.FinishedLabel.Size = new System.Drawing.Size(25, 25);
            this.FinishedLabel.TabIndex = 0;
            this.FinishedLabel.Text = "Y";
            // 
            // FormFinished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 311);
            this.Controls.Add(this.FinishedLabel);
            this.Name = "FormFinished";
            this.Text = "FormFinished";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCS_FormClosed);
            this.Load += new System.EventHandler(this.FormFinished_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FinishedLabel;
    }
}