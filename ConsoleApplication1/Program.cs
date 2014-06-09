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
            
            System.Console.WriteLine("Choose a (not negative) number, when done, type a maximum value!");
            string userMax = System.Console.ReadLine();

            int upperBound = Convert.ToInt32(userMax);
            int lowerBound = 0;
            int middlePoint = (upperBound + lowerBound) / 2;
            int numberOfQuestions = Convert.ToInt32(Math.Ceiling(Math.Log(Convert.ToDouble(upperBound), 2)));

            System.Console.WriteLine("So, I'm going to ask you {0} questions !", numberOfQuestions);

            while (!(lowerBound == upperBound))
            {
                System.Console.WriteLine("Is your number greater than {0}? (y/n)",middlePoint);

                string userInput = System.Console.ReadLine();
                if(userInput=="y")
                {
                    lowerBound = middlePoint + 1;
                    middlePoint = (middlePoint + upperBound)/2;
                }
                else if (userInput=="n")
                {
                    upperBound = middlePoint;
                    middlePoint = (middlePoint + lowerBound) / 2;
                }
                else
                {
                    System.Console.WriteLine("Bad Input! Press any key to exit!");
                    break;
                }
                
            }
            Console.WriteLine("The number is:{0}", upperBound);
            System.Console.ReadKey();
        }

    }
}
