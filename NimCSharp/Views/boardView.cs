using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NimCSharp.model;

namespace NimCSharp.Views
{
    internal class boardView
    {
        public void printBoard(boardModel board)
        {

            Console.WriteLine("Board:");
            int row = 1;
            foreach (List<stickModel> stick in board.getStickList())
            {
                Console.WriteLine("\n" + row + ":");
                foreach (stickModel s in stick)
                {
                    if (s.isActive())
                    {
                        Console.Write("*\n|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
                row++;
            }

        }
    }
}
