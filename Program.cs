using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


namespace GigaLifeApp
{
    class GigaLife
    {

        // nilagay ko sa class para magamit ko sa buong methods 
        static double ipoints = 100; // initial points
        static int iLoad = 130; // initial load
        static int iSharable = 2000; // sharable
        static int iData = 2; // POWER 149
        static int iMagic = 0; // Para sa magic data lng
        static string? pasaNo = "09496314907";
        static List<string> subcriptedList = new() { "GIGA POWER 149" }; // nilagyan ko sa loob para constant na sya 

        // static string gigaReward;
        static void Main(string[] args)
        {
            string mobileNumber = "09206420898", pinCode = "BSCpE2023";

            Console.WriteLine("GigaLife App");
            Console.WriteLine("Enter your Mobile Number");
            string? userNumber = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string? userPin = Console.ReadLine();

            while (userNumber != "0" & userPin != "0")
            {
                string? result = userNumber == mobileNumber && userPin == pinCode ? "correct" : "error";

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
                        Console.WriteLine("Exiting the program...");
                        break;
                    }
                    MenuChoice(userChoice);
                }
                else
                {
                    Console.WriteLine("Your number and password does not match. Try again.");
                    Console.WriteLine("Enter your Mobile Number");
                    userNumber = Console.ReadLine();
                    Console.WriteLine("Password");
                    userPin = Console.ReadLine();
                }

            }
        }
        public static string MenuChoice(string userChoice)
        {
            int[] usePoints = { 99, 149 }; // para giga points_array 
            int[] loadRequired_1 = { 30, 50, 65, 75, 99, 130, 149, 199, 299, 399, 449, 499, 599, 649, 699, 749, 799, 899 };
            double[] gigaPointsGain_1 = { 0.3, 0.5, 0.65, 0.75, 4.95, 6.5, 7.45, 9.95, 14.95, 19.95, 22.45, 24.95, 29.95, 32.45, 34.95, 37.45, 39.95, 44.95 };
            int[] totalEverydayGB = { 2, 3, 7, 8, 17, 30, 64 };
            int[] additionalGB = { 1, 2, 3, 4, 6, 8, 12, 24, 36, 38, 48 };
            int[] everydayGB = { 1, 2 };
            int[] date = { 1, 3, 7, 30, 90 };
            int[] callText = { 50, 100, 200, 300, 600 };
            int[] magicGB = { 2, 6, 24, 36, 48 };
            int[] allnet = { 100, 500, 1000, 2000, 4000, 6000 };
            {
                switch (userChoice)
                {
                    case "1": // For GigaPoints
                        Console.WriteLine($"GigaPoints = {ipoints}");
                        Console.WriteLine("You can use your points to Redeem Rewards");
                        Console.WriteLine("MOST POPULAR REWARDS");
                        Console.WriteLine("1. GIGA VIDEO 99 (99 points)");
                        Console.WriteLine("2. GIGA STORIES 99 (99 points");
                        Console.WriteLine("3. GIGA POWER 149 (149 points)");
                        Console.WriteLine("4. Other Items");
                        userChoice = UserInput();

                        switch (userChoice)
                        {
                            case "1":
                                RedeemRewards("GIGA VIDEO - 99 points", usePoints[0], subcriptedList);
                                break;
                            case "2":
                                RedeemRewards("GIGA STORIES - 99 points", usePoints[0], subcriptedList);
                                break;
                            case "3":
                                RedeemRewards("GIGA POWER - 149 points", usePoints[1], subcriptedList);
                                break;
                            case "4":
                                Console.WriteLine("1. ALLNET  99 (99 points)");
                                Console.WriteLine("2. MAGIC DATA 99 (99 points");
                                Console.WriteLine("3. ALLDATA 99 (99 points)");
                                userChoice = UserInput();

                                switch (userChoice)
                                {
                                    case "1":
                                        RedeemRewards("ALLNET - 99 points", usePoints[0], subcriptedList);
                                        break;
                                    case "2":
                                        RedeemRewards("MAGIC DATA - 99 points", usePoints[0], subcriptedList);
                                        break;
                                    case "3":
                                        RedeemRewards("ALLDATA - 99 points", usePoints[0], subcriptedList);
                                        break;
                                }
                                break;
                        }
                        break;
                    case "2": // Home                        
                        Balance();
                        Console.WriteLine("         Do you want to check your SMART LOAD OFFERS?");
                        Console.WriteLine("                     1. Yes      2. No");
                        userChoice = UserInput();
                        switch (userChoice)
                        {
                            case "1":
                                Console.WriteLine("1. DON'T MISS OUT!");
                                Console.WriteLine("2. DOUBLE GIGA +");
                                Console.WriteLine("3. GIGA EVERYDAY");
                                Console.WriteLine("4. POWER ALL");
                                Console.WriteLine("5. ALL DATA");
                                Console.WriteLine("6. ALLNET");
                                Console.WriteLine("7. Exit");
                                userChoice = UserInput();

                                while (userChoice != "7")
                                {
                                    switch (userChoice)
                                    {
                                        case "1": // DONT'T MISS OUT!
                                            Console.WriteLine("DON'T MISS OUT!");
                                            Console.WriteLine("1. DOUBLE GIGA+");
                                            Console.WriteLine("2. MAGIC DATA+"); // WALA PA ITO
                                            Console.WriteLine("3. Exit");
                                            userChoice = UserInput();
                                            while (userChoice != "3")
                                            {
                                                switch (userChoice)
                                                {
                                                    case "1": // DOULE GIGA+
                                                        Console.WriteLine("DOUBLE GIGA+");
                                                        Console.WriteLine("1. DOUBLE GIGA VIDEO+ 130");
                                                        Console.WriteLine("2. DOUBLE GIGA VIDEO+ 399");
                                                        Console.WriteLine("3. DOUBLE GIGA STORIES+ 130");
                                                        Console.WriteLine("4. DOUBLE GIGA STORIES+ 399");
                                                        Console.WriteLine("5. Back");
                                                        userChoice = UserInput();
                                                        switch (userChoice)
                                                        {
                                                            case "1": //DOUBLE GIGA VIDEO+ 130
                                                                AcquireVideoPlus("DOUBLE GIGA VIDEO+ 130", "5", loadRequired_1[5], totalEverydayGB[4], everydayGB[1], gigaPointsGain_1[5], additionalGB[2], date[1]);
                                                                break;
                                                            case "2"://DOUBLE GIGA VIDEO+ 399
                                                                AcquireVideoPlus("DOUBLE GIGA VIDEO+ 399", "5", loadRequired_1[9], totalEverydayGB[6], everydayGB[1], gigaPointsGain_1[9], additionalGB[3], date[2]);
                                                                break;
                                                            case "3": //DOUBLE GIGA STORIES+ 130
                                                                AcquireStoriesPlus("DOUBLE GIGA STORIES+ 130", "5", loadRequired_1[5], totalEverydayGB[4], everydayGB[1], gigaPointsGain_1[5], additionalGB[2], date[1]);
                                                                break;
                                                            case "4"://DOUBLE GIGA STORIES+ 399
                                                                AcquireStoriesPlus("DOUBLE GIGA STORIES+ 399", "5", loadRequired_1[9], totalEverydayGB[6], everydayGB[1], gigaPointsGain_1[9], additionalGB[2], date[2]);
                                                                break;
                                                        }
                                                        break;
                                                    case "2":// DOUBLE MAGIIC DATA+
                                                        Console.WriteLine("MAGIC DATA+");
                                                        Console.WriteLine("1. MAGIC DATA+ 499");
                                                        Console.WriteLine("2. MAGIC DATA+ 749");
                                                        Console.WriteLine("3. Back");
                                                        userChoice = UserInput();
                                                        switch (userChoice)
                                                        {
                                                            case "1":
                                                                AcquireMagicPlus("MAGIC DATA+ 499", "5", loadRequired_1[11], callText[2], gigaPointsGain_1[11], magicGB[2]);
                                                                break;
                                                            case "2":
                                                                AcquireMagicPlus("MAGIC DATA+ 749", "5", loadRequired_1[15], callText[4], gigaPointsGain_1[15], magicGB[4]);
                                                                break;
                                                        }
                                                        break;
                                                }
                                                break;
                                            }
                                            break; // DONT'T MISS OUT!                                       
                                        case "2": // DOUBLE GIGA+
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("NEW & IMPROVED DOUBLE GIGA+");
                                            Console.WriteLine("WITH UNLI ALLNET CALSS & TEXTS");
                                            Console.WriteLine("2 GB GIGA EVERY DAY");
                                            Console.WriteLine("1. VIDEO");
                                            Console.WriteLine("2. STORIES");
                                            Console.WriteLine("3. Exit");
                                            userChoice = UserInput();
                                            switch (userChoice)
                                            {
                                                case "1": //VIDEOS
                                                    Console.WriteLine("1. DOUBLE GIGA VIDEO+ 65");
                                                    Console.WriteLine("2. DOUBLE GIGA VIDEO+ 130");
                                                    Console.WriteLine("3. DOUBLE GIGA VIDEO+ 399");
                                                    Console.WriteLine("4. Exit");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireVideoPlus("DOUBLE GIGA VIDEO+ 65", "5", loadRequired_1[2], totalEverydayGB[3], everydayGB[1], gigaPointsGain_1[2], additionalGB[1], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireVideoPlus("DOUBLE GIGA VIDEO+ 130", "5", loadRequired_1[5], totalEverydayGB[4], everydayGB[1], gigaPointsGain_1[5], additionalGB[2], date[0]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireVideoPlus("DOUBLE GIGA VIDEO+ 399", "5", loadRequired_1[9], totalEverydayGB[6], everydayGB[3], gigaPointsGain_1[9], additionalGB[3], date[1]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break;
                                                case "2": // STORIES
                                                    Console.WriteLine("1. DOUBLE GIGA STORIES+ 65");
                                                    Console.WriteLine("2. DOUBLE GIGA STORIES+ 130");
                                                    Console.WriteLine("3. DOUBLE GIGA STORIES+ 399");
                                                    Console.WriteLine("4. Exit");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireStoriesPlus("DOUBLE GIGA STORIES+ 65", "1", loadRequired_1[2], totalEverydayGB[3], everydayGB[1], gigaPointsGain_1[2], additionalGB[1], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireStoriesPlus("DOUBLE GIGA STORIES+ 130", "5", loadRequired_1[5], totalEverydayGB[4], everydayGB[1], gigaPointsGain_1[5], additionalGB[2], date[0]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireStoriesPlus("DOUBLE GIGA STORIES+ 399", "5", loadRequired_1[9], totalEverydayGB[6], everydayGB[1], gigaPointsGain_1[9], additionalGB[3], date[1]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break;
                                            }
                                            break;// Double Giga+
                                        case "3": // Giga Everyday                                           
                                            Console.WriteLine("GIGA EVERYDAY");
                                            Console.WriteLine("1. POWER");
                                            Console.WriteLine("2. POWER+");
                                            Console.WriteLine("3. VIDEO");
                                            Console.WriteLine("4. VIDEO+");
                                            Console.WriteLine("5. STORIES");
                                            Console.WriteLine("6. STORIES+");
                                            Console.WriteLine("7. GAMES-1");
                                            Console.WriteLine("8. GAMES-2");
                                            Console.WriteLine("9. Exit");
                                            userChoice = UserInput();
                                            switch (userChoice)
                                            {
                                                case "1":// Power
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("POWER EVERy DAY");
                                                    Console.WriteLine("2GB POWER EVERDAY FOR ALL SITE & APPS");
                                                    Console.WriteLine("                +Shareable Data");
                                                    Console.WriteLine("1. 3 Days (3GB)        P75");
                                                    Console.WriteLine("2. 7 Days (6GB)       P149");
                                                    Console.WriteLine("3. 30 Days (24GB)     P499");
                                                    Console.WriteLine("4. 30 Days (36GB)     P599");
                                                    Console.WriteLine("5. 30 Days (48GB)     P699");
                                                    Console.WriteLine("6. Back");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquirePower("GIGA POWER 75", "1%", loadRequired_1[3], everydayGB[1], gigaPointsGain_1[3], additionalGB[1], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquirePower("GIGA POWER 149", "5%", loadRequired_1[6], everydayGB[1], gigaPointsGain_1[6], additionalGB[4], date[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquirePower("GIGA POWER 499", "5%", loadRequired_1[11], everydayGB[2], gigaPointsGain_1[11], additionalGB[7], date[2]);
                                                    }
                                                    else if (userChoice == "4")
                                                    {
                                                        AcquirePower("GIGA POWER 599", "5%", loadRequired_1[12], everydayGB[1], gigaPointsGain_1[12], additionalGB[8], date[2]);
                                                    }
                                                    else if (userChoice == "5")
                                                    {
                                                        AcquirePower("GIGA POWER 699", "5%", loadRequired_1[14], everydayGB[2], gigaPointsGain_1[14], additionalGB[9], date[2]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break; // Power
                                                case "2": // Power+
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("POWER+ EVERYDAY");
                                                    Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITES & APPS");
                                                    Console.WriteLine("                 +Shareable Data\n             +UNLI ALLNET Calls & Texts");
                                                    Console.WriteLine("1. 3 Days (2GB)        P99");
                                                    Console.WriteLine("2. 7 Days (6GB)       P199");
                                                    Console.WriteLine("3. 30 Days (24GB)     P699");
                                                    Console.WriteLine("4. 30 Days (36GB)     P799");
                                                    Console.WriteLine("5. 30 Days (48GB)     P899");
                                                    Console.WriteLine("6. Back");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquirePowerPlus("GIGA POWER+ 99", loadRequired_1[4], everydayGB[1], gigaPointsGain_1[4], additionalGB[1], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquirePowerPlus("GIGA POWER+ 199", loadRequired_1[7], everydayGB[1], gigaPointsGain_1[7], additionalGB[4], date[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquirePowerPlus("GIGA POWER+ 699", loadRequired_1[14], everydayGB[1], gigaPointsGain_1[13], additionalGB[7], date[2]);
                                                    }
                                                    else if (userChoice == "4")
                                                    {
                                                        AcquirePowerPlus("GIGA POWER+ 799", loadRequired_1[16], everydayGB[1], gigaPointsGain_1[16], additionalGB[8], date[2]);
                                                    }
                                                    else if (userChoice == "5")
                                                    {
                                                        AcquirePowerPlus("GIGA POWER+ 899", loadRequired_1[17], everydayGB[1], gigaPointsGain_1[17], additionalGB[9], date[2]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break;// power+
                                                case "3": // video
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("VIDEO EVERYDAY");
                                                    Console.WriteLine("1GB VIDEO EVERY DAY");
                                                    Console.WriteLine("1. 3 Days (2GB)        P50");
                                                    Console.WriteLine("2. 7 Days (6GB)        P99");
                                                    Console.WriteLine("3. 30 Days (24GB)     P299");
                                                    Console.WriteLine("4. Back");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireVideo("GIGA VIDEO 50", "1", " + Unli Allnet Texts", loadRequired_1[1], everydayGB[0], gigaPointsGain_1[1], additionalGB[0], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireVideo("GIGA VIDEO 99", "5", "", loadRequired_1[4], everydayGB[0], gigaPointsGain_1[4], additionalGB[1], date[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireVideo("GIGA VIDEO 299", "5", "", loadRequired_1[8], everydayGB[0], gigaPointsGain_1[8], additionalGB[3], date[2]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break; // Video
                                                case "4": // video+
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("VIDEO+ EVERYDAY");
                                                    Console.WriteLine("1GB VIDEO EVERY DAY");
                                                    Console.WriteLine("+Unli Allnet Calls & Texts");
                                                    Console.WriteLine("1. 3 Days (1GB)         P75");
                                                    Console.WriteLine("2. 7 Days (2GB)        P149");
                                                    Console.WriteLine("3. 30 Days (4GB)       P449");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireVideoPlus("GIGA VIDEO+ 75", "1", loadRequired_1[3], totalEverydayGB[1], everydayGB[0], gigaPointsGain_1[3], additionalGB[0], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireVideoPlus("GIGA VIDEO+ 149", "5", loadRequired_1[6], totalEverydayGB[2], everydayGB[0], gigaPointsGain_1[6], additionalGB[1], date[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireVideoPlus("GIGA VIDEO+ 449", "5", loadRequired_1[10], totalEverydayGB[5], everydayGB[0], gigaPointsGain_1[10], additionalGB[3], date[2]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break;// video+
                                                case "5":// stories
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("STORIES EVERYDAY");
                                                    Console.WriteLine("1GB STORIES EVERY DAY");
                                                    Console.WriteLine("1. 3 Days (1GB)         P50");
                                                    Console.WriteLine("2. 7 Days (2GB)         P99");
                                                    Console.WriteLine("3. 30 Days (4GB)       P299");
                                                    Console.WriteLine("4. Back");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireStories("GIGA STORIES 50", "1", loadRequired_1[1], everydayGB[0], totalEverydayGB[1], gigaPointsGain_1[1], additionalGB[0], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireStories("GIGA STORIES 99", "5", loadRequired_1[4], everydayGB[0], totalEverydayGB[2], gigaPointsGain_1[4], additionalGB[1], date[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireStories("GIGA STORIES 299", "5", loadRequired_1[8], everydayGB[0], totalEverydayGB[3], gigaPointsGain_1[8], additionalGB[3], date[2]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break; // stories
                                                case "6": // stories+
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("STORIES+ EVERYDAY");
                                                    Console.WriteLine("1GB STORIES+ EVERY DAY");
                                                    Console.WriteLine("+ Unli Allnet Calls & Texts");
                                                    Console.WriteLine("1. 3 Days (1GB)          P75");
                                                    Console.WriteLine("2. 7 Days (2GB)         P149");
                                                    Console.WriteLine("3. 30 Days (4GB)        P499");
                                                    Console.WriteLine("4. Back");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireStoriesPlus("DOUBLE GIGA STORIES+ 75", "1", loadRequired_1[3], totalEverydayGB[1], everydayGB[0], gigaPointsGain_1[3], additionalGB[0], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireStoriesPlus("DOUBLE GIGA STORIES+ 149", "5", loadRequired_1[6], totalEverydayGB[2], everydayGB[0], gigaPointsGain_1[6], additionalGB[1], date[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireStoriesPlus("DOUBLE GIGA STORIES+ 449", "5", loadRequired_1[10], totalEverydayGB[5], everydayGB[0], gigaPointsGain_1[10], additionalGB[3], date[2]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break; // stories+
                                                case "7": // game-1
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("GAMES-1 EVERYDAY");
                                                    Console.WriteLine("1GB GAME EVERY DAY");
                                                    Console.WriteLine("+ Free Giga Arena Tickets");
                                                    Console.WriteLine("1. 3 Days (1GB)          P50");
                                                    Console.WriteLine("2. 7 Days (2GB)          P99");
                                                    Console.WriteLine("3. 30 Days (4GB)        P299");
                                                    Console.WriteLine("4. Back");
                                                    userChoice = UserInput();
                                                    string games = "PUBG Mobile, ML, CoC,\nAoV, Clash Royale, FB Gaming, Giga Arena";
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireGames("GIGA GAMES-1 50", games, "", "1", loadRequired_1[1], everydayGB[0], gigaPointsGain_1[1], additionalGB[0], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireGames("GIGA GAMES-1 99", games, "+ FREE 1 Giga Arena Ticket", "5", loadRequired_1[4], everydayGB[0], gigaPointsGain_1[4], additionalGB[1], date[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireGames("GIGA GAMES-1 299", games, "+ FREE 3 Giga Arena Ticket", "5", loadRequired_1[8], everydayGB[0], gigaPointsGain_1[8], additionalGB[3], date[2]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break; // game-1
                                                case "8": // game-2
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("GAMES-1 EVERYDAY");
                                                    Console.WriteLine("1GB GAME EVERY DAY");
                                                    Console.WriteLine("+ Free Giga Arena Tickets");
                                                    Console.WriteLine("1. 3 Days (1GB)          P50");
                                                    Console.WriteLine("2. 7 Days (2GB)          P99");
                                                    Console.WriteLine("3. 30 Days (4GB)        P299");
                                                    Console.WriteLine("4. Back");
                                                    userChoice = UserInput();
                                                    games = "Wild Rift, Call of Duty, Ml\nFB Gaming, Giga Arena";
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireGames("GIGA GAMES-2 50", games, "", "1", loadRequired_1[1], everydayGB[0], gigaPointsGain_1[1], additionalGB[0], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireGames("GIGA GAMES-2 99", games, "+ FREE 1 Giga Arena Ticket", "5", loadRequired_1[4], everydayGB[0], gigaPointsGain_1[4], additionalGB[1], date[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireGames("GIGA GAMES-2 299", games, "+ FREE 3 Giga Arena Ticket", "5", loadRequired_1[8], everydayGB[0], gigaPointsGain_1[8], additionalGB[3], date[2]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break;// game-2
                                            }
                                            break;// Giga Everyday
                                        case "4": // PowerALL
                                            Console.WriteLine("Up to 5x GigaPoints");
                                            Console.WriteLine("New");
                                            Console.WriteLine("    POWERALL");
                                            Console.WriteLine("with FREE UNLI TikTok EVERY DAY\n  + Shareable Data & Unli Allnet Texts");
                                            Console.WriteLine("1. 7 Days (8GB)           P99");
                                            Console.WriteLine("2. 7 Days (12GB)         P149");
                                            Console.WriteLine("3. Back");
                                            userChoice = UserInput();
                                            switch (userChoice)
                                            {
                                                case "1":
                                                    AcquirePowerAll("POWER ALL 99", "5", "", loadRequired_1[4], gigaPointsGain_1[4], additionalGB[5], date[1]);
                                                    break;
                                                case "2":
                                                    AcquirePowerAll("POWER ALL 149", "5", " & Allnet Calls", loadRequired_1[6], gigaPointsGain_1[4], additionalGB[6], date[1]);
                                                    break;
                                            }
                                            break; // powerAll
                                        case "5": // AllData
                                            Console.WriteLine("Up to 5x GigaPoints");
                                            Console.WriteLine("ALL Data Offers");
                                            Console.WriteLine("1. ALL DATA");
                                            Console.WriteLine("2. ALl DATA+");
                                            Console.WriteLine("3. MAGIC DATA");
                                            Console.WriteLine("4. MAGIC DATA+");
                                            Console.WriteLine("5. UNLI 5G DATA");
                                            Console.WriteLine("6. Back");
                                            userChoice = UserInput();
                                            switch (userChoice)
                                            {
                                                case "1": //All data 
                                                    Console.WriteLine(" Up to 5x GigaPoints");
                                                    Console.WriteLine("1. 3 Days (2G)               P50");
                                                    Console.WriteLine("2. 7 Days (6GB)              P99");
                                                    Console.WriteLine("3. 30 Days (24GB)            P299");
                                                    Console.WriteLine("4. 30 Days (36GB)            P399");
                                                    Console.WriteLine("5. 30 Days (48GB)            P499");
                                                    Console.WriteLine("6. Back");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireAllData("ALL DATA 50", "1", loadRequired_1[1], gigaPointsGain_1[1], additionalGB[1], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireAllData("ALL DATA 99", "5", loadRequired_1[4], gigaPointsGain_1[4], additionalGB[4], date[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireAllData("ALL DATA 299", "5", loadRequired_1[8], gigaPointsGain_1[8], additionalGB[7], date[2]);
                                                    }
                                                    else if (userChoice == "4")
                                                    {
                                                        AcquireAllData("ALL DATA 399", "5", loadRequired_1[9], gigaPointsGain_1[9], additionalGB[8], date[2]);
                                                    }
                                                    else if (userChoice == "5")
                                                    {
                                                        AcquireAllData("ALL DATA 499", "5", loadRequired_1[11], gigaPointsGain_1[11], additionalGB[11], date[2]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break; // all data
                                                case "2":// alldata+
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("All Data+");
                                                    Console.WriteLine("SHAREABLE DATA FOR ALL SITES");
                                                    Console.WriteLine("       + Unli Allnet Calls & Texts");
                                                    Console.WriteLine("1. 3 Days (2GB)              P75");
                                                    Console.WriteLine("2. 7 Days (6GB)              P149");
                                                    Console.WriteLine("3. 30 Days (24GB)            P499");
                                                    Console.WriteLine("4. 30 Days (36GB)            P599");
                                                    Console.WriteLine("5. 30 Days (48GB)            P699");
                                                    Console.WriteLine("6. Back");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireAllData("ALL DATA 75", "1", loadRequired_1[3], gigaPointsGain_1[3], additionalGB[1], date[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireAllData("ALL DATA 149", "5", loadRequired_1[6], gigaPointsGain_1[6], additionalGB[4], date[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireAllData("ALL DATA 499", "5", loadRequired_1[11], gigaPointsGain_1[11], additionalGB[7], date[2]);
                                                    }
                                                    else if (userChoice == "4")
                                                    {
                                                        AcquireAllData("ALL DATA 599", "5", loadRequired_1[12], gigaPointsGain_1[12], additionalGB[8], date[2]);
                                                    }
                                                    else if (userChoice == "5")
                                                    {
                                                        AcquireAllData("ALL DATA 699", "5", loadRequired_1[14], gigaPointsGain_1[14], additionalGB[10], date[2]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break; // alldata+
                                                case "3": // Magic data
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("MAGIC DATA");
                                                    Console.WriteLine("MAGIC DATA (NO EXPIRY)");
                                                    Console.WriteLine("    FOR ALL SITES");
                                                    Console.WriteLine("1. No Expiry (2GB)              P99");
                                                    Console.WriteLine("2. No Expiry (6GB)              P199");
                                                    Console.WriteLine("3. No Expiry (24GB)             P399");
                                                    Console.WriteLine("4. No Expiry (36GB)             P499");
                                                    Console.WriteLine("5. No Expiry (48GB)             P599");
                                                    Console.WriteLine("6. Back");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireMagic("MAGIC DATA 99", "5", loadRequired_1[4], gigaPointsGain_1[4], magicGB[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireMagic("MAGIC DATA 199", "5", loadRequired_1[7], gigaPointsGain_1[7], magicGB[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireMagic("MAGIC DATA 399", "5", loadRequired_1[9], gigaPointsGain_1[9], magicGB[2]);
                                                    }
                                                    else if (userChoice == "4")
                                                    {
                                                        AcquireMagic("MAGIC DATA 499", "5", loadRequired_1[11], gigaPointsGain_1[11], magicGB[3]);
                                                    }
                                                    else if (userChoice == "5")
                                                    {
                                                        AcquireMagic("MAGIC DATA 599", "5", loadRequired_1[12], gigaPointsGain_1[12], magicGB[4]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break; // magicdata
                                                case "4":
                                                    Console.WriteLine("NEW & IMPROVED");
                                                    Console.WriteLine("Magic Data+");
                                                    Console.WriteLine("MAGIC DATA WITH CALLS & TEXTS");
                                                    Console.WriteLine("      WHICH NEVER EXPIRE");
                                                    Console.WriteLine("1. No Expiry (2GB + 50 MINS & TEXTS)              P149");
                                                    Console.WriteLine("2. No Expiry (6GB + 100 MINS & TEXTS)             P299");
                                                    Console.WriteLine("3. No Expiry (24GB + 200 MINS & TEXTS)            P499");
                                                    Console.WriteLine("4. No Expiry (36GB + 300 MINS & TEXTS)            P649");
                                                    Console.WriteLine("5. No Expiry (48GB + 600 MINS & TEXTS)            P749");
                                                    Console.WriteLine("6. Back");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        AcquireMagicPlus("MAGIC DATA+ 149", "5", loadRequired_1[6], callText[0], gigaPointsGain_1[6], magicGB[0]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        AcquireMagicPlus("MAGIC DATA+ 299", "5", loadRequired_1[8], callText[1], gigaPointsGain_1[8], magicGB[1]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        AcquireMagicPlus("MAGIC DATA+ 499", "5", loadRequired_1[11], callText[2], gigaPointsGain_1[11], magicGB[2]);
                                                    }
                                                    else if (userChoice == "4")
                                                    {
                                                        AcquireMagicPlus("MAGIC DATA+ 649", "5", loadRequired_1[13], callText[3], gigaPointsGain_1[13], magicGB[3]);
                                                    }
                                                    else if (userChoice == "5")
                                                    {
                                                        AcquireMagicPlus("MAGIC DATA+ 749", "5", loadRequired_1[15], callText[4], gigaPointsGain_1[15], magicGB[4]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break;
                                                case "5":
                                                    Console.WriteLine("Up to 5x GigaPoints");
                                                    Console.WriteLine("           Unli 5G Data");
                                                    Console.WriteLine("Exclusiively for 5G Certified Devices");
                                                    Console.WriteLine("        in 5G Exlusive Location");
                                                    Console.WriteLine("1. 7 Days Unli 5G (3 GB Non-5G)                P299");
                                                    Console.WriteLine("2. 30 Days Unli 5G (12 GB Non-5G)              P599");
                                                    Console.WriteLine("3. 30 Days Unli 5G (24 GB Non-5G)              P799");
                                                    Console.WriteLine("4. Exit");
                                                    userChoice = UserInput();
                                                    if (userChoice == "1")
                                                    {
                                                        Acquire_5G("UNLI 5G DATA 299", loadRequired_1[8], gigaPointsGain_1[8], date[1], additionalGB[2]);
                                                    }
                                                    else if (userChoice == "2")
                                                    {
                                                        Acquire_5G("UNLI 5G DATA 599", loadRequired_1[12], gigaPointsGain_1[12], date[2], additionalGB[7]);
                                                    }
                                                    else if (userChoice == "3")
                                                    {
                                                        Acquire_5G("UNLI 5G DATA 799", loadRequired_1[16], gigaPointsGain_1[16], date[2], additionalGB[8]);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                    break;
                                            }
                                            break; // Alldata
                                        case "6": // Allnet
                                            Console.WriteLine("Up to 5x GigaPoints");
                                            Console.WriteLine("ALLNET");
                                            Console.WriteLine("Unli Allnet Calls & Texts");
                                            Console.WriteLine("1. 1 Day (100 MB)         P30");
                                            Console.WriteLine("2. 3 Days (500 MB)        P50");
                                            Console.WriteLine("3. 7 Days (1 GB)          P99");
                                            Console.WriteLine("4. 30 Days (2 GB)         P299");
                                            Console.WriteLine("5. 60 Days (4 GB)         P499");
                                            Console.WriteLine("6. 90 Days (6 GB)         P599");
                                            Console.WriteLine("7. Back");
                                            userChoice = UserInput();
                                            if (userChoice == "1")
                                            {
                                                AcquireAllNet("ALL NET 30", "1", loadRequired_1[0], gigaPointsGain_1[0], allnet[0], "MB", date[0]);
                                            }
                                            else if (userChoice == "2")
                                            {
                                                AcquireAllNet("ALL NET 50", "1", loadRequired_1[1], gigaPointsGain_1[1], allnet[1], "MB", date[1]);
                                            }
                                            else if (userChoice == "3")
                                            {
                                                AcquireAllNet("ALL NET 99", "5", loadRequired_1[4], gigaPointsGain_1[4], allnet[2], "GB", date[2]);
                                            }
                                            else if (userChoice == "4")
                                            {
                                                AcquireAllNet("ALL NET 299", "5", loadRequired_1[8], gigaPointsGain_1[8], allnet[3], "GB", date[3]);
                                            }
                                            else if (userChoice == "5")
                                            {
                                                AcquireAllNet("ALL NET 499", "5", loadRequired_1[10], gigaPointsGain_1[10], allnet[4], "GB", date[3]);
                                            }
                                            else if (userChoice == "6")
                                            {
                                                AcquireAllNet("ALL NET 599", "5", loadRequired_1[12], gigaPointsGain_1[12], allnet[5], "GB", date[4]);
                                            }
                                            else
                                            {
                                                break;
                                            }
                                            break; //Allnet
                                    }
                                    break;
                                }
                                break;
                        }
                        break;// For Home
                    case "3": // PASA                       
                        Console.WriteLine("Pasa");
                        Console.WriteLine("Enter a mobile number ");
                        Console.WriteLine("0 to exit");
                        string? userInput = Console.ReadLine();

                        while (userInput != "0")
                        {
                            string?
                                result = pasaNo == userInput ? "correct" : "incorrect";
                            if (result == "correct")
                            {
                                Console.WriteLine("Do you want to continue?");
                                Console.WriteLine("1. Yes      2. Exit");
                                userChoice = UserInput();
                                if (userChoice == "1")
                                {
                                    switch (userChoice)
                                    {
                                        case "1":
                                            Console.WriteLine("1. Pasa Load");
                                            Console.WriteLine("2. Pasa Points");
                                            Console.WriteLine("3. Pasa Data");
                                            Console.WriteLine("5. Back");
                                            userChoice = UserInput();
                                            switch (userChoice)
                                            {
                                                case "1":
                                                    Console.WriteLine("Pasa Load");
                                                    Console.WriteLine("CURRENT LOAD BALANCE = P" + iLoad);
                                                    Console.WriteLine("Select Amount");
                                                    Console.WriteLine("1. P50.00");
                                                    Console.WriteLine("2. P100.00");
                                                    Console.WriteLine("3. P200.00");
                                                    Console.WriteLine("4. P300.00");
                                                    Console.WriteLine("5. P500.00");
                                                    Console.WriteLine("6. P1,000.00");
                                                    Console.WriteLine("7. Back");
                                                    userChoice = UserInput();
                                                    int[] load = { 50, 100, 200, 300, 500, 1000 };
                                                    switch (userChoice)
                                                    {
                                                        case "1":
                                                            PasaLoad("50.00 Load", load[0]);
                                                            break;
                                                        case "2":
                                                            PasaLoad("100.00 Load", load[1]);
                                                            break;
                                                        case "3":
                                                            PasaLoad("200.00 Load", load[2]);
                                                            break;
                                                        case "4":
                                                            PasaLoad("300.00 Load", load[3]);
                                                            break;
                                                        case "5":
                                                            PasaLoad("500.00 Load", load[4]);
                                                            break;
                                                        case "6":
                                                            PasaLoad("1000.00 Load", load[5]);
                                                            break;
                                                    }
                                                    break;
                                                case "2":
                                                    Console.WriteLine("Pasa Points");
                                                    Console.WriteLine($"CURRECTN GIGA POINTS = {ipoints}");
                                                    Console.WriteLine("Select Points");
                                                    Console.WriteLine("1. 5 points");
                                                    Console.WriteLine("2. 10 points");
                                                    Console.WriteLine("3. 20 points");
                                                    Console.WriteLine("4. 30 points");
                                                    Console.WriteLine("5. 50 points");
                                                    Console.WriteLine("6. 100 points");
                                                    Console.WriteLine("7. Back");
                                                    userChoice = UserInput();
                                                    int[] points = { 5, 10, 20, 30, 50, 100 };
                                                    switch (userChoice)
                                                    {
                                                        case "1":
                                                            PasaPoints("5 GigaPoints", points[0]);
                                                            break;
                                                        case "2":
                                                            PasaPoints("10 GigaPoints", points[1]);
                                                            break;
                                                        case "3":
                                                            PasaPoints("20 GigaPoints", points[2]);
                                                            break;
                                                        case "4":
                                                            PasaPoints("30 GigaPoints", points[3]);
                                                            break;
                                                        case "5":
                                                            PasaPoints("50 GigaPoints", points[4]);
                                                            break;
                                                        case "6":
                                                            PasaPoints("100 GigaPoints", points[5]);
                                                            break;
                                                    }
                                                    break;
                                                case "3":
                                                    Console.WriteLine("Pasa Data");
                                                    Console.WriteLine("CURRECT SHAREABLE DATA = " + iSharable + " GB");
                                                    Console.WriteLine("Select Data Amount");
                                                    Console.WriteLine("1. 100 MB");
                                                    Console.WriteLine("2. 300 MB");
                                                    Console.WriteLine("3. 500 MB");
                                                    Console.WriteLine("4. 1 GB");
                                                    Console.WriteLine("5. 2 GB");
                                                    Console.WriteLine("6. 4 GB");
                                                    Console.WriteLine("7. Back");
                                                    userChoice = UserInput();

                                                    int[] sharable = { 100, 300, 500, 1000, 2000, 4000 };
                                                    switch (userChoice)
                                                    {
                                                        case "1":
                                                            PasaData("100 MB", sharable[0]);
                                                            break;
                                                        case "2":
                                                            PasaData("300 MB", sharable[1]);
                                                            break;
                                                        case "3":
                                                            PasaData("500 MB", sharable[2]);
                                                            break;
                                                        case "4":
                                                            PasaData("1 GB", sharable[3]);
                                                            break;
                                                        case "5":
                                                            PasaData("2 GB", sharable[4]);
                                                            break;
                                                        case "6":
                                                            PasaData("4 GB", sharable[5]);
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid number. Try again.");
                                Console.WriteLine("Enter a mobile number");
                                userInput = Console.ReadLine();
                            }
                            break;
                        }
                        break;
                    case "4": // Account
                        List<string> numberList = new()
                        {
                            "09206420898"
                        }; // List to store the number enter by the user                
                        while (true)
                        {
                            Console.WriteLine("Link more accounts to manage all your numbers");
                            for (int i = 0; i < numberList.Count; i++)
                            {
                                Console.WriteLine(numberList[i]);
                            }
                            Console.WriteLine("Do you want to link you other number?");
                            Console.WriteLine("1. Confirm           2. Cancel");
                            userChoice = UserInput();

                            switch (userChoice)
                            {
                                case "1":
                                    Console.WriteLine("1. Link Smart (Prepaid, Postpaid, Bro, Signature");
                                    Console.WriteLine("2. Link TNT");
                                    Console.WriteLine("3. Link PLDT");
                                    userInput = Input();

                                    if (userChoice == "1")
                                    {
                                        Console.WriteLine("Add Smart number to easily manage your accounts");
                                        userInput = Input();
                                        numberList.Add(userInput + " (SMART)");
                                    }
                                    else if (userChoice == "2")
                                    {
                                        Console.WriteLine("Add TNT number to easily manage your accounts");
                                        userInput = Input();
                                        numberList.Add(userInput + " (TNT)");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Add PLDT number to easily manage your accounts");
                                        userInput = Input();
                                        numberList.Add(userInput + " (PLDT)");
                                    }
                                    break;
                            }
                        }
                }
            }
            return userChoice;
        }
        public static void Balance()
        {
            Console.WriteLine($"Your balance is {iLoad}");
            Console.WriteLine($"Your points is {ipoints}");
            Console.WriteLine("Subcripted to: ");
            for (int i = 0; i < subcriptedList.Count; i++)
            {
                Console.WriteLine(subcriptedList[i]);
            }
            Console.WriteLine("Details");
            Console.WriteLine($"SHAREABLE DATA = {iSharable} GB");
            Console.WriteLine($"DATA = {iData} GB EVERYDAY");
            Console.WriteLine($"MAGIC DATA = {iMagic}");
        }
        public static string UserInput()
        {
            Console.Write("Enter your Choice: ");
            string? userChoice = Console.ReadLine();
            return userChoice;
        }
        public static string Input()
        {
            Console.Write("Enter your Number");
            string? userInput = Console.ReadLine();
            return userInput;
        }
        public static void RedeemRewards(string gigaReward, int usePoints, List<string> subcriptedList)
        {
            if (ipoints >= usePoints)
            {
                double currentPoints = ipoints -= usePoints; // subtraction
                Console.WriteLine($"You have choosen {gigaReward}");
                Console.WriteLine($"Your remaining points is {currentPoints} points");
                Console.WriteLine("Thank you for Claiming. See you on your next transaction!");
                subcriptedList.Add(gigaReward);
            }
            else
            {
                Console.WriteLine("Insufficeint load balance.");
            }

        }
        public static void AcquireVideoPlus(string offerType, string percentage, int loadRequired_1, int totalEverydayGB, int everydayGB, double gigaPointsGain_1, int additionalGB, int date)
        {

            Console.WriteLine($"You are about to subcribe to {offerType}");
            Console.WriteLine($"Unli Allnet Calls & Texts & TOTAL {totalEverydayGB}: {everydayGB} GB VIDEO \n EVERY DAY for YouTube, Netflix, Smart Livestream, \n iWantTFC + {additionalGB} GB for {date} days");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           p{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation(offerType, loadRequired_1, everydayGB, gigaPointsGain_1, additionalGB, subcriptedList);
        }
        public static void AcquireVideo(string offerType, string percentage, string addInfo, int loadRequired_1, int everydayGB, double gigaPointsGain_1, int additionalGB, int date)
        {
            Console.WriteLine($"You are about to subcribe to {offerType}");
            Console.WriteLine($"{everydayGB} VIDEO EVERYDAY for YouTube, Netflix, Smart\nLivestream, iWantTFC + {additionalGB} GB {addInfo} for {date} days");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback!");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation(offerType, loadRequired_1, everydayGB, gigaPointsGain_1, additionalGB, subcriptedList);
        }
        public static void AcquireStoriesPlus(string offerType, string percentage, int loadRequired_1, int totalEverydayGB, int everydayGB, double gigaPointsGain_1, int additonalGB, int date)
        {
            Console.WriteLine($"You are about to subcribe to {offerType}");
            Console.WriteLine($"Unli Allnet Calls & Texts & TOTAL {totalEverydayGB}: {everydayGB} GB STORIES \n EVERY DAY for TikTok, IG, FB, Twitter, Kumu + {additonalGB} for {date} days");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           p{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation(offerType, loadRequired_1, everydayGB, gigaPointsGain_1, additonalGB, subcriptedList);
        }
        public static void AcquireStories(string offerType, string percentage, int loadRequired_1, int everydayGB, int totalEverydayGB, double gigaPointsGain_1, int additionalGB, int date)
        {
            Console.WriteLine($"You are about to subcribe to {offerType}");
            Console.WriteLine($"{everydayGB} STORIES EVERYDAY for TikTok, IG, FB, Twitter,\nKumu (Total{totalEverydayGB} + {additionalGB} GB for {date} days");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback!");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation(offerType, loadRequired_1, everydayGB, gigaPointsGain_1, additionalGB, subcriptedList);
        }
        public static void AcquirePower(string offerType, string percentage, int loadRequired_1, int everydayGB, double gigaPointsGain_1, int additionalGB, int date)
        {
            Console.WriteLine($"You are about to subcribe to {offerType}");
            Console.WriteLine($"{everydayGB} POWER EVERYDAY FOR ALL SITE & APPS + {additionalGB}\nGB Shareable Data for {date} days.");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback!");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation(offerType, loadRequired_1, everydayGB, gigaPointsGain_1, additionalGB, subcriptedList);
        }
        public static void AcquirePowerPlus(string offerType, int loadRequired_1, int everydayGB, double gigaPointsGain_1, int additionalGB, int date)
        {
            Console.WriteLine($"You are about to subcribe to {offerType}");
            Console.WriteLine($"{everydayGB} POWER EVERYDAY FOR ALL SITE & APPS + {additionalGB}\nGB Shareable Data + Unli Allnet Calls & Texts for {date}\ndays.");
            Console.WriteLine($"Get 5% GigaPoints as Cashback!");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation(offerType, loadRequired_1, everydayGB, gigaPointsGain_1, additionalGB, subcriptedList);
        }
        public static void AcquireGames(string offerType, string games, string ticket, string percentage, int loadRequired_1, int everydayGB, double gigaPointsGain_1, int additionalGB, int date)
        {
            Console.WriteLine($"You are about subcribe to {offerType}");
            Console.WriteLine($"{everydayGB} GB GAMES EVERYDAY for {games} + {additionalGB} GB +\nfor {date} days{ticket}");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation(offerType, loadRequired_1, everydayGB, gigaPointsGain_1, additionalGB, subcriptedList);
        }
        public static void AcquireMagic(string offerType, string percentage, int loadRequired_1, double gigaPointsGain_1, int magicGB)
        {
            Console.WriteLine($"You are about to subcribe to {offerType}");
            Console.WriteLine($"{magicGB} GB MAGIC DATA FOR ALL SITES  (NO EXPIRY)");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation_2(offerType, loadRequired_1, gigaPointsGain_1, magicGB, subcriptedList);
        }
        public static void AcquireMagicPlus(string offerType, string percentage, int loadRequired_1, int callText, double gigaPointsGain_1, int magicGB)
        {
            Console.WriteLine($"You are about to subcribe to {offerType}");
            Console.WriteLine($"{magicGB} GB MAGIC DATA FOR ALL SITES + {callText} Mins Allnet Calls + {callText} Allnet Texts (NO EXPIRY)");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation_2(offerType, loadRequired_1, gigaPointsGain_1, magicGB, subcriptedList);
        }
        public static void AcquirePowerAll(string offerType, string percentage, string addInfo, int loadRequired_1, double gigaPointsGain_1, int additionalGB, int date)
        {
            Console.WriteLine($"You are about to subcribe to {offerType}");
            Console.WriteLine($"{additionalGB} GB SHARABLE DATA FOR ALL SITES & APPS + UNLI TikTok EVERY DAY + Unli Allnet Texts{addInfo} for {date} days");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation_3(offerType, loadRequired_1, gigaPointsGain_1, additionalGB, subcriptedList);
        }
        public static void AcquireAllData(string offerType, string percentage, int loadRequired_1, double gigaPointsGain_1, int additionalGB, int date)
        {
            Console.WriteLine($"You are about to subcribe to {offerType}");
            Console.WriteLine($"{additionalGB} GB SHARABLE DATA FOR ALL SITES for {date} days");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation_3(offerType, loadRequired_1, gigaPointsGain_1, additionalGB, subcriptedList);

        }      
        public static void Confirmation(string offerType, int loadRequired_1, int everydayGB, double gigaPointsGain_1, int additionalGB, List<string> subcriptedList)
        {
            var userChoice = UserInput();
            if (userChoice == "1")
            {
                if (iLoad >= loadRequired_1)
                {
                    iLoad -= loadRequired_1;
                    Console.WriteLine($"Thank you for subcribing to {offerType}");
                    ipoints += gigaPointsGain_1;
                    Console.WriteLine($"You recieved {gigaPointsGain_1}");
                    iSharable += (additionalGB * 1000);
                    iData += everydayGB;
                    subcriptedList.Add(offerType);
                }
                else
                {
                    Console.WriteLine("Sorry. Insufficient Balance");
                }
            }
        }
        public static void Confirmation_2(string offerType, int loadRequired_1, double gigaPointsGain_1, int magicGB, List<string> subcriptedList)
        {
            var userChoice = UserInput();
            if (userChoice == "1")
            {
                if (iLoad >= loadRequired_1)
                {
                    iLoad -= loadRequired_1;
                    Console.WriteLine($"Thank you for subcribing to {offerType}");
                    ipoints += gigaPointsGain_1;
                    Console.WriteLine($"You recieved {gigaPointsGain_1}");
                    iMagic += magicGB;
                    subcriptedList.Add(offerType);
                }
                else
                {
                    Console.WriteLine("Sorry. Insufficient Balance");
                }
            }
        } // para sa magic data
        public static void Confirmation_3(string offerType, int loadRequired_1, double gigaPointsGain_1, int additionalGB, List<string> subcriptedList)
        {
            var userChoice = UserInput();
            if (userChoice == "1")
            {
                if (iLoad >= loadRequired_1)
                {
                    iLoad -= loadRequired_1;
                    Console.WriteLine($"Thank you for subcribing to {offerType}");
                    ipoints += gigaPointsGain_1;
                    Console.WriteLine($"You recieved {gigaPointsGain_1}");
                    iSharable += (additionalGB * 1000);
                    subcriptedList.Add(offerType);
                }
                else
                {
                    Console.WriteLine("Sorry. Insufficient Balance");
                }
            }
        } // para sa PowerALL          
        public static void Acquire_5G(string offerType, int loadRequired_1, double gigaPointsGain_1, int date, int additionalGB)
        {
            Console.WriteLine($"You are about to subscribe to {offerType}");
            Console.WriteLine($"UNLI 5G DATA for {date} days + EXTRA {additionalGB} GB DATA (when you use in Non-5G areas)");
            Console.WriteLine("Get 5% GigaPoints as Cashback");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation_3(offerType, loadRequired_1, gigaPointsGain_1, additionalGB, subcriptedList);
        }
        public static void AcquireAllNet(string offerType, string percentage, int loadRequired_1, double gigaPointsGain_1, int allnet, string addInfo, int date)
        {
            Console.WriteLine($"You are about to subscribe to {offerType}");
            Console.WriteLine($"{allnet} {addInfo} + Unli Allnet Calls & Texts for {date}");
            Console.WriteLine($"Get {percentage}% GigaPoints as Cashback");
            Console.WriteLine("Payment Method");
            Console.WriteLine("       Load: P" + iLoad);
            Console.WriteLine($"Amount           P{loadRequired_1}");
            Console.WriteLine("1. Subscribe         2. Cancel");
            Confirmation_4(offerType, loadRequired_1, gigaPointsGain_1, allnet, subcriptedList);
        }
        public static void Confirmation_4(string offerType, int loadRequired_1, double gigaPointsGain_1, int allnet, List<string> subcriptedList)
        {
            var userChoice = UserInput();
            if (userChoice == "1")
            {
                if (iLoad >= loadRequired_1)
                {
                    iLoad -= loadRequired_1;
                    Console.WriteLine($"Thank you for subcribing to {offerType}");
                    ipoints += gigaPointsGain_1;
                    Console.WriteLine($"You recieved {gigaPointsGain_1}");
                    iSharable += allnet;
                    subcriptedList.Add(offerType);
                }
                else
                {
                    Console.WriteLine("Sorry. Insufficient Balance");
                }
            }

        }
        public static void PasaLoad(string pasaType, int load)
        {
            var insufficient = iLoad <= load;
            while (!insufficient)
            {
                if (insufficient)
                {
                    Console.WriteLine("Sorry. Insuffient Load Balance");
                    break;
                }
                if (load <= iLoad)
                {
                    int iAmount = 1;
                    iAmount += load;
                    Console.WriteLine($"You about to send {pasaType}");
                    Console.WriteLine($"Valid for 30 days + P1 transaction fee");
                    Console.WriteLine($"CURRENT LOAD BALANCE: P{iLoad}");
                    Console.WriteLine("Payment Method");
                    Console.WriteLine($"Amount           P{iAmount}");
                    Console.WriteLine("1. Subscribe         2. Cancel");
                    var userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine($"You have successfully {pasaType} to {pasaNo}");
                            iLoad -= iAmount;
                            break;
                    }
                }
                break;
            }

        }
        public static void PasaPoints(string pasaType, int points)
        {
            var insufficient = ipoints <= points;
            while (!insufficient)
            {
                if (insufficient)
                {
                    Console.WriteLine("Sorry. Insuffient Load Balance");
                    break;
                }
                if (points <= ipoints)
                {
                    int iAmount = 1;
                    Console.WriteLine($"You about to send {pasaType}");
                    Console.WriteLine("P1 transaction fee");
                    Console.WriteLine($"SHAREABLE POINTS: {ipoints}");
                    Console.WriteLine("Payment Method");
                    Console.WriteLine($"Load Balance= {iLoad}");
                    Console.WriteLine($"Amount           P{iAmount}");
                    Console.WriteLine("1. Subscribe         2. Cancel");
                    var userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine($"You have successfully {pasaType} to {pasaNo}");
                            iLoad -= iAmount;
                            ipoints -= points;
                            break;
                    }
                }
                break;
            }

        }
        public static void PasaData(string pasaType, int sharable)
        {
            var insufficient = iSharable <= sharable;
            while (!insufficient)
            {
                if (insufficient)
                {
                    Console.WriteLine("Sorry. Insuffient Load Balance");
                    break;
                }
                if (sharable <= iSharable)
                {
                    int iAmount = 1;
                    Console.WriteLine($"You about to send {pasaType} Data");
                    Console.WriteLine($"Valid for 1 day + P1 transaction fee");
                    Console.WriteLine($"SHAREABLE DATA: {iSharable}");
                    Console.WriteLine("Payment Method");
                    Console.WriteLine($"Load Balance= {iLoad}");
                    Console.WriteLine($"Amount           P{iAmount}");
                    Console.WriteLine("1. Subscribe         2. Cancel");
                    var userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine($"You have successfully {pasaType} to {pasaNo}");
                            iLoad -= iAmount;
                            iSharable -= sharable;
                            break;
                    }
                }
                break;
            }

        }
    }
}