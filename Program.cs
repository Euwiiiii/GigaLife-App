using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace GigaLifeApp
{   
    class Program
    {
        static GigaLife account = null!;
        static GigaLife info = new GigaLife();
       //  static Arrays array = new Arrays();
        static public List<string> Subscribed = new List<string>();
        static void Main()
        {
            account = new GigaLife();

            Console.WriteLine("GigaLife App");
            Console.WriteLine("Enter your Mobile Number");
            string? userNumber = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string? userPin = Console.ReadLine();

            while (userPin != "0" && userNumber != "0")
            {
                string result = userNumber == account.Number && userPin == account.PIN ? "correct" : "error";

                if (result == "correct")
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Giga Points");
                    Console.WriteLine("2. Home");
                    Console.WriteLine("3. Pasa");
                    Console.WriteLine("4. Account");
                    Console.WriteLine("5. Exit");
                    var userChoice = UserInput();

                    if (userChoice == "5")
                    {
                        Console.WriteLine("Exiting Program..");
                        break;
                    }
                    switch (userChoice)
                    {
                        case "1":
                            PRewards.ReedeemMenu();
                            break;
                        case "2":
                            // POffers.Usage();
                            Usage();
                            Console.WriteLine("         Do you want to check your SMART LOAD OFFERS?");
                            Console.WriteLine("                     1. Yes      2. No");
                            userChoice = UserInput();
                            if (userChoice == "1")
                            {
                                POffers.HomeMenu();
                            }
                            else if (userChoice == "2")
                            {
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid Choice");
                                Console.WriteLine("");
                            }
                            break;
                        case "3":

                            break;
                        case "4":
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Your number and password do not match. Try again.");
                    Console.WriteLine("Enter your Mobile Number");
                    userNumber = Console.ReadLine();
                    Console.WriteLine("Password");
                    userPin = Console.ReadLine();
                }
            }
        }
        private static string UserInput()
        {
            Console.Write("Enter your Choice: ");
            string userChoice = Console.ReadLine() ?? string.Empty;
            return userChoice;
        }
        public static void Usage()
        {
            GigaLife info = new GigaLife();
            Offers[] array = AvailableOffers.ArrayOffers();
            POffers.Confirmation(array, info);

            double updatePoints = PRewards.UpdatedGigaPoints();
            int updateLoad = POffers.UpdatedLoad();


            Console.WriteLine($"Load Balance = P{updateLoad}.00");

            Console.WriteLine($"GigaPoints = {updatePoints}");
            Console.WriteLine("Subcripted to");
            info.DisplaySub();
            /*if (info1.UMagic > info.magicData )
            {
                Console.WriteLine($"Magic Data Balance  = {info1.UMagic} GB");
            }*/
        }


    }
}