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
    public partial class StartWindow : Form
    {
        public int Difficulty { get; set; }

        public StartWindow()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (RbtnEasy.Checked)
            {
                Difficulty = 1;
            }
            else if (RbtnMedium.Checked)
            {
                Difficulty = 2;
            }
            else if (RbtnHard.Checked)
            {
                Difficulty = 3;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
