using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            people = new List<Person>();
        }

        public List<Person> People
        {
            get { return this.people; }
        }

        public void AddMember(Person member)
        {
            people.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = people.Max(p => p.Age);
            int index = people.FindIndex(p => p.Age == maxAge);
            
            return people[index];
        }
    }
}
