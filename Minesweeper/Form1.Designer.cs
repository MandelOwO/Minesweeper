
namespace Minesweeper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameField = new System.Windows.Forms.PictureBox();
            this.BtnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameField)).BeginInit();
            this.SuspendLayout();
            // 
            // GameField
            // 
            this.GameField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameField.Location = new System.Drawing.Point(12, 50);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(562, 362);
            this.GameField.TabIndex = 1;
            this.GameField.TabStop = false;
            this.GameField.Paint += new System.Windows.Forms.PaintEventHandler(this.GameField_Paint);
            // 
            // BtnRestart
            // 
            this.BtnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRestart.Image = global::Minesweeper.Properties.Resources.Smile_30x30;
            this.BtnRestart.Location = new System.Drawing.Point(248, 12);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(30, 30);
            this.BtnRestart.TabIndex = 3;
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 442);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.GameField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameField;
        private System.Windows.Forms.Button BtnRestart;
    }
}

