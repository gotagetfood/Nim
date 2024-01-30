using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using NimCSharp.model;

namespace NimCSharp.Views
{
    internal class boardView
    {
        private InputManager inpManager;
        boardModel board;

        int boardSize;

        public boardView(boardModel board, InputManager inpManager)
        {
            this.board = board;
            boardSize = board.getStickList().Count;
            this.inpManager = inpManager;
        }

        public boardView(InputManager inpManager)
        {
            this.inpManager = inpManager;
        }

        public void setBoard(boardModel board)
        {
            this.board = board;
        }
        public void printBoard()
        {
            inpManager.divider();
            Console.WriteLine("Board:");
            int row = 1;
            foreach (List<stickModel> stick in board.getStickList())
            {
                int rowCenteringSpaces = 0;
                rowCenteringSpaces = (board.getStickList().Count - row);
                string rowString = "";

                rowString += row + ": ";
                for (int i = 0; i < rowCenteringSpaces; i++)
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
                        rowString += "  ";
                    }
                }
                Console.WriteLine(rowString);
                row++;
            }

        }

        public void printPlayerScore(playerModel player)
        {
            Console.WriteLine(player.name + " has " + player.takenSticks + " sticks");
        }

        public Vector2 turnMenu(playerModel player)
        {

            //printTurn(player);
            // inpManager.divider();
            Console.WriteLine(player.name + ", please select a row to take sticks from.");
            inpManager.divider();
            int selection = inpManager.inputNumber();
            while (selection < 1 || selection > boardSize)
            {
                Console.WriteLine("Please enter a valid row");
                selection = inpManager.inputNumber();
            }
            List<stickModel> selectedRow = board.getStickList()[selection - 1];
            inpManager.divider();
            Console.WriteLine("Please enter the number of sticks to take");
            inpManager.divider();
            int num = inpManager.inputNumber();
            while (num < 1 || num > board.getActiveSticksInRow(selection-1))
            {
                Console.WriteLine("Please enter a valid number of sticks");
                num = inpManager.inputNumber();
            }
            return new Vector2(selection - 1, num);

        }

        public void printTurn(playerModel player)
        {
            Console.WriteLine(player.name + "'s turn");
        }

        public void printWinner(playerModel player)
        {
            inpManager.divider();
            printBoard();
            inpManager.divider();
            Console.WriteLine(player.name + " has won!");
            inpManager.divider();
        }

        public int BoardSizeMenu()
        {
            inpManager.divider();
            Console.WriteLine("Please enter the size of the board");
            inpManager.divider();
            boardSize = inpManager.inputNumber();
            while (boardSize < 1)
            {
                Console.WriteLine("Please enter a valid number");
                boardSize = inpManager.inputNumber();
            }
            return boardSize;

        }


    }
}
