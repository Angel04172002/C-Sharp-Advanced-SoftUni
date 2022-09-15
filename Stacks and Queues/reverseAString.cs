using System;
using System.Collections.Generic;

namespace reverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> letters = new Stack<char>();

            for(int i = 0; i < input.Length; i++)
            {
                letters.Push(input[i]);
            }

            for(int i = 0; i < input.Length; i++)
            {
                Console.Write(letters.Pop());
            }
        }
    }
}
