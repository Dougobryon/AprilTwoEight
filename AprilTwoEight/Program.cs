using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilTwoEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you prefer what is behind door 1, 2 or 3?");
            string userValue = Console.ReadLine();
            if (userValue == "1")
            {
                Console.WriteLine("You won a new car! ");
                Console.ReadLine();
            }
            else if (userValue == "2")
            {
                Console.WriteLine("You won a boat! ");
                Console.ReadLine();
            }
            else if (userValue == "3")
            {
                Console.WriteLine("You won a clunk! ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry we didn't get that. Try again");
                Console.ReadLine();

            }
        }
    }
}
