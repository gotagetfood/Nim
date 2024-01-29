using NimCSharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NimCSharp.Controllers;
using NimCSharp.Views;
using NimCSharp.model;
using System.Numerics;

namespace NimCSharp.Controllers
{
    internal class Board
    {
        int turnCount;
       // List<stickModel> Sticks;
       boardModel board;
        bool currentTurn;
        InputManager inpManager;
        boardView view;
        playerModel player1;
        playerModel player2;

      


        public Board(InputManager inputManager)
        {
            turnCount = 0;
            currentTurn = true;
            inpManager = inputManager;
            board = new boardModel();
            view = new boardView(inpManager);
            string oneName = inpManager.nameMenu(1);
            player1 = new playerModel(1,oneName , false);
            string twoName = inpManager.nameMenu(2);
            player2 = new playerModel(2, twoName, false);
            board = boardSetup(view.BoardSizeMenu());
            view.setBoard(board);
        }
       void takeSticks(int row, int num)
        {
            for (int i = 0; i < num; i++)
            {
                board.getStickList()[row][i].setActive(false);
            }
        }

        void turn()
        {
            while (board.getActiveSticks() > 1)
            {
                view.printBoard();
                inpManager.divider();
                view.printPlayerScore(player1);
                view.printPlayerScore(player2);
                inpManager.divider();
                if (currentTurn)
                {
                    Vector2 selection = view.turnMenu(player1);
                    takeSticks((int)selection.X, (int)selection.Y);
                    player1.takenSticks+=(int)selection.Y; 
                }
                else
                {
                    Vector2 selection = view.turnMenu(player2);
                    takeSticks((int)selection.X, (int)selection.Y);
                    player2.takenSticks += (int)selection.Y;
                }
                currentTurn = !currentTurn;
                turnCount++;
            }
            gameEnd();
           
           
        }

        public void gameStart()
        {
            turn();
        }

        void gameEnd()
        {
            if (currentTurn)
            {
                player2.haswon = true;
                view.printWinner(player2);
            }
            else
            {
                player1.haswon = true;
                view.printWinner(player1);
            }

        }

        public boardModel boardSetup(int size)
        {

            int id = 0;
                List<List<stickModel>> stickList = new List<List<stickModel>>();
            for (int i = 0; i < size; i++)
            {
                    List<stickModel> sticks = new List<stickModel>();
                    for (int k = 0; k < i + 1; k++)
                    {
                        sticks.Add(new stickModel(id, i, k, true));
                        id++;
                    }
                    stickList.Add(sticks);
                
            }
                return new boardModel(id, stickList);

        }

    }
}
