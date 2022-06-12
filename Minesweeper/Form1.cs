using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        private Game Game { get; set; }
        private int Difficulty { get; set; }
        private int GameWidth { get; set; }
        private int GameHeight { get; set; }
        public int Time { get; set; }

        private const int EASYWIDTH = 9;
        private const int EASYHEIGHT = 9;
        private const int MEDIUWIDTH = 16;
        private const int MEDIUHEIGHT = 16;
        private const int HARDWIDTH = 30;
        private const int HARDHEIGHT = 16;


        public Form1()
        {
            InitializeComponent();
            ShowSettingsDialog();

        }

        private void GameField_Paint(object sender, PaintEventArgs e)
        {
            Game.Draw(e.Graphics);
        }

        private void ShowSettingsDialog()
        {
            timer.Stop();

            StartWindow settings = new StartWindow();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                Difficulty = settings.Difficulty;
            }
            else
            {
                Application.Exit();
            }

            LabTimer.Text = "000";
            ResizeWindow();
            Game = new Game(GameWidth, GameHeight, Difficulty);
            LabMines.Text = Game.MineCount.ToString();
            GameField.Refresh();
            GameField.Enabled = true;
            Time = 0;
        }

        private void ResizeWindow()
        {
            switch (Difficulty)
            {
                case 1:
                    GameField.Height = EASYHEIGHT * Field.Size + 1;
                    GameField.Width = EASYWIDTH * Field.Size + 1;

                    GameHeight = EASYHEIGHT;
                    GameWidth = EASYWIDTH;
                    break;
                case 2:
                    GameField.Height = MEDIUHEIGHT * Field.Size + 1;
                    GameField.Width = MEDIUWIDTH * Field.Size + 1;

                    GameHeight = MEDIUHEIGHT;
                    GameWidth = MEDIUWIDTH;
                    break;
                case 3:
                    GameField.Height = HARDHEIGHT * Field.Size + 1;
                    GameField.Width = HARDWIDTH * Field.Size + 1;

                    GameHeight = HARDHEIGHT;
                    GameWidth = HARDWIDTH;
                    break;
            }
            BtnRestart.Location = new Point(GameField.Width / 2 - 10, 12);
            LabTimer.Location = new Point(GameField.Width - 80, 20);
            this.Height = GameField.Height + 100;
            this.Width = GameField.Width + 40;
        }

        private void BtnRestart_Click_1(object sender, EventArgs e)
        {
            ShowSettingsDialog();
        }


        private void GameField_MouseClick_1(object sender, MouseEventArgs e)
        {
            timer.Start();
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Game.Reveal(e.X, e.Y);
                    bool checkMore = true;
                    while (checkMore)
                    {
                        checkMore = Game.RevealSurroundingFields();
                    }
                    break;

                case MouseButtons.Right:
                    Game.SetFlag(e.X, e.Y);
                    break;
            }
            GameField.Refresh();
            LabMines.Text = Convert.ToString(Game.MineCount - Game.FlagsPlaced);
            if (Game.GameOver)
                GameOver();

        }

        public void GameOver()
        {
            //  MessageBox.Show("Game over!");
            GameField.Enabled = false;
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Time++;
            LabTimer.Text = Time.ToString();
        }
    }
}
