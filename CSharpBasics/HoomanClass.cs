using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class HoomanClass
    {
        // Attributes
        public string name;
        public int age;
        public bool hasDog;
        public string dogName;

        //Methods

        public void Greeting()
        {
            if (hasDog ==  true)
            {
                Console.WriteLine($"Hello {name}. Nice to meet you. I see you have a dog named {dogName}. Cool name bro. It's nice to see someone at the of age of {age} that has a dog.");
            }
            else
            {
                Console.WriteLine($"What {name}!!! You don't own a dog? Someine {age} years old, should really own a dog.");
            }
        }
    }
}

// ASK ME ABOUT ACCESS MODIFIERS WHEN THE CODE DOES NOT WORK
/// Access Modifiers
/// 1. Public
/// 2. Private
/// 3. Protected
/// 4. Internal
/// 5. Protected Internal
/// 6. Privated Protected