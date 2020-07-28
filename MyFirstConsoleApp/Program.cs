using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int theNumberFive = 5;
            //theNumberFive = 12; -- doesn't work, can't assign a new value to a constant

            //explicit variable declaration, no value required on the right-hand side
            int myFirstInteger; // = int32
            //short = int16
            //long = int64
            myFirstInteger = 12;

            // decimal is good for money, doubles and floats are good for sciencey and mathy stuff
            decimal money = 12.50m;
            double moreDecimalStuff = 12.50d;
            float floatingPoint = 12.50f;

            //implicit variable declaration, type is based on value on the right-hand side
            var myFirstBoolean = true;

            myFirstBoolean = false;

            var myFirstString = "This is a string...";

            //myFirstString = true; -- does not work, variable is still statically typed

            char oneCharacter = 'c';

            //blue text csharp keywords, green is for types defined outside of csharp
            DateTime today = DateTime.Today;

            //string literal: multiple lines are allowed
            var poem = @"Roses are red, 
                       violets are blue, 
                       csharp is great, 
                       and so are you.";


            var name = "Nathan";
            var age = 34;
            //string interpolation, like javascript, but different. :)
            var greeting = $"My name is {name} and I'm {age} years old.";


            //reference types 

            //this is a terrible idea, always use proper types.
            object myNumber = 1;  //boxing
            myNumber = "stuff"; //boxing

            //Creating an Anonymous Type
            var steve = new { Name = "Steve" };

            greeting = $"My name is {steve.Name} and I'm {age} years old.";


            //new array with 10 empty slots
            var names = new string[10];

            names[0] = "Dylan";

            Console.WriteLine(names[0]);

            names[1] = "Todd";
            names[3] = "Anca";

            //this doesn't work because the array stops at the 9th index (zero based)
            //names[10] = "Nathan";

            Console.WriteLine(greeting);

            var shouldExecute = true;
           
            if (!string.IsNullOrEmpty(name)) 
            {
                Console.WriteLine($"{name} was in the name variable.");
            }
           
            switch (oneCharacter)
            {
                case 'a':
                    Console.WriteLine("its the letter a");
                    break;
                case 'c':
                    Console.WriteLine("Duh its c");
                    break;
                default:
                    Console.WriteLine("It wasn't a or c");
                    break;
            }

            for (int i = 0; i < names.Length;  i++)
            {
                if ( i < 3)
                {
                    continue;
                }

                Console.WriteLine($"The current name is {names[i]}");
            }

            foreach (var n in names)
            {
                Console.WriteLine($"The current name is {n}");
            }

            while (true)
            {
                if (DateTime.Now > new DateTime(2020, 07, 27, 19, 24, 15))
                {
                    break;
                }
            }

            
            Console.WriteLine("Please enter your name.");
            var input = Console.ReadLine();

            Console.WriteLine($"Hello, {input}");

            Console.WriteLine("Please enter a comma deparated list of numbers.");
            input = Console.ReadLine();

            var numbers = input.Split(',');
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}