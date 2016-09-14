using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsSlide47Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a console application that asks the user for an integer. 
            //If that integer is evenly divisible by 3, then write “You Won!”
            //If it isn’t, write “You Lost.” 
            //Keep asking them for a number (looping)until they win.

            

            for (int i = 0; i>=0; i++)
            {
                Console.WriteLine("Enter an integer divisible by 3.");
                int userNumber = int.Parse(Console.ReadLine());
                if (userNumber % 3 == 0)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("You Lost.");
                }
            }

        }
    }
}
