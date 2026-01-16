using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class InfixToPostfixConverter
    {
        private static int GetPrecedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        public static string ConvertInfixToPostfix(string expression)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder output = new StringBuilder();

            foreach (char ch in expression)
            {
                if (ch == ' ')
                    continue;

                if (char.IsDigit(ch) || char.IsLetter(ch))
                {
                    output.Append(ch);
                }
                else if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        output.Append(stack.Pop());

                    if (stack.Count == 0)
                        throw new InvalidOperationException("Mismatched parentheses.");

                    stack.Pop(); // remove '('
                }
                else
                {
                    while (stack.Count > 0 && GetPrecedence(ch) <= GetPrecedence(stack.Peek()))
                        output.Append(stack.Pop());

                    stack.Push(ch);
                }
            }

            while (stack.Count > 0)
            {
                if (stack.Peek() == '(')
                    throw new InvalidOperationException("Mismatched parentheses.");

                output.Append(stack.Pop());
            }

            return output.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string infixExpression = ("(3+2)+7/2*((7+3)*2)");
            Console.WriteLine("Postfix Expression: " + InfixToPostfixConverter.ConvertInfixToPostfix(infixExpression));

            Console.ReadKey();
        }
    }
}
