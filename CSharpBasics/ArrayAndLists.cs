using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class ArrayAndLists
    {

        public static void MyArrays()
        {
            int[] bowlingScores = new int[10];

            bowlingScores[0] = 92;
            bowlingScores[1] = 300;
            bowlingScores[2] = 12;
            bowlingScores[3] = 6;
            bowlingScores[4] = 402;

            Console.WriteLine(bowlingScores[3]);

            for (int i = 0; i < bowlingScores.Length; i++)
            {
                Console.WriteLine($"Aray number {i} = {bowlingScores[i]}");
            }

            string[] bowlerNames = new string[10];
            bowlerNames[0] = "Gavin";
            bowlerNames[1] = "Ronnie";
            bowlerNames[2] = "Robbie";
            bowlerNames[3] = "Ricky";
            bowlerNames[4] = "Mike";
            bowlerNames[5] = "ColIt";
            bowlerNames[6] = "Now";


            Console.WriteLine(bowlerNames[3]);

            for (int i = 0; i < bowlerNames.Length; i++)
            {
                Console.WriteLine($"Array number {i} = {bowlerNames[i]}");
            }

        }
        public static void StringArrays()
        {
            string[] ninjaNames = { "Ueshiba", "Hitogoroshi", "Kaizen", "Goshin", "Fred" };
            int startAtZero = 0;
            foreach (string Ninja in ninjaNames)
            {
                Console.WriteLine($"Here is another way of writing the array: {startAtZero}: {Ninja}");
                startAtZero++;
            }
        }
        public static void CreatGrid()
        {
            int width = 3;
            int height = 3;
            int[,] myGrid = new int[width, height];
            myGrid[0, 0] = 00;
            myGrid[0, 1] = 01;
            myGrid[0, 2] = 02;
            myGrid[1, 0] = 10;
            myGrid[2, 0] = 20;
            myGrid[2, 1] = 21;
            myGrid[2, 2] = 22;

            for (int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    Console.WriteLine(myGrid[x, y] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
