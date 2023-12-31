namespace IteratorsAndComparators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("a", 1985, "a");
            Book book2 = new Book("b", 1985, "b");
            Book book3 = new Book("c", 1985, "c");


            Library lib = new Library(book2, book3, book);

            foreach (var item in lib)
            {
                Console.WriteLine(item);
            }

        }

    }
}
