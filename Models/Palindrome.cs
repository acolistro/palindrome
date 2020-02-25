using System;

namespace PalindromeCheck.Models
{
    public class Palindrome
    {
        public string Word { get; set; }

        public Palindrome(string word)
        {
            Word = word;
        }

        public bool CheckPalindrome()
        {
            char[] letterArray = Word.ToCharArray();
            int arrayLength = letterArray.Length;
            int countLength = arrayLength / 2;
            bool checker = true;
            int i = 0;
            if (arrayLength % 2 == 0)
            {
                while (checker && i < countLength)
                {
                    if (letterArray[i] == letterArray[arrayLength-i-1])
                    {
                        i++;
                        return true;
                    }
                    else {
                        checker = false;
                    }
                }
            }
            else 
            {
                while (checker && i < (countLength - 1))
                {
                    if (letterArray[i] == letterArray[arrayLength-i-1])
                    {
                        i++;
                        return true;
                    }
                    else {
                        checker = false;
                    }
                }            }
            return checker;
        }

    }
}