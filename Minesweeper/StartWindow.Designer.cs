namespace Minesweeper
{
    partial class StartWindow
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
            this.RbtnEasy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RbtnMedium = new System.Windows.Forms.RadioButton();
            this.RbtnHard = new System.Windows.Forms.RadioButton();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RbtnEasy
            // 
            this.RbtnEasy.AutoSize = true;
            this.RbtnEasy.Location = new System.Drawing.Point(24, 40);
            this.RbtnEasy.Name = "RbtnEasy";
            this.RbtnEasy.Size = new System.Drawing.Size(48, 19);
            this.RbtnEasy.TabIndex = 1;
            this.RbtnEasy.Text = "Easy";
            this.RbtnEasy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose difficulty:";
            // 
            // RbtnMedium
            // 
            this.RbtnMedium.AutoSize = true;
            this.RbtnMedium.Checked = true;
            this.RbtnMedium.Location = new System.Drawing.Point(24, 65);
            this.RbtnMedium.Name = "RbtnMedium";
            this.RbtnMedium.Size = new System.Drawing.Size(70, 19);
            this.RbtnMedium.TabIndex = 1;
            this.RbtnMedium.TabStop = true;
            this.RbtnMedium.Text = "Medium";
            this.RbtnMedium.UseVisualStyleBackColor = true;
            // 
            // RbtnHard
            // 
            this.RbtnHard.AutoSize = true;
            this.RbtnHard.Location = new System.Drawing.Point(24, 90);
            this.RbtnHard.Name = "RbtnHard";
            this.RbtnHard.Size = new System.Drawing.Size(51, 19);
            this.RbtnHard.TabIndex = 1;
            this.RbtnHard.Text = "Hard";
            this.RbtnHard.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(106, 120);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Start game";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(12, 120);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Quit";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 155);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbtnHard);
            this.Controls.Add(this.RbtnMedium);
            this.Controls.Add(this.RbtnEasy);
            this.Name = "StartWindow";
            this.Text = "StartWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbtnEasy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbtnMedium;
        private System.Windows.Forms.RadioButton RbtnHard;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnClose;
    }
}