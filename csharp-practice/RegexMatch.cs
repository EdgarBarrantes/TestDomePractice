using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool ValidatePin(string pin)
    {
        string pattern = @"(^\d{4}$)|(^\d{6}$)";
        return Regex.IsMatch(pin, pattern);
    }
    // public static void Main(string[] args)
    // {
    //     Console.WriteLine(ValidatePin("1234"));
    //     Console.WriteLine(ValidatePin("12344"));
    //     Console.WriteLine(ValidatePin("123442"));
    // }
}