using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    public class TheGameBoard
    {
        Cell[,] Board;
        int X = 70;
        int Y = 25;
        string PrintedGame = string.Empty;
        public TheGameBoard()
        {
            this.Board = new Cell[Console.WindowHeight, Console.WindowWidth];
        }
        public void FillBoard()
        {
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    Cell cell = new Cell(false, 0);
                    Board[y, x] = cell;
                }
            }
        }
        public void RandomCellsAlive(int go)
        {

            Random randommovment = new Random();
            while (0 < go)
            {
                int y = randommovment.Next(0, Y);
                int x = randommovment.Next(0, X);

                Board[y, x].Alive = true;
                go--;
            }
        }
        public void Analyze()
        {

            PrintedGame = string.Empty;
            Console.Clear();
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    if (Board[y, x].Alive == true)
                    {
                        PrintedGame += "#";
                    }
                    else if (Board[y, x].Alive == false) { PrintedGame += " "; }

                }
                PrintedGame += "\n";
            }
        }
        public void PrintBoard()
        {
            Console.Write(PrintedGame);
        }
        public void Neighbours()
        {
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    Board[y, x].Neighbour = 0;
                    if (y != 0 && Board[y - 1, x].Alive == true)
                    {
                        Board[y, x].Neighbour += 1;
                    }
                    if (y != 0 && x != X - 1 && Board[y - 1, x + 1].Alive == true)
                    {
                        Board[y, x].Neighbour += 1;
                    }
                    if (y != 0 && x != 0 && Board[y - 1, x - 1].Alive == true)
                    {
                        Board[y, x].Neighbour += 1;
                    }
                    if (y != Y - 1 && Board[y + 1, x].Alive == true)
                    {
                        Board[y, x].Neighbour += 1;
                    }
                    if (y != Y - 1 && x != X - 1 && Board[y + 1, x + 1].Alive == true)
                    {
                        Board[y, x].Neighbour += 1;
                    }
                    if (y != Y - 1 && x != 0 && Board[y + 1, x - 1].Alive == true)
                    {
                        Board[y, x].Neighbour += 1;
                    }
                    if (x != X - 1 && Board[y, x + 1].Alive == true)
                    {
                        Board[y, x].Neighbour += 1;
                    }
                    if (x != 0 && Board[y, x - 1].Alive == true)
                    {
                        Board[y, x].Neighbour += 1;
                    }
                }
            }

        }
        public void ChangeBoard()
        {
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    if (Board[y, x].Alive == true && Board[y, x].Neighbour == 3)
                    {
                        Board[y, x].Color = +1;
                    }
                    else if (Board[y, x].Alive == true && Board[y, x].Neighbour == 2)
                    {
                        Board[y, x].Color += 1;
                    }
                    else if (Board[y, x].Alive == true && Board[y, x].Neighbour < 2 || Board[y, x].Neighbour > 3)
                    {
                        Board[y, x].Alive = false; Board[y, x].Color = 1;
                    }
                    else if (Board[y, x].Alive == false && Board[y, x].Neighbour == 3)
                    {
                        Board[y, x].Alive = true;
                    }
                }
            }
        }
    }
}