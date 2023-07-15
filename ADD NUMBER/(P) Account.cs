using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PAccount
{
    public static void AccountMenu()
    {
        Console.WriteLine("Link more accounts to manage all your numbers");
        Account.DisplayAccountList();
        Console.WriteLine("Do you want to link you other number?");
        Console.WriteLine("1. Confirm           2. Cancel");
        var userChoice = UserInput();
        if (userChoice == "1")
        {
            Console.WriteLine("1. Link Smart (Prepaid, Postpaid, Bro, Signature");
            Console.WriteLine("2. Link TNT");
            Console.WriteLine("3. Link PLDT");
            Console.WriteLine("4. Back");
            userChoice = UserInput();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Add Smart number to easily manage your accounts");
                    string Add = Console.ReadLine() ?? string.Empty;
                    Account.SmartAccount(Add);
                    break;
                case "2":
                    Console.WriteLine("Add TNT number to easily manage your accounts");
                    Add = Console.ReadLine() ?? string.Empty;
                    Account.TNTAccount(Add);
                    break;
                case "3":
                    Console.WriteLine("Add TNT number to easily manage your accounts");
                    Add = Console.ReadLine() ?? string.Empty;
                    Account.PLDTAccount(Add);
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
    private static string UserInput()
    {
        Console.Write("Enter your Choice: ");
        string userChoice = Console.ReadLine() ?? string.Empty;
        return userChoice;
    }

}
