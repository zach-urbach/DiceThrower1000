using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            //time to throw some dice
            diceString("10d6");
            
            diceString("3d20");
            
            diceString("100d6");
            //keeps console open
            Console.ReadKey();
        }
        static void diceString(string input)
        {
            //the start of the sentence
            Console.WriteLine("Throw the dice! ");
            Console.WriteLine("Throwing " + input);
            List <string> inputList = input.Split('d').ToList();
            //in "10d6" 10 is the [0]
            // and 6 is the [1]
            int n = int.Parse(inputList[0]);
            int m = int.Parse(inputList[1]);

            Random randomNumberGenerator = new Random();
           
            for (int i = 1; i < n + 1; i += 1)
			{
                //the nifty randome number generator
			    int randomNumber = randomNumberGenerator.Next(1, m + 1);
                Console.Write(randomNumber + " ");
            }
            Console.WriteLine();
        }

    }
}
