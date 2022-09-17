using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balancedParentheses2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isBalanced = true;
            string sequence = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>();

          


            for (int i = 0; i < sequence.Length / 2; i++)
            {
                if (sequence[i] == '(' || sequence[i] == '{' || sequence[i] == '[' || sequence[i] == ' ')
                {
                    parentheses.Push(sequence[i]);
                }
            }

            for(int i = sequence.Length/2; i < sequence.Length; i++)
            { 

               
                
                    if (sequence[i] == ')')
                    {
                        if(parentheses.Peek() == '(')
                        {
                            parentheses.Pop();
                            
                        }

                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }

                    else if (sequence[i] == '}')
                    {
                        if(parentheses.Peek() == '{')
                        {
                            parentheses.Pop();
                            
                        }

                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }

                    else if (sequence[i] == ']')
                    {
                        if(parentheses.Peek() == '[')
                        {
                            parentheses.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }

                    else if (sequence[i] == ' ')
                    {
                        if(parentheses.Peek() == ' ')
                        {
                            parentheses.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                }
            

            if(isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}

