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
                int rowCenteringSpaces = 0;
                rowCenteringSpaces = (board.getStickList().Count - row);
                string rowString = "";

                rowString += row + ": ";
                for(int i = 0; i < rowCenteringSpaces; i++)
                {
                    rowString += " ";
                }
              foreach (stickModel s in stick)
                {
                    if (s.isActive())
                    {
                        rowString += " |";
                    }
                    else
                    {
                        rowString += " ";
                    }
                }
              

                Console.WriteLine(rowString);
                row++;
            }

        }
    }
}
