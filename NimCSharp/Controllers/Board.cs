using NimCSharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NimCSharp.Controllers;
using NimCSharp.Views;

namespace NimCSharp.Controllers
{
    internal class Board
    {
        int turnCount;
        List<stickModel> Sticks;
        bool currentTurn;

        playerModel player1;
        playerModel player2;

        InputManager inpManager;

        bool takeSticks(int row, int num)
        {
            return false;
        }

        void gameStart()
        {

        }

        void gameEnd()
        {

        }

    }
}
