using System;
namespace userInput
{
    public class UserInput
    {
        public class TextInput
        {
            protected string value = "";
            virtual public void Add(char c)
            {
                value += c;
            }
            public string GetValue()
            {
                return value;
            }
        }

        public class NumericInput : TextInput
        {
            override public void Add(char c)
            {
                if (char.IsDigit(c))
                {
                    value += c;
                }
            }
        }
        // public static void Main(string[] args)
        // {
        //     TextInput input = new NumericInput();
        //     input.Add('1');
        //     input.Add('a');
        //     input.Add('0');
        //     Console.WriteLine(input.GetValue());
        // }
    }
}

