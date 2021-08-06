using System;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using Microsoft.VisualBasic;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 4;
            int B = 5;
            if (A != B)
            {
                if (A > B)
                    B = A;
                A = B;

                Console.WriteLine($"A = {A} \nB = {B}");
            }
            else if (A == B)
            {
                A = 0;
                B = 0;
                Console.WriteLine($"A = {A} \nB = {B}");
            }

            // второе задание
            int operand1 = Convert.ToInt32(Console.ReadLine());
            int operand2 = Convert.ToInt32(Console.ReadLine());
            string sign = Console.ReadLine();
            //  int result;
            switch (sign)
            {
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if (operand1 > 0 && operand2 == 0)
                    {
                        Console.WriteLine("Введите правильное значение");
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                    }

                    break;
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;


            }

            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number >= 0 && Number <= 14) // 0-14
            {
                Console.WriteLine("[0-14]");
            }
            else if (Number >= 15 && Number <= 35)
            {
                Console.WriteLine("[15-35]");
            }
            else if (Number >= 36 && Number <= 50)
            {
                Console.WriteLine("[36-50]");
            }
            else if (Number >= 50 && Number <= 100)
            {
                Console.WriteLine("[50-100]");
            }
            else
            {
                Console.WriteLine("Uncorrect range");
            }
        }
    }
}