using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an infix expression (e.g., 3 + 4 * 2 / ( 1 - 5 ) ^ 2):");
        string infixExpression = Console.ReadLine().Trim();

        try
        {
            string postfixExpression = ConvertInfixToPostfix(infixExpression);
            Console.WriteLine($"Postfix expression: {postfixExpression}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static string ConvertInfixToPostfix(string infixExpression)
    {
        StringBuilder postfix = new StringBuilder();
        Stack<char> stack = new Stack<char>();
        
        Dictionary<char, int> precedence = new Dictionary<char, int>
        {
            {'+', 1},
            {'-', 1},
            {'*', 2},
            {'/', 2},
            {'^', 3}
        };

        foreach (char c in infixExpression)
        {
            if (char.IsDigit(c) || char.IsLetter(c))
            {
                postfix.Append(c);
            }
            else if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    postfix.Append(stack.Pop());
                }
                stack.Pop(); 
            }
            else if (precedence.ContainsKey(c))
            {
                while (stack.Count > 0 && precedence[c] <= precedence[stack.Peek()])
                {
                    postfix.Append(stack.Pop());
                }
                stack.Push(c);
            }
            else
            {
                throw new ArgumentException("Invalid character in the expression.");
            }
        }

        while (stack.Count > 0)
        {
            if (stack.Peek() == '(' || stack.Peek() == ')')
            {
                throw new ArgumentException("Mismatched parentheses in the expression.");
            }
            postfix.Append(stack.Pop());
        }

        return postfix.ToString();
    }
}
