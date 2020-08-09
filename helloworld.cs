using System;

    class helloworld 
    {
        static void Main() 
        {            
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nHello, {name}. What year were you born?");
            string birthyear = Console.ReadLine();
            int birth = Convert.ToInt32(birthyear); // converting to int
            int age = 2020 - birth;
            Console.WriteLine($"\nYou are or will be {age} years old before the end of 2020, {name}!");
        }

    }
