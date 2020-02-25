using System;
using PalindromeCheck.Models;

namespace PalindromeCheck
{
    public class Program
    {
        public static void Main()
        {
            Palindrome newPal = new Palindrome("empty");
            Console.WriteLine("Please enter a word with no numbers or special characters");
            string inputWord = Console.ReadLine();
            newPal.Word = inputWord;
            bool result = newPal.CheckPalindrome();
            Console.WriteLine(result);
            
        }
    }
  
}