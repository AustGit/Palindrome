using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word and I'll tell your if it's a palindrome.");
            string wordGiven = Console.ReadLine();
            bool isValid = true;

            do
                if (String.IsNullOrEmpty(wordGiven))

                {
                    Console.WriteLine("Please enter a valid word.");
                    isValid = false;
                    wordGiven = Console.ReadLine();

                }
                else
                {
                    isValid = true;
                }
                while (isValid == false);

            char[] wordArray = wordGiven.ToCharArray(); //storing characters of wordGiven into an array
            int wordEnd = wordArray.Length -1; //grabing length of array for easy index comparision
            int wordStart = 0;
            bool palin = true;

            do
            {
                if (wordGiven[wordStart] == wordGiven[wordEnd])
                {
                    Console.WriteLine(wordArray[wordEnd]);
                    Console.WriteLine(wordArray[wordStart]);
                    wordEnd--; //moving to the next index in the array
                    wordStart++;

                }
                else
                {

                    Console.WriteLine("This is not a palindrome");
                    palin = false;
                }
            }
            while (wordEnd > wordArray.Length / 2  && palin == true);



            if (palin == true)
            {

                Console.WriteLine("This is a palindrome");
            }


        }
    }
}
