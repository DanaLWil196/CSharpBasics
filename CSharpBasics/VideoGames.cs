using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class VideoGames
    {
        public string name;
        public int age;
        public bool hasGames;

        public void Greeting()
        {
            if (hasGames == true)
            {
                Console.WriteLine($"Wonderful {name}, good to know that you have some sort of fun hobby. And at the age of {age} that is amazing.");
            }
            else
            {
                Console.WriteLine($"Really {name}, your {age} years old and no video games. What have you been doing with your life?");
            }

        }
    }
}
