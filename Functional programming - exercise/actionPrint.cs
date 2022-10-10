using System;

namespace actionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> actionNames = (names) =>
            {
                Console.WriteLine(string.Join("\n", names));
            };

            string[] names = Console.ReadLine().Split(' ');
            actionNames(names);

        }
    }
}
