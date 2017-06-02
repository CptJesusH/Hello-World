using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPiToTheNthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is by far the best, most efficient, least error-prone way of telling a user what the nth digit of pi is.

            Console.WriteLine("Asuh, dude! Enter a number between 0 and 10!");
            string numberString = Console.ReadLine();
            int number = Int32.Parse(numberString);
            if(number == 1)
            {
                Console.WriteLine("Pi to the 1st decimal place is: 3.1");
            }
            else if(number == 2)
            {
                Console.WriteLine("Pi to the 2nd decimal place is: 3.14");
            }
            else if (number == 3)
            {
                Console.WriteLine("Pi to the 3rd decimal place is: 3.141");
            }
            else if (number == 4)
            {
                Console.WriteLine("Pi to the 4th decimal place is: 3.1415");
            }
            else if (number == 5)
            {
                Console.WriteLine("Pi to the 5th decimal place is: 3.14159");
            }
            else if (number == 6)
            {
                Console.WriteLine("Pi to the 6th decimal place is: 3.141592");
            }
            else if (number == 7)
            {
                Console.WriteLine("Pi to the 7th decimal place is: 3.1415926");
            }
            else if (number == 8)
            {
                Console.WriteLine("Pi to the 8th decimal place is: 3.14159265");
            }
            else if (number == 9)
            {
                Console.WriteLine("Pi to the 9th decimal place is: 3.141592653");
            }
            else if (number == 10)
            {
                Console.WriteLine("Pi to the 10th decimal place is: 3.1415926535");
            }
            else
            {
                Console.WriteLine("Invalid Entry.");
            }
        }
    }
}
