
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GameField = new System.Windows.Forms.PictureBox();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.LabMines = new System.Windows.Forms.Label();
            this.LabTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GameField)).BeginInit();
            this.SuspendLayout();
            // 
            // GameField
            // 
            this.GameField.Location = new System.Drawing.Point(12, 58);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(562, 362);
            this.GameField.TabIndex = 1;
            this.GameField.TabStop = false;
            this.GameField.Paint += new System.Windows.Forms.PaintEventHandler(this.GameField_Paint);
            this.GameField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameField_MouseClick_1);
            // 
            // BtnRestart
            // 
            this.BtnRestart.BackColor = System.Drawing.Color.Silver;
            this.BtnRestart.BackgroundImage = global::Minesweeper.Properties.Resources.Smile_30x30;
            this.BtnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnRestart.FlatAppearance.BorderSize = 0;
            this.BtnRestart.Location = new System.Drawing.Point(260, 12);
            this.BtnRestart.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(40, 40);
            this.BtnRestart.TabIndex = 3;
            this.BtnRestart.UseVisualStyleBackColor = false;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click_1);
            // 
            // LabMines
            // 
            this.LabMines.AutoSize = true;
            this.LabMines.Font = new System.Drawing.Font("Uniwars Sb", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabMines.ForeColor = System.Drawing.Color.Red;
            this.LabMines.Location = new System.Drawing.Point(12, 20);
            this.LabMines.Name = "LabMines";
            this.LabMines.Size = new System.Drawing.Size(64, 32);
            this.LabMines.TabIndex = 5;
            this.LabMines.Text = "00";
            // 
            // LabTimer
            // 
            this.LabTimer.AutoSize = true;
            this.LabTimer.Font = new System.Drawing.Font("Uniwars Sb", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabTimer.ForeColor = System.Drawing.Color.Red;
            this.LabTimer.Location = new System.Drawing.Point(485, 20);
            this.LabTimer.Name = "LabTimer";
            this.LabTimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabTimer.Size = new System.Drawing.Size(89, 32);
            this.LabTimer.TabIndex = 5;
            this.LabTimer.Text = "000";
            this.LabTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 442);
            this.Controls.Add(this.LabTimer);
            this.Controls.Add(this.LabMines);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.GameField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.GameField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameField;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Label LabMines;
        private System.Windows.Forms.Label LabTimer;
        private System.Windows.Forms.Timer timer;
    }
}

