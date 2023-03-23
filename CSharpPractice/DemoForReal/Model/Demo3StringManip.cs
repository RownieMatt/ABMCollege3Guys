
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public class PhoneNumAndPostalCode
{
    public static void Main(string[] args)
    {

        PhoneNumber("4038952798");
        PostalCode("48953");
        PostalCode("T2A5W7");
    }
    public static void PhoneNumber(string PhNumber)
    {
        string FirstPart = PhNumber.Substring(0, 3);
        string SecondPart = PhNumber.Substring(3, 3);
        string ThirdPart = PhNumber.Substring(6, 4);
        Console.WriteLine("+1 " + "(" + FirstPart + ") - " + SecondPart + " - " + ThirdPart);


    }

    public static void PostalCode(string PSCode)
    {
        int PS = PSCode.Length;
        if (PS == 5)
        {
            Console.WriteLine(PSCode);
        }
        else if (PS == 6)
        {
            string Fpart = PSCode.Substring(0, 3);
            string Spart = PSCode.Substring(3, 3);
            Console.WriteLine(Fpart + " " + Spart);
        }
        else
        {
            Console.WriteLine("Type in a proper Postal Code.");
        }
    }
    static void NoApt(string Address)
    {
        string[] ArrayAddressNU = Address.Split(",");
        Console.WriteLine($"Address - {ArrayAddressNU[0]}\n City - {ArrayAddressNU[1]}\n Province - {ArrayAddressNU[2]} \n Postal Code - {ArrayAddressNU[3]}\n Country - {ArrayAddressNU[4]}\n");
    }
    static void YesApt(string Address)
    {
        char[] multiple = { ',', '-' };
        string[] ArrayAddress = Address.Split((multiple));

        Console.WriteLine($"Unit/Apt - {ArrayAddress[0]}\n Address - {ArrayAddress[1]}\n City - {ArrayAddress[2]}\n Province - {ArrayAddress[3]} \n Postal Code - {ArrayAddress[4]}\n Country - {ArrayAddress[5]}\n");
    }

}