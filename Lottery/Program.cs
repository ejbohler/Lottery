using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {//testing version control
        static void Main(string[] args)
        {
            string again = "y";
            while (again == "y")
            {
                int min = 0;
                int max = 1000;
                Random rdm = new Random();
                int my = rdm.Next(min, max);

                Console.WriteLine("Think of a number between "+min+" & "+max+".");

                Console.WriteLine("Please type in your number.");
                var a = Console.ReadLine();
                int num = Convert.ToInt32(a);
                if (num>max)
                { Console.WriteLine("That number is too LARGE! Try again with a number less then "+(max+1)+".");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                if (num<min)
                {
                    Console.WriteLine("That number is too SMALL! Try again with a number greater than " + (min-1) + ".");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("My randomly chosen number is " + my + ".");
                Console.WriteLine("Your number was " + num + ".");
                if (num == my)
                {
                    Console.WriteLine("Congratulations! You win!");
                }
                else
                {
                    Console.WriteLine("Sorry. You lose.");

                }
                Console.WriteLine("Would you like to try again?");
                Console.WriteLine("Enter 'y' for Yes, or 'n' for No.");
                again = Console.ReadLine();
            }
        }
        
                }
    }

   
