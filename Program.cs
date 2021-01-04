using System;
using System.Linq;

namespace challenge_palindrome_Saixah
{
    class Program
    {
        static void Main(string[] args)
        {
            if(isPalindrome())
                Console.WriteLine("Is a Palindrom");
            else 
                Console.WriteLine("Not a Palindrome");
        }

        public static bool isPalindrome()
        {
            Console.WriteLine("Please Enter a Word");
            var UserInput = Console.ReadLine();
            var Reversed = new string(UserInput.Reverse().ToArray());
            var isPalindrom = UserInput == Reversed;
            return isPalindrom;
        }
    }
}
