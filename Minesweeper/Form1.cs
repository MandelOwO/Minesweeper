using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Game Game { get; set; }
        public int Difficulty { get; set; }
        private const int EASYWIDTH = 9;
        private const int EASYHEIGHT = 9;
        private const int MEDIUWIDTH = 16;
        private const int MEDIUHEIGHT = 16;
        private const int HARDWIDTH = 30;
        private const int HARDHEIGHT = 16;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameField_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowSettingsDialog();
        }

        public void ShowSettingsDialog()
        {
            StartWindow settings = new StartWindow();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                Difficulty = settings.Difficulty;
            }
            else if (settings.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
            ResizeWindow();
        }

        public void ResizeWindow()
        {
            if (Difficulty == 1)
            {
                GameField.Height = EASYHEIGHT * Field.Size;
                GameField.Width = EASYWIDTH * Field.Size;
            }
            else if (Difficulty == 2)
            {
                GameField.Height = MEDIUHEIGHT * Field.Size;
                GameField.Width = MEDIUWIDTH * Field.Size;
            }
            else if (Difficulty == 3)
            {
                GameField.Height = HARDHEIGHT * Field.Size;
                GameField.Width = HARDWIDTH * Field.Size;
            }

            BtnRestart.Location = new Point(GameField.Width / 2, 12);

            this.Height = GameField.Height + 100;
            this.Width = GameField.Width + 40;
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            ShowSettingsDialog();
        }
    }
}
