using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace Minesweeper
{
    public class Field
    {
        public int IndexX { get; set; }
        public int IndexY { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public static int Size { get; private set; } = 30;
        public bool IsMine { get; set; }
        public bool IsFlag { get; set; }
        public bool IsRevealed { get; set; }
        public int SurroundingMines { get; set; }
        public Font Font { get; set; } = new Font(FontFamily.GenericMonospace, 15);

        public Field(int idX, int idY)
        {
            IndexX = idX;
            IndexY = idY;
            SetPosition();
        }

        public void Draw(Graphics g)
        {
            DrawNumbers(g);
            DrawTopLayer(g);
            DrawGrid(g);
        }

        private void SetPosition()
        {
            PositionX = IndexX * Size;
            PositionY = IndexY * Size;
        }

        private void DrawGrid(Graphics g)
        {
            g.DrawRectangle(Pens.LightGray, PositionX, PositionY, Size, Size);
        }

        private void DrawNumbers(Graphics g)
        {
            if (IsMine)
            {
                g.FillRectangle(Brushes.Red, PositionX, PositionY, Size, Size);
                Bitmap b = new Bitmap(Properties.Resources.mine_30x30);
                g.DrawIcon(Icon.FromHandle(b.GetHicon()), PositionX, PositionY);
            }
            else
            {
                switch (SurroundingMines)
                {
                    case 0:
                        break;
                    case 1:
                        DrawNumber(g, Brushes.Blue, 1);
                        break;
                    case 2:
                        DrawNumber(g, Brushes.Green, 2);
                        break;
                    case 3:
                        DrawNumber(g, Brushes.Red, 3);
                        break;
                    case 4:
                        DrawNumber(g, Brushes.DarkViolet, 4);
                        break;
                    case 5:
                        DrawNumber(g, Brushes.DarkRed, 5);
                        break;
                    case 6:
                        DrawNumber(g, Brushes.MediumTurquoise, 6);
                        break;
                    case 7:
                        DrawNumber(g, Brushes.Black, 7);
                        break;
                    case 8:
                        DrawNumber(g, Brushes.Gray, 8);
                        break;
                }

            }
        }

        private void DrawNumber(Graphics g, Brush b, int mines)
        {
            g.DrawString(mines.ToString(), this.Font, b, PositionX + Size / 5, PositionY + Size / 5);
        }

        private void DrawTopLayer(Graphics g)
        {
            if (!IsRevealed)
            {
                Bitmap b = new Bitmap(Properties.Resources.facingDown_30x30);
                g.DrawIcon(Icon.FromHandle(b.GetHicon()), PositionX, PositionY);
            }
            else if (IsFlag)
            {
                Bitmap b = new Bitmap(Properties.Resources.flagged_30x30);
                g.DrawIcon(Icon.FromHandle(b.GetHicon()), PositionX, PositionY);
            }
        }
    }
}
