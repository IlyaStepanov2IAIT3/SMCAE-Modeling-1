using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilation_of_algebraic_expressions
{
    class Translator
    {
        //    public string exspression { get; private set; }

        //    public Translator(string exspression)
        //    {
        //        this.exspression = exspression;
        //    }

        //    public string ToPostfix(string exspression)
        //    {
        //        string postfix = exspression;
        //        exspression = exspression.Replace("sin", "1");
        //        exspression = exspression.Replace("cos", "2");
        //        exspression = exspression.Replace("tan", "3");
        //        exspression = exspression.Replace("cot", "4");

        //        Stack<char> stack = new Stack<char>();

        //        foreach (char ch in exspression)
        //        {
        //            if (Char.IsLetter(ch))
        //            {
        //                label2.Text += ch;
        //                label1.Text.Remove(0, 1);
        //            }
        //            else if (ch == '(')
        //            {
        //                stack.Push(ch);
        //            }
        //            else if (ch == ')')
        //            {
        //                while (stack.Count > 0 && stack.Peek() != '(')
        //                {
        //                    label2.Text += stack.Pop();
        //                }
        //                stack.Pop();
        //            }
        //        }
        //}
    }
}
