using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GOL
{
    class Program
    {
        static void Main(string[] args)
        {

            TheGameBoard thegameboard = new TheGameBoard();
            thegameboard.FillBoard();

            thegameboard.RandomCellsAlive(1000);

            //Loppen där spelet körs
            //Thread.Sleep får spelet att pausas i 150 millisekunder
            while (true)
            {

                Console.Clear();
                thegameboard.Analyze();
                Console.WriteLine("------------------======== The Game Of Life ========------------------\n______________________________________________________________________");
                thegameboard.PrintBoard();
                Console.WriteLine("______________________________________________________________________");
                thegameboard.Neighbours();
                thegameboard.ChangeBoard();

                Thread.Sleep(150);


            }
        }
    }
}