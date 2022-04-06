using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word and I'll tell your if it's a palindrome.");
            string wordGiven = Console.ReadLine();
            char[] wordArray = wordGiven.ToCharArray(); //storing characters of wordGiven into an array
            int wordEnd = wordArray.Length - 1; //grabing length of array for easy index comparision
            int wordStart = 0;
            bool palin = true;

            do
            {
                if (wordGiven[wordStart] == wordGiven[wordEnd])
                {
                    //Console.WriteLine(wordArray[wordEnd]);
                    //Console.WriteLine(wordArray[wordStart]);
                    wordEnd--; //moving to the next index in the array
                    wordStart++;

                }
                else
                {

                    Console.WriteLine("This is not a palindrome");
                    palin = false;
                }
            }
            while (wordEnd > 1 && palin == true);

            if (palin == true)
            {

                Console.WriteLine("This is a palindrome");
            }


        }
    }
}
