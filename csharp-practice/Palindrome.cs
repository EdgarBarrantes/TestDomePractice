using System;
namespace palindrome {
public class Palindrome {
        public static bool IsPalindrome(string word)
        {
            int length = word.Length;
            word = word.ToLower();
            for (int i = 0; i < length / 2; i++) {
                if (word[i] != word[length - i - 1]) {
                    return false;
                }
            }
            return true;
        }

        // public static void Main(string[] args)
        // {
        //     Console.WriteLine(Palindrome.IsPalindrome("Dog"));
        // }
    }
}

