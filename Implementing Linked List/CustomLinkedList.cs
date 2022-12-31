using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class CustomLinkedList
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public int Count { get; private set; }

        public void AddFirst(Node node)
        {
            Count++;

            if(Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.NextNode = Head;
            Head.PreviousNode = node;
            Head = node;
        }

        public void AddFirst(int value)
        {
            AddFirst(new Node(value));
        }

        public void AddLast(Node node)
        {
            Count++;

            if(Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.PreviousNode = Tail;
            Tail.NextNode = node;
            Tail = node;
        }

        public void AddLast(int value)
        {
            AddLast(new Node(value));
        }

        public int RemoveFirst()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            Count--;
            Node oldNode = Head;
            Head = Head.NextNode;
            Head.PreviousNode = null;
            oldNode.NextNode = null;

            return oldNode.Value;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            Count--;
            Node oldNode = Tail;
            Tail = Tail.PreviousNode;
            Tail.NextNode = null;
            oldNode.PreviousNode = null;

            return oldNode.Value;
        }

        public void ForEach(Action<int> callback)
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            Node currentNode = Head;

            while(currentNode != null)
            {
                callback(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            Node currentNode = Head;
            int[] array = new int[Count];
            int i = 0;

            while(currentNode != null)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.NextNode;
                i++;
            }

            return array;
        }
    }
}
