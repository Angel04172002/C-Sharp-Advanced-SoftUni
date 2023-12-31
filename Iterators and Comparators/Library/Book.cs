using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public string Title { get; set; }
        public int Year { get; set; }

        public List<string> Authors { get; set; }

        public int CompareTo(Book? other)
        {
            int yearCompare = this.Year.CompareTo(other.Year);

            if (yearCompare == 0)
            {
                return this.Title.CompareTo(other.Title);   
            }

            return yearCompare;
        }

        public override string ToString()
        {
            return $"{this.Title} - ${this.Year}";
        }
    }
}
