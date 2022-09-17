using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> memory = new Stack<string>();
            Stack<string> redoCommands = new Stack<string>();
            StringBuilder text = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            string command = "";

            for(int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                string[] splittedCommand = command.Split(' ');
                int nameOfCommand = int.Parse(splittedCommand[0]);

                if (nameOfCommand == 1)
                {
                    string textOfCommand = splittedCommand[1];
                    text.Append(textOfCommand);
                    memory.Push(text.ToString());
                }

                else if (nameOfCommand == 2)
                {
                    int countRemoveElements = int.Parse(splittedCommand[1]);
                    text = text.Remove(text.Length - countRemoveElements, countRemoveElements);
                    memory.Push(text.ToString());
                }

                else if (nameOfCommand == 3)
                {
                    int index = int.Parse(splittedCommand[1]);

                    if (index >= 1 && index <= text.Length)
                    {
                        Console.WriteLine(text[index - 1]);
                    }
                }

                else if (nameOfCommand == 4)
                {
                    if (memory.Count > 1)
                    {
                        redoCommands.Push(memory.Pop());
                        text = new StringBuilder(memory.Peek());
                    }

                    else if (memory.Count == 1)
                    {
                        redoCommands.Push(memory.Pop());
                        text = new StringBuilder("");
                    }
                }

                else if(nameOfCommand == 5)
                {
                    if(redoCommands.Count >= 1)
                    {
                        text = new StringBuilder(redoCommands.Pop());
                    }
                }
            }

        }
    }
}
