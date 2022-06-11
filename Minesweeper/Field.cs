using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Field
    {
        public int IndexX { get; set; }
        public int IndexY { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public static int Size { get; private set; } = 30;
        public bool IsFlag { get; set; }
        public int SurroundingMines { get; set; }

        public Field(int idX, int idY, int posX, int posY)
        {

        }
    }
}
