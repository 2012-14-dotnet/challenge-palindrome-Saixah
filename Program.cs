using System;
using System.Linq;

namespace challenge_palindrome_Saixah
{
    class Program
    {
        static void Main(string[] args)
        {
            if(isPalindrome(getUserInput()))
                Console.WriteLine("Is a Palindrom");
            else 
                Console.WriteLine("Not a Palindrome");
        }

        public static bool isPalindrome(string Input)
        {
            var Reversed = new string (Input.Reverse().ToArray());
            var isPalindrom = Input == Reversed;
            return isPalindrom;
        }

        public static string getUserInput()
        {
            Console.WriteLine("Please Enter a Word");
            return Console.ReadLine();
        }
    }
}
