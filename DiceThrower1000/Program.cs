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
            Console.WriteLine();
            diceString("3d20");
            Console.WriteLine();
            diceString("100d6");

            Console.ReadKey();
        }
        static void diceString(string input)
        {
            List <string> inputList = input.Split('d').ToList();
            int n = int.Parse(inputList[0]);
            int m = int.Parse(inputList[1]);
            Random randomNumberGenerator = new Random();
           
            for (int i = 1; i < n; i += 1)
			{
			    int randomNumber = randomNumberGenerator.Next(1,m + 1);
                Console.WriteLine(randomNumber);
            }
            
        }

    }
}
