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

            // string userName = Console.ReadLine();
            // Console.Write(userName);
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.Write(age + 10);


            // operator is same as javascript 

            // math is same as js
            // Console.WriteLine(Math.Abs(-10));
            // Console.WriteLine(Math.Ceiling(6.3));
            // Console.WriteLine(Math.Floor(6.3));
            // int a = (int) Math.Pow(10, 2);
            // Console.WriteLine(a);


            // string

            // NOTE: All the prebuild method are in pascal only variables are in camelCase
            string name = "sumit kumarsharma";
            // Console.WriteLine(name.Length);
            // Console.WriteLine("Name is upper case " + name.ToUpper());
            // Console.WriteLine("Name in lower case " + name.ToLower());


            // interpolation;
            string description = $"{name} is very talent person in the world";
            Console.WriteLine(description);

            // indexof 
            // Console.WriteLine(name.IndexOf("e"));

            // substring
            Console.WriteLine(name.Substring(name.IndexOf("a"), 2));

            

        }
    }
}
