using System;
namespace anagram
{
    public class AreAnagrams
    {
        public static bool AreStringsAnagrams(string a, string b)
        {
            var charA = a.ToCharArray();
            var charB = b.ToCharArray();
            Array.Sort(charA);
            Array.Sort(charB);
            a = new string(charA);
            b = new string(charB);
            Console.WriteLine($"{a} {b}");
            if (a == b)
            {
                return true;
            }
            return false;
        }

        // public static void Main(string[] args)
        // {
        //     Console.WriteLine(AreStringsAnagrams("momdad", "dadmom"));
        // }
    }
}