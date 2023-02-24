using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        ValidatePass("123@waeWA.com");
    }

    public static bool ValidatePass(string Password)
    {
        var hasNumber = new Regex(@"[0-9]+");
        var hasUpperChar = new Regex(@"[A-Z]+");
        var hasMiniMaxChars = new Regex(@".{8,15}");
        var hasLowerChar = new Regex(@"[a-z]+");
        var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

        if (!hasLowerChar.IsMatch(Password))
        {
            Console.WriteLine("Password should have at least one lower case letter.");
            return false;
        }
        else if (!hasSymbols.IsMatch(Password))
        {
            Console.WriteLine("Password should have at least one symbol.");
            return false;
        }
        else if (!hasNumber.IsMatch(Password))
        {
            Console.WriteLine("Password should have at least one number.");
            return false;
        }
        else if (!hasUpperChar.IsMatch(Password))
        {
            Console.WriteLine("Password Should have at least one uppercase letter.");
            return false;
        }
        else if (!hasMiniMaxChars.IsMatch(Password))
        {
            Console.WriteLine("Password should be at least minimum 8 characters.");
            return false;
        }
        else
        {
            Console.WriteLine("It is a strong Password.");
            return true;
        }
    }
}


