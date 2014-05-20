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
            
            System.Console.WriteLine("Choose a natural number, when done, type a maximum value!");
            string userMax = System.Console.ReadLine();
            int userMaxInt = Convert.ToInt32(userMax);
            if (userMaxInt % 2 ==1) userMaxInt++;
            int userNumber = userMaxInt/2;
            bool errorOccured=false;
            int numberOfQuestions = Convert.ToInt32(Math.Log(Convert.ToDouble(userMaxInt),2));
            System.Console.WriteLine("So, I'm going to ask you {0} questions !", numberOfQuestions);
            for (int logUserMax = 0; logUserMax < numberOfQuestions-1; logUserMax++)
            {
                
                System.Console.WriteLine("Is your number greater than {0}? (yes/no)", userNumber);
                string userInput = System.Console.ReadLine();
                
                if (userInput=="yes")
                    {
                        userMaxInt = userMaxInt / 2 ;
                        userNumber = userNumber + userMaxInt/2;
                    }
                else if (userInput=="no")
                    {
                        userMaxInt = userMaxInt / 2 ;
                        userNumber = userNumber - userMaxInt / 2;
                    }
                else
                    {
                        System.Console.WriteLine("Bad Input! Press any key to exit!");
                        errorOccured = true;
                        break;
                    }
                
            }
            if (!errorOccured)
            {
                System.Console.WriteLine("Is your number {0}?(yes/no)", userNumber);
                string userInputFinal = System.Console.ReadLine();

                if (userInputFinal == "yes")
                {
                    System.Console.WriteLine("Haha, you regretted! {0}", userNumber);
                }
                else if (userInputFinal == "no")
                    System.Console.WriteLine("So, Your number is {0}", userNumber + 1);
                else
                {
                    System.Console.WriteLine("Bad Input! Press any key to exit!");
                    errorOccured = true;
                }
            }
                System.Console.ReadKey();
        }

    }
}
