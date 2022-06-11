using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Game
    {
        public List<Field> Fields { get; set; }
        public int FieldWidth { get; set; } = 32;
        public int FieldHeight { get; set; } = 32;
        public int GameWidthPx { get; set; }
        public int GameHeightPx { get; set; }

        public Game()
        {
            GameWidthPx = FieldWidth * 20;
            GameHeightPx = FieldHeight * 20;



        }

        public void Draw()
        {

        }

    }
}
