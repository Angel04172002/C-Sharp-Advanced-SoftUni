using System;

namespace CustomLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList linkedList = new CustomLinkedList();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            linkedList.RemoveLast();
            linkedList.RemoveFirst();

            Console.WriteLine(linkedList.Count);

            linkedList.ForEach(x =>
            {
                Console.WriteLine($"The element is {x}");
            });
        }
    }
}
