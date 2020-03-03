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
            this.FinishedLabel1 = new System.Windows.Forms.Label();
            this.FinishedLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinishedLabel1
            // 
            this.FinishedLabel1.AutoSize = true;
            this.FinishedLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FinishedLabel1.ForeColor = System.Drawing.Color.Black;
            this.FinishedLabel1.Location = new System.Drawing.Point(125, 125);
            this.FinishedLabel1.Name = "FinishedLabel1";
            this.FinishedLabel1.Size = new System.Drawing.Size(155, 25);
            this.FinishedLabel1.TabIndex = 0;
            this.FinishedLabel1.Text = "Trials Complete!";
            // 
            // FinishedLabel2
            // 
            this.FinishedLabel2.AutoSize = true;
            this.FinishedLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FinishedLabel2.ForeColor = System.Drawing.Color.Black;
            this.FinishedLabel2.Location = new System.Drawing.Point(70, 170);
            this.FinishedLabel2.Name = "FinishedLabel2";
            this.FinishedLabel2.Size = new System.Drawing.Size(275, 25);
            this.FinishedLabel2.TabIndex = 1;
            this.FinishedLabel2.Text = "You may now exit this window.";
            // 
            // FormFinished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 336);
            this.Controls.Add(this.FinishedLabel2);
            this.Controls.Add(this.FinishedLabel1);
            this.Name = "FormFinished";
            this.Text = "FormFinished";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCS_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FinishedLabel1;
        private System.Windows.Forms.Label FinishedLabel2;

        }
    }