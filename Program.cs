// See https://aka.ms/new-console-template for more information


// using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // int number1 = 10;
            // int number2 = 10;

            // variable types
            // int, double, string, char, bool
            // use const to avoid reassigning of variable 

            // double num = 10.2D;
            // Console.WriteLine(number1 + number2);
            // Console.WriteLine(num);
            // float explicitNum = 10;
            // int myInt = (int) explicitNum;
            // Console.WriteLine(Convert.ToString(myInt));
            // Console.WriteLine(Convert.ToDouble(myInt));
            // Console.WriteLine(true);

            string userName = Console.ReadLine();
            Console.Write(userName);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write(age + 10);
        }
    }
}
