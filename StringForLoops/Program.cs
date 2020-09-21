using System;

namespace StringForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            string Helloworld = "Hello world";
            Console.WriteLine(Helloworld[0]);
            Console.WriteLine(Helloworld[5]);

            int stringLenght = Helloworld.Length;
            Console.WriteLine($"Your text is {stringLenght} symbols long.");
            char searchCriteria = 'o';
            int counter = 0;

            foreach (char letter in Helloworld)
            {
                if (letter == searchCriteria)
                {
                    counter = counter + 1;
                }

            }
            Console.WriteLine($"There are {counter} Os in your text.");
        }
    }
}
