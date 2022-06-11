using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public int SurroundingMines { get; set; }

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
            g.DrawRectangle(Pens.Black, PositionX, PositionY, Size, Size);
        }

        private void DrawNumbers(Graphics g)
        {
            if (IsMine)
            {

                g.FillRectangle(Brushes.Red, PositionX, PositionY, Size, Size);
                Bitmap b = new Bitmap(Properties.Resources.mine_30x30);
                g.DrawIcon(Icon.FromHandle(b.GetHicon()), PositionX, PositionY);
            }
        }

        private void DrawTopLayer(Graphics g)
        {

        }
    }
}
