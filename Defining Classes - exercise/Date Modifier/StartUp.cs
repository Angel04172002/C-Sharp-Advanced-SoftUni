using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine(); 
            Console.WriteLine(DateModifier.CalculateDifferenceBetweenDates(firstDate, secondDate));
        }
    }
}
