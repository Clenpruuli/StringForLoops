using System;

namespace Longestname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first name: ");
            string nameOne = Console.ReadLine();
            Console.WriteLine("enter the second name: ");
            string nameTwo = Console.ReadLine();
            int lengthOne = 0;
            int lengthTwo = 0;
            foreach(char letter in nameOne)
            {
                lengthOne = lengthOne + 1;

            }
            foreach (char letter in nameTwo)
            {
                lengthTwo = lengthTwo + 1;

            }


            if(lengthOne > lengthTwo)
            {
                lengthTwo = lengthTwo + 1;

            }else if (lengthOne < lengthTwo)
            {
                Console.WriteLine("Name Two is the longest.");
            } else
            {
                Console.WriteLine("Both name are of the same length");
            }




        }
    }
}
