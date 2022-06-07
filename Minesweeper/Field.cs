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
        public int Size { get; set; } = 20;
        public bool IsFlag { get; set; }
        public int SurroundingMines { get; set; }


    }
}
