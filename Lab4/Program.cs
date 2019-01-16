using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Time to learn squares and cubes of numbers");
            bool run = true;
            while (run)
            {
                int x, z, y;
                Console.Write("Enter an integer: ");
                x = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("======\t\t======\t\t======");
                for (int i=1; i<=x; i++)
                {
                    z = SquaredInteger(i);
                    y = CubedInteger(i);
                    
                    Console.WriteLine(i + "\t\t" + z + "\t\t" + y);
                    
                }
                for (int i = 1; i <= x; i++)
                {
                    
                }
                Console.WriteLine("Would you like to run another set of integers? (y/n)");
                string decision = Console.ReadLine().ToLower();

                bool goOn;
              if (decision == "y")       
              {
                    goOn = true;
              }
              else if (decision == "n")
                {
                    goOn = false;
                    break;
                }
              else
                {
                    Console.WriteLine("I don't understand, please try again.");
                    
                }
            }
                    
        }
        public static int SquaredInteger(int i)
        {
            int squared = i * i;
            return squared;
        }
        public static int CubedInteger (int i)
        {
            int cubed = i * i * i;
            return cubed;
        }
    }
}

