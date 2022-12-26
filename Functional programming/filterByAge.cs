using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{

    class Student
    {
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    
        public string Name { get; set; }

        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(", ");
                students.Add(new Student(line[0],
                    int.Parse(line[1]))
                { });
          
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Func<Student, bool> conditionChecker = ConditionCheck(condition, age);
            students = students.Where(conditionChecker).ToList();

            string param = Console.ReadLine();
            Action<Student> printer = Print(param);
            students.ForEach(printer);

        }

        static Action<Student> Print(string param)
        {
            switch(param)
            {
                case "name":
                    return s => Console.WriteLine(s.Name);

                case "age":
                    return s => Console.WriteLine(s.Age);

                case "name age":
                    return s => Console.WriteLine($"{s.Name} - {s.Age}");

                default:
                    return null;

            }
        }

        static Func<Student, bool> ConditionCheck(string condition, int age)
        {
            switch(condition)
            {
                case "younger":
                    return s => s.Age < age;

                case "older":
                    return s => s.Age >= age;

                default:
                    return null;
            }
        }

    }
}
