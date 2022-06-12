using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public int MineCount { get; set; }
        public int FlagsPlaced { get; set; }
        private Random random { get; set; }
        public bool GameOver { get; set; } = false;


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
            g.Clear(Color.GhostWhite);
            foreach (var field in Fields)
            {
                if (GameOver)
                {
                    field.IsRevealed = true;
                }
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

        public void Reveal(int x, int y)
        {
            foreach (var field in Fields)
            {
                if (x > field.PositionX && x < field.PositionX + Field.Size && y > field.PositionY && y < field.PositionY + Field.Size)
                {
                    field.IsRevealed = true;
                    if (field.IsMine)
                        GameOver = true;

                }
            }
        }

        public void SetFlag(int x, int y)
        {
            foreach (var field in Fields)
            {
                if (x > field.PositionX && x < field.PositionX + Field.Size && y > field.PositionY &&
                    y < field.PositionY + Field.Size)
                {
                    if (!field.IsFlag)
                    {
                        field.IsFlag = true;
                        FlagsPlaced++;
                    }
                    else
                    {
                        field.IsFlag = false;
                        FlagsPlaced--;
                    }

                }
            }
        }
        public bool RevealSurroundingFields()
        {
            bool checkMore = false;

            foreach (var field in Fields)
            {
                if (field.IsRevealed && field.SurroundingMines == 0)
                {
                    for (int x = -1; x <= 1; x++)
                    {
                        for (int y = -1; y <= 1; y++)
                        {
                            foreach (var checkingField in Fields)
                            {
                                if (field.IndexX + x == checkingField.IndexX && field.IndexY + y == checkingField.IndexY && checkingField.IsRevealed == false)
                                {
                                    checkingField.IsRevealed = true;
                                    checkMore = true;
                                }
                            }
                        }
                    }
                }
            }

            return checkMore;
        }
    }
}
