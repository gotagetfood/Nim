using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimCSharp
{
    internal class InputManager
    {
        //for change doc, design change, compare method is bool not void
        public void generateMenu(List<String> options)
        {
            int i = 1;
            foreach (string s in options)
            {
                Console.WriteLine(i + "] " + s);
                i++;
            }
        }

        //design change, returns string not void
        public string stringEnter()
        {
            string input = Console.ReadLine();
            while (input == null)
            {
                Console.WriteLine("Please enter a valid string");
                input = Console.ReadLine();
            }
            return "";
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






    }
}
