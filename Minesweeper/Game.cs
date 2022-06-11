using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Game
    {
        private List<Field> Fields { get; set; } = new List<Field>();
        private int FieldWidth { get; set; }
        private int FieldHeight { get; set; }
        private int GameWidthPx { get; set; }
        private int GameHeightPx { get; set; }
        private int Difficulty { get; set; }
        private int MineCount { get; set; }
        private Random random { get; set; }

        public Game(int width, int height, int difficulty)
        {

            FieldWidth = width;
            FieldHeight = height;
            Difficulty = difficulty;
            random = new Random();

            GameWidthPx = FieldWidth * Field.Size;
            GameHeightPx = FieldHeight * Field.Size;

            GenerateFields();
            GenerateMines();
            CountSurroundingMines();
        }

        private void PrepareMines()
        {
            MineCount = Difficulty switch
            {
                1 => 9,
                2 => 40,
                3 => 99,
                _ => MineCount
            };
        }
        public void Draw(Graphics g)
        {
            foreach (var field in Fields)
            {
                field.Draw(g);
            }
        }

        private void GenerateFields()
        {
            for (int x = 0; x < FieldWidth; x++)
            {
                for (int y = 0; y < FieldHeight; y++)
                {
                    Field f = new Field(x, y);
                    Fields.Add(f);
                }
            }
        }

        private void GenerateMines()
        {
            PrepareMines();

            for (int i = 0; i < MineCount;)
            {
                int randomX = random.Next(0, FieldWidth);
                int randomY = random.Next(0, FieldHeight);

                foreach (var field in Fields)
                {
                    if (field.IndexX == randomX && field.IndexY == randomY && !field.IsMine)
                    {
                        field.IsMine = true;
                        i++;
                    }
                }
            }
        }

        private void CountSurroundingMines()
        {
            foreach (var field in Fields)
            {
                for (int x = -1; x <= 1; x++)
                {
                    for (int y = -1; y <= 1; y++)
                    {
                        foreach (var checkingField in Fields)
                        {
                            if (field.IndexX + x == checkingField.IndexX && field.IndexY + y == checkingField.IndexY && checkingField.IsMine)
                            {
                                field.SurroundingMines++;
                            }
                        }
                    }
                }
            }
        }
    }
}
