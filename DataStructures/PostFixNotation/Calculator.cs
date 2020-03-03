using System;
using System.Collections.Generic;

namespace PostFixNotation
{
    class Calculator
    {
        static void Main(string[] args)
        {
            args = new string[] { "5", "6", "7", "*","+", "1", "-" };

            //The stack of integers not yet operated on
            Stack<int> values = new Stack<int>();

            foreach(string token in args)
            {
                // if the value is an integer...
                int value;
                if (int.TryParse(token, out value))
                {
                    //...push it to the stack
                    values.Push(value);
                }
                else
                {
                    // otherwise evaluate the expression
                    int righthandSide = values.Pop();
                    int lefthandSide = values.Pop();

                    // ... and pop the result back to the stack
                    switch (token)
                    {
                        case "+":
                            values.Push(lefthandSide + righthandSide);
                            break;
                        case "-":
                            values.Push(lefthandSide - righthandSide);
                            break;
                        case "*":
                            values.Push(lefthandSide * righthandSide);
                            break;
                        case "/":
                            values.Push(lefthandSide/ righthandSide);
                            break;
                        case "%":
                            values.Push(lefthandSide % righthandSide);
                            break;
                        default:
                            throw new ArgumentException(string.Format("Unrecognized token: {0}", token));
                    }
                }
            }
            // the last item on the stack is the result
            Console.WriteLine(values.Pop());
        }
    }
}
