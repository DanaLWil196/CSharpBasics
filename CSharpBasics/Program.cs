using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;
namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Mystring();
            //DataTypes();
            //Console.WriteLine("Enter Number One.");
            //int numberOne = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine($"Your number is {numberOne}");
            ///Console.WriteLine($"You entered: {numberOne}");
            //InputTypes();
            //CastingTypes();
            //myHoomans();
            //myVideos();
            FlowControl.FCIfElse();
        }



        static void myVideos()
        {
            VideoGames DanaL = new VideoGames();
            DanaL.name = "Dana";
            DanaL.hasGames = true;
            DanaL.age = 18;
            DanaL.Greeting();

        }
        static void myHoomans()
        {
            HoomanClass MrSekol = new HoomanClass();
            MrSekol.age = 99;
            MrSekol.dogName = "Mozzy";
            MrSekol.hasDog = true;
            MrSekol.name = "Michael";
            MrSekol.Greeting();
            HoomanClass Gaveeen = new HoomanClass();
            Gaveeen.age = 23;
            Gaveeen.hasDog = false;
            Gaveeen.name = "NotRudiak";
            Gaveeen.Greeting();
        }
        static void Mystring()
        {
            Console.Write("What year were you born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();
            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");
            string myString1 = "This is my first String";
            string theTruth = "Tha last thing a ninja would do is admit to being a ninja.";
            string theLie = "I am not a ninja.";
            Console.WriteLine("This is my String. " + myString1);
            Console.WriteLine($"Here are two truths and a a lie. {theTruth}. {theLie}");
        }
        static void DataTypes()
        {
            int myAge = 99;
            string name = "Bob the Builder";
            bool awesome = true;
            char grade = 'F';  // Chars are single characters. Requires single quotes. 'A'
            float altitude = 90.265141f;  // float requires 'f' at the end..
            double bankBalance = -4000000;
            decimal pi = 3.14159265359M;  // decimal requires M
            //Output
            Console.WriteLine($"myAge = {myAge}.");
            Console.WriteLine($"name = {name}.");
            Console.WriteLine($"bool = {awesome}.");
            Console.WriteLine($"float = {altitude}.");
            Console.WriteLine($"char = {grade}.");
            Console.WriteLine($"double = {bankBalance}.");
            Console.WriteLine($"decimal = {pi}.");
        }
        static void InputTypes()
        {
            //DataTypes();
            Console.WriteLine("Enter Number One");
            //string myName = Console.ReadLine();
            decimal numberOne = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine($"You entered: {numberOne]");
            Console.WriteLine("Enter NumberTwo");
            decimal numberTwo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"You entered {numberOne} & {numberTwo}");
            Console.WriteLine($"Addition: {numberOne} + {numberTwo} = {numberOne + numberTwo}");
            Console.WriteLine($"Subtraction: {numberOne} - {numberTwo} = {numberOne - numberTwo}");
            Console.WriteLine($"Multiplication: {numberOne} * {numberTwo} = {numberOne * numberTwo}");
            Console.WriteLine($"Division: {numberOne} / {numberTwo} = {numberOne / numberTwo}");
            Console.WriteLine($"Modulus: {numberOne} % {numberTwo} = {numberOne % numberTwo}");
            Console.WriteLine($"Increment: The increment of {numberOne++} is {numberOne}");
            Console.WriteLine($"Increment: The increment of {++numberOne} is {numberOne}");
            Console.WriteLine($"numberOne++ is the same as NumberOne = numberOne + 1. See here: {numberOne} is {numberOne = numberOne + 1}");
            Console.WriteLine($"Decrement: The decrement of {numberTwo++} is {numberTwo}");
            Console.WriteLine($"Decrement: The decrement of {numberTwo++} is {numberTwo}");
            decimal centeredPolygonal = ((((numberOne * numberTwo) / 2) * (numberTwo - 1)) + 1);
            Console.WriteLine($"The centered polygona of {numberOne} & {numberTwo} is: {centeredPolygonal}");
        }
        static void CastingTypes()
        {
            double myDouble = 10.5;
            int myInteger = 2;
            myDouble = myDouble + myInteger;
            Console.WriteLine($"Implicit cast: {myDouble}");
            myDouble = (double)7 / myInteger;
            Console.WriteLine($"Explicit cast: {myDouble}");
            char myLetter = (char)65;
            Console.WriteLine($"Cast integer: {myLetter}");
            int myAscii = (int)'A';
            Console.WriteLine($"Cast letter: {myAscii}");
            Console.ReadKey();
        }
    }
}