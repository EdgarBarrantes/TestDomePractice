using System;

public class Account
{
    [Flags]
    public enum Access
    {
        Writer = 1,
        Editor = 2,
        Owner = 3,
        Delete = 4,
        Publish = 5,
        Submit = 6,
        Comment = 7,
        Modify = 8,
    }
    [FlagsAttribute]
    public enum Writer
    {
        Submit = 6,
        Modify = 8
    }
    [FlagsAttribute]
    public enum Editor
    {
        Delete = 4,
        Publish = 5,
        Comment = 7
    }
    [FlagsAttribute]
    public enum Owner
    {
        Writer = 1,
        Editor = 2
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Access.Writer.HasFlag(Access.Submit)); //Should print: "False"
    }
}