// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Globalization;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {

        RegexEmailCheck("Rownie@gmail.com");
        RegexEmailCheck("Rownie");
        RegexEmailCheck("@gmail.com");
        RegexEmailCheck("Rownie.com");
        // string input = "abcdef";

        //string  emailInput = "abc@gmail.com";

        //bool validEmail = RegexEmailCheck(input);
        //Console.WriteLine("The value of validEmail is: " + validEmail);

        //validEmail = RegexEmailCheck(emailInput);
        //Console.WriteLine("The value of validEmail is: " + validEmail);
    }
    public static bool RegexEmailCheck(string input)
    {
        // returns true if the input is a valid email
        if (Regex.IsMatch(input, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
        {
            Console.WriteLine("Email ID is valid.");
            return true;
        }
        else
        {
            Console.WriteLine("Email ID is invalid.");
            return false;
        }
        //return Regex.IsMatch(input, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
    }
}