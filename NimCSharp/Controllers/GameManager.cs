using NimCSharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimCSharp.Controllers
{
    internal class GameManager
    {
        Board board;   
        InputManager inputManager;
      
        public GameManager()
        {
            inputManager = new InputManager();
          
        }
        private void Game()
        {
            board = new Board(inputManager);
            board.gameStart();
            GameOver();

        }

        public void startMenu()
        {
            string[] options = new string[] { "Start Game", "Exit" };
            inputManager.generateMenu("Welcome to Nim, would you like to start a game or exit?", options);
            bool menu = true;
            while (menu)
            {
                switch (inputManager.inputNumber())
                {
                    case 1:
                        menu = false;
                        Game();
                        break;
                    case 2:
                        menu = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
            }
        }

        public void GameOver()
        {
            bool menu = true;
            string[] options = new string[] { "Exit", "Play Again" };
          inputManager.generateMenu("The game is now over, would you like to exit, or play again?", options);
            while (menu)
            {
                switch (inputManager.inputNumber())
                {
                    case 1:
                        menu = false;
                        Environment.Exit(0);
                        break;
                    case 2:
                        menu = false;
                        Game();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
            }
        }

      

    }
}
