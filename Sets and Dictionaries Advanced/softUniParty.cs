using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            string command = Console.ReadLine();

            while(command != "PARTY")
            {
                regularGuests.Add(command);
                command = Console.ReadLine();
            }

            command = Console.ReadLine();   

            while(command != "END")
            {
                vipGuests.Add(command);
                command = Console.ReadLine();
            }

            regularGuests.ExceptWith(vipGuests);

            Console.WriteLine(regularGuests.Count);

            if (regularGuests.Count > 0)
            {
                foreach (var guest in regularGuests)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
