using System;
using System.Collections.Generic;
using System.Linq;

namespace wimpleCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            List<string> lettersAndOperators = expression.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            lettersAndOperators.Reverse();
            int? result = null;

            Stack<string> stackLettersOperators = new Stack<string>(lettersAndOperators);




            Console.WriteLine(stackLettersOperators.Pop());
            Console.WriteLine(stackLettersOperators.Pop());
            Console.WriteLine(stackLettersOperators.Pop());


            while (stackLettersOperators.Count > 0)
            {
                if (result != null)
                {
                    stackLettersOperators.Push(result.ToString());
                }

                int firstDigit = int.Parse(stackLettersOperators.Pop());
                string symbol = stackLettersOperators.Pop();
                int secondDigit = int.Parse(stackLettersOperators.Pop());
         
                if(symbol == "+")
                {
                    result = firstDigit + secondDigit;
                }

                else if(symbol == "-")
                {
                    result = firstDigit - secondDigit;
                }
            }

            Console.WriteLine(result);
        }
    }
}
