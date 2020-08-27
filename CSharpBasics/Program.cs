using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mystring();
        }
        static void Mystring()
        {
            Console.Write("What year were you born?");
            int yearBorn = Convert.ToInt32( Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();
            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");
            string myString1 = "This is my first String";
            string theTruth = "Tha last thing a ninja would do is admit to being a ninja.";
            string theLie = "I am not a ninja.";
            Console.WriteLine("This is my String. " + myString1);
            Console.WriteLine($"Here are two truths and a a lie. {theTruth}. {theLie}");
        }
    }
}