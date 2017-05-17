using System;

//Joshua Kaluba - 2016-01-30
//A program to check if a string is a palindrome

namespace TestPalindrome
{
	class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word/sentence to determine if it is a palindrome...");
            
			//get input from user
            string userInput = Console.ReadLine();
            
			//remove spaces in case input is a sentence
            userInput = userInput.Replace(" ", string.Empty).Trim();
            
			//reverse user input
            string reversedUserInput = ReverseInput(userInput);


            if (userInput==reversedUserInput)
            {
                //if original input equals the reversed input
                Console.WriteLine("Yes, we have a palindrome.");
            }
            else
            {
                //if input does not match reversed input
                Console.WriteLine("No, not a palindrome.");
            }           

            Console.Read();
        }

        public static string ReverseInput(string userInput)
        {           
            char[] inputArray = userInput.ToCharArray();

            Array.Reverse(inputArray);

            return new string(inputArray);
        }


    }
}
