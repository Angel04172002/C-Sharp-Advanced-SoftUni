using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Person person = new Person(input[0], int.Parse(input[1]));
                family.AddMember(person);
            }

            List<Person> peopleList = family.People
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            foreach(var person in peopleList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
    
        }
    }
}
