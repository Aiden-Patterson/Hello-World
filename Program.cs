// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.Write("This is a test to see");
        Console.WriteLine(" how C# works"); 
        Console.Write("What is the first value: ");
        string x = Console.ReadLine();
        Console.Write("What is the second value: ");
        string y = Console.ReadLine();
        Console.WriteLine("The solution to the problem " + x + " + " + y + " is " + (x + y));
        int xVal = Convert.ToInt32(x);
        int yVal = Convert.ToInt32(y);
        Console.WriteLine("Wait that's not right, the solution is " + (xVal + yVal));
    }
  }
}
