using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NimCSharp.Views
{
    internal class InputManager
    {
        //for change doc, design change, compare method is bool not void
        public void generateMenu(string intro, string[] options)
        {
            int i = 1;
            Console.WriteLine(intro);
            divider();
            foreach (string s in options)
            {
                Console.WriteLine(i + "] " + s);
                i++;
            }
            divider();
        }

        //design change, returns string not void
        public string stringEnter(string parameter)
        {
            string input = Console.ReadLine();
            while (input == null)
            {
                Console.WriteLine("Please enter a valid " + parameter);
                input = Console.ReadLine();
            }
            return input;
        }

        public void divider()
        {
            Console.WriteLine("-----------------------");
        }


        //design change, added methods for input validation

        public int inputNumber()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter a valid number");
            }
            return number;
        }

        public string nameMenu(int num)
        {
            divider();
            Console.WriteLine("Player " + num + " Please enter your name");
            divider();
           return stringEnter("name");
        }




    }
}
