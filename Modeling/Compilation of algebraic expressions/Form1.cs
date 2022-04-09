using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilation_of_algebraic_expressions
{
    public partial class MainWindow : Form
    {
        public string infixExpression { get; set; }
        private string postfixExpression;
        private Stack<char> stack = new Stack<char>();
        private Dictionary<char, int> operations = new Dictionary<char, int>()
        {
            {'(', 0},
            {'+', 1},
            {'-', 1},
            {'1', 1}, // sin
            {'2', 1}, // cos
            {'3', 1}, // tan
            {'4', 1}, // cot
            {'*', 2},
            {'/', 2}
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        public void setInfixLb(string text)
        {
            immutInfixLb.Text = text;
            infixLb.Text = text;
            
            text = funcMaskOn(text);
            infixExpression = text;

            postfixLb.Text = "";
            postfixExpression = "";
        }

        public void setBtnEnabled()
        {
            setBtn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncMaster funcMaster = new FuncMaster(this);
            setBtn.Enabled = false;
            funcMaster.Show();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            infixLb.Text = "";

            foreach (char ch in infixExpression)
            {
                if (Char.IsLetter(ch))
                {
                    postfixExpression += ch;
                }
                else if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfixExpression += stack.Pop();
                    }
                    stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && operations[stack.Peek()] >= operations[ch])
                    {
                        postfixExpression += stack.Pop();
                    }
                    stack.Push(ch);
                }
                infixExpression.Remove(0, 1);
            }

            while (stack.Count > 0)
            {
                postfixExpression += stack.Pop();
            }

            postfixExpression = funcMaskOff(postfixExpression);
            postfixLb.Text = postfixExpression;
        }

        private void TactBtn_Click(object sender, EventArgs e)
        {
            if (infixExpression.Length > 0)
            {
                char ch = infixExpression[0];
                if (Char.IsLetter(ch))
                {
                    postfixExpression += ch;
                }
                else if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfixExpression += stack.Pop();
                    }
                    stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && operations[stack.Peek()] >= operations[ch])
                    {
                        postfixExpression += stack.Pop();
                    }
                    stack.Push(ch);
                }
                infixExpression = infixExpression.Substring(1, infixExpression.Length - 1);
                infixLb.Text = funcMaskOn(infixLb.Text);
                infixLb.Text = infixLb.Text.Substring(1, infixLb.Text.Length - 1);
                infixLb.Text = funcMaskOff(infixLb.Text);
            }
            else
            {
                while (stack.Count > 0)
                {
                    postfixExpression += stack.Pop();
                }
            }
            postfixLb.Text = funcMaskOff(postfixExpression);
        }

        public string funcMaskOn(string expression)
        {
            expression = expression.Replace("sin", "1");
            expression = expression.Replace("cos", "2");
            expression = expression.Replace("tan", "3");
            expression = expression.Replace("cot", "4");
            return expression;
        }
        public string funcMaskOff(string expression)
        {
            expression = expression.Replace("1", "sin");
            expression = expression.Replace("2", "cos");
            expression = expression.Replace("3", "tan");
            expression = expression.Replace("4", "cot");
            return expression;
        }
    }
}
