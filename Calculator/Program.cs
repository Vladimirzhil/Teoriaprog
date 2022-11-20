using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CALC
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите выражение: ");
                Console.WriteLine(RPN.Calculate(Console.ReadLine()));
            }
        }
    }
    class RPN
    {
        private static bool IsDelimeter(char c)
        {
            return " =".IndexOf(c) != -1;


        }
        private static bool IsOperator(char с)
        {
            return "+-/*()".IndexOf(с) != -1;
        }
        private static byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 2;
                case '*': return 3;
                case '/': return 3;
                default: return 4;
            }
        }
        public static double Calculate(string input)
        {
            string output = ConvertExpression(input);
            double result = ExpressionCounting(output);
            return result;
        }
        private static string ConvertExpression(string input)
        {
            string output = string.Empty;
            Stack<char> operStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    output += Checknumber(input, i);
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        i++;
                        if (i == input.Length) break;
                    }
                    output += " ";
                    i--;
                }
                if (IsOperator(input[i]))
                {
                    output += CheckOpertor(input, i, output, operStack);
                }
            }

            while (operStack.Count > 0)
                output += operStack.Pop() + " ";
            return output;
        }


        private static double ExpressionCounting(string input)
        {

            {
                double result = 0;
                Stack<double> temp = new Stack<double>();
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsDigit(input[i]))
                    {
                        string a = string.Empty;
                        a += Variableentry(a,input,i,temp);
                        i += countI(input, i);
                        temp.Push(double.Parse(a));
                        i--;
                    }
                    else if (IsOperator(input[i]))
                    {
                        result= counting(input, i,result,temp);
                        temp.Push(result);
                    }
                }
                return temp.Peek();
            }

        }

        public static string Checknumber(string input, int i)
        {
            string output = string.Empty;
            while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
            {
                output += input[i];
                i++;
                if (i == input.Length) break;
            }

            return output;
        }
        public static string CheckOpertor(string input, int i, string output, Stack<char> operStack)
        {

            if (input[i] == '(')
                operStack.Push(input[i]);
            else if (input[i] == ')')
            {
                char s = operStack.Pop();
                while (s != '(')
                {
                    output += s.ToString() + ' ';
                    s = operStack.Pop();
                }
            }
            else
            {
                if (operStack.Count > 0 && GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                    output += operStack.Pop().ToString() + " ";
                operStack.Push(char.Parse(input[i].ToString()));
            }
            return output;
        }
        public static string Variableentry(string a,string input ,int i, Stack<double> temp)
        {
            while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
            {
                a += input[i];
                i++;
                if (i == input.Length) break;
            }
            return a;
        }
        public static int countI(string input,int i) 
        {
            while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
            {
                i++;
                if (i == input.Length) break;
            }
            i--;
            return i;
        }
        public static double counting(string input,int i, double result, Stack<double> temp) 
        {
            double a = temp.Pop();
            double b = temp.Pop();
            switch (input[i])
            {
                case '+': result = b + a; break;
                case '-': result = b - a; break;
                case '*': result = b * a; break;
                case '/': result = b / a; break;
            }
            return result;
        }

    }

}
