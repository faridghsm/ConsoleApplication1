using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number= 32; // the chosen number
            int d=16; // the differing value

            System.Console.WriteLine("Choose a number between 1 and 64, when done, press any key!");
            System.Console.ReadKey();

            for (int i = 0; i < 5; i++ )
            {
                System.Console.WriteLine("Is your number > {0}? (y/n)", number);
                char c = Console.ReadKey().KeyChar; //reads the answer from the user
                
                if (c.Equals('y'))
                    {
                    number = number + d;
                    d = d / 2;
                    }
                else
                    {
                    number = number - d;
                    d = d / 2;
                    }
                System.Console.WriteLine("\n");
            }
            
            System.Console.WriteLine("Is your number {0}?(y/n)", number);
            char ch = Console.ReadKey().KeyChar;
            System.Console.WriteLine("\n");

                if (ch.Equals('y'))
                {
                System.Console.WriteLine("Your number is {0}", number);
                }
            else
                System.Console.WriteLine("Your number is {0}", number + 1);

                System.Console.ReadKey();
        }
    }
}
