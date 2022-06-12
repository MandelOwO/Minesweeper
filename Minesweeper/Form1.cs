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
            StartWindow settings = new StartWindow();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                Difficulty = settings.Difficulty;
            }
            else
            {
                Application.Exit();
            }
            ResizeWindow();
            Game = new Game(GameWidth, GameHeight, Difficulty);
            GameField.Refresh();
            GameField.Enabled = true;
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

            this.Height = GameField.Height + 100;
            this.Width = GameField.Width + 40;
        }

        private void BtnRestart_Click_1(object sender, EventArgs e)
        {
            ShowSettingsDialog();
        }


        private void GameField_MouseClick_1(object sender, MouseEventArgs e)
        {
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

                    break;
            }
            GameField.Refresh();

            if (Game.GameOver)
                GameOver();

        }

        public void GameOver()
        {
            //  MessageBox.Show("Game over!");
            GameField.Enabled = false;
        }
    }
}
