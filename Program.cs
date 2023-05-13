using System;

namespace GigaLife
{
    class GigaLife
    {
        static void Main(string[] args)
        {
            // Inside Giga Points 
            int points = 1000;
            string? userChoice, rewards, rewards2;
            int video99 = 99, stories99 = 99, power149 = 149, allNet99 = 99, magicData99 = 99, allData99 = 99;

            // inside HOME
            int load = 5000, sharable = 6000, everDay = 2;
            string? subscription = "GIGA POWER 149";

            // inside PASA
            string? pasaNo = "09476749101";
            string? pasaNoInput;
            string? con, pasa;


            // intro
            string? mobileNumber = "09205629648";
            string? pinCode = "BSCpE2023";

            // intro + Asking for Mobile number
            Console.WriteLine("GigaLife App");
            Console.WriteLine("Enter your Mobile Number");
            string? userNumber = Console.ReadLine();

            // Asking for Password
            Console.WriteLine("Enter your Password");
            string? userPin = Console.ReadLine();

            //conditions
            while (userNumber != "0" & userPin != "0")
            {
                string? result = userNumber == mobileNumber && userPin == pinCode ? "correct" : "error";

                if (result == "correct") // tama sa number mali sa pin 
                {
                    Console.WriteLine("MENU");
                    Console.WriteLine("1. Giga Points");
                    Console.WriteLine("2. Home");
                    Console.WriteLine("3. Pasa");
                    Console.WriteLine("4. Exit");
                    userChoice = Console.ReadLine();

                    if (userChoice == "5")
                    {
                        Console.WriteLine("Exiting the program...");
                        break;

                    }// exit the program
                    switch (userChoice)
                    {
                        case "1": // sa 1st menu ito (GigaPoints)
                            Console.WriteLine("GigaPoints = " + points);
                            Console.WriteLine("You can use your points to Redeem Rewards");
                            Console.WriteLine("MOST POPULAR REWARDS");
                            Console.WriteLine("1. GIGA VIDEO 99 (99 points)");
                            Console.WriteLine("2. GIGA STORIES 99 (99 points");
                            Console.WriteLine("3. GIGA POWER 149 (149 points)");
                            Console.WriteLine("4. All Items");
                            Console.WriteLine("5. Exit");

                            Console.WriteLine("Choice your reward");
                            rewards = Console.ReadLine();

                            switch (rewards)
                            {
                                case "1":
                                    if (points < video99)
                                    {
                                        Console.WriteLine("Insufficient GigaPoints");
                                    }
                                    if (points > video99)
                                    {
                                        int remaining1 = points - video99;
                                        Console.WriteLine("You have choosen GIGA VIDEO 99.");
                                        Console.WriteLine("Your remaining points is " + remaining1 + " points");
                                        Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                    }
                                    break;
                                case "2":
                                    if (points < stories99)
                                    {
                                        Console.WriteLine("Insufficient GigaPoints");
                                    }
                                    if (points > stories99)
                                    {
                                        int remaining2 = points - stories99;
                                        Console.WriteLine("You have choosen GIGA STORIES 99.");
                                        Console.WriteLine("Your remaining points is " + remaining2 + " points");
                                        Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                    }
                                    break;
                                case "3":
                                    if (points < power149)
                                    {
                                        Console.WriteLine("Insufficient GigaPoints");
                                    }
                                    if (points > power149)
                                    {
                                        int remaining3 = points - power149;
                                        Console.WriteLine("You have choosen GIGA POWER 149.");
                                        Console.WriteLine("Your remaining points is " + remaining3 + " points");
                                        Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("1. GIGA VIDEO 99 (99 points)");
                                    Console.WriteLine("2. GIGA STORIES 99 (99 points");
                                    Console.WriteLine("3. ALLNET 99 (99 points)");
                                    Console.WriteLine("4. MAGIC DATA 99 (99 points)");
                                    Console.WriteLine("4. MAGIC DATA 99 (99 points)");
                                    Console.WriteLine("6. GIGA POWER 149 (149 points)");
                                    Console.WriteLine("7. Exit");

                                    rewards2 = Console.ReadLine();

                                    switch (rewards2)
                                    {
                                        case "1":
                                            if (points < video99)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > video99)
                                            {
                                                int remaining1 = points - video99;
                                                Console.WriteLine("You have choosen GIGA VIDEO 99.");
                                                Console.WriteLine("Your remaining points is " + remaining1 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                        case "2":
                                            if (points < stories99)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > stories99)
                                            {
                                                int remaining2 = points - stories99;
                                                Console.WriteLine("You have choosen GIGA STORIES 99.");
                                                Console.WriteLine("Your remaining points is " + remaining2 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                        case "3":
                                            if (points < allNet99)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > allNet99)
                                            {
                                                int remaining3 = points - allNet99;
                                                Console.WriteLine("You have choosen ALL NET 99.");
                                                Console.WriteLine("Your remaining points is " + remaining3 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                        case "4":
                                            if (points < magicData99)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > magicData99)
                                            {
                                                int remaining4 = points - magicData99;
                                                Console.WriteLine("You have choosen MAGIC DATA 99.");
                                                Console.WriteLine("Your remaining points is " + remaining4 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                        case "5":
                                            if (points < allData99)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > allData99)
                                            {
                                                int remaining5 = points - allData99;
                                                Console.WriteLine("You have choosen ALL DATA 99.");
                                                Console.WriteLine("Your remaining points is " + remaining5 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                        case "6":
                                            if (points < power149)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > power149)
                                            {
                                                int remaining6 = points - power149;
                                                Console.WriteLine("You have choosen GIGA POWER 149.");
                                                Console.WriteLine("Your remaining points is " + remaining6 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                    }
                                    break;
                            } // case 1
                            break;
                        case "2": // HOME                            
                            Console.WriteLine("Your balance is " + load);
                            Console.WriteLine("Your points is " + points);
                            Console.WriteLine("Subscribed to = " + subscription);
                            Console.WriteLine("Smart Prepaid (09206420898)");
                            Console.WriteLine("         Do you want to check your DATA USAGE?");
                            Console.WriteLine("                     1. Yes      2. No");
                            userChoice = Console.ReadLine();

                            switch (userChoice) // Kulang pa ito
                            {
                                case "1":
                                    Console.WriteLine("Balance = " + load);
                                    Console.WriteLine("Subscripted to = " + subscription);
                                    Console.WriteLine("Details");
                                    Console.WriteLine("      SHAREABLE DATA = " + sharable + "GB");
                                    Console.WriteLine("      DATA = " + everDay + "GB (POWER EVERY DAY)");
                                    break;
                                case "2":
                                    Console.WriteLine("1. DON'T MISS OUT!");
                                    Console.WriteLine("2. HOT DEALS");
                                    Console.WriteLine("3. DOUBLE GIGA +");
                                    Console.WriteLine("4. GIGA EVERYDAY");
                                    Console.WriteLine("5. POWER ALL ");
                                    Console.WriteLine();

                                    string?
                     homePromo = Console.ReadLine();
                                    while (homePromo != "0")
                                    {
                                        switch (homePromo)
                                        {
                                            case "1": // Don't Miss out
                                                Console.WriteLine("DON'T MISS OUT!");
                                                Console.WriteLine("1. DOUBLE GIGA+");

                                                string?
                                 missOutChoice = Console.ReadLine();
                                                switch (missOutChoice)
                                                {
                                                    case "1": // Double Giga+
                                                        Console.WriteLine("DOUBLE GIGA+");
                                                        Console.WriteLine("1. DOUBLE GIGA VIDEO+ 130");
                                                        Console.WriteLine("2. DOUBLE GIGA VIDEO+ 399");
                                                        Console.WriteLine("3. DOUBLE GIGA STORIES+ 130");
                                                        Console.WriteLine("4. DOUBLE GIGA STORIES+ 399");

                                                        string?
                                         gigaChoice = Console.ReadLine();
                                                        switch (gigaChoice)
                                                        {
                                                            case "1": // Double Giga Video+ 130
                                                                Console.WriteLine("You are about to Subscrube to DOUBLE GIGA VIDEO+ 130");
                                                                Console.WriteLine("      Unli Allnet Calls & Texts & TOTAL 17 GB: 2 GB VIDEO \n EVERY DAY for YouTube, Netflix, Smart Livestream, \n iWantTFC + 3 GB for 7 days");
                                                                Console.WriteLine("Get 5% Giga Points as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P130");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                 video130 = Console.ReadLine();
                                                                switch (video130)
                                                                {
                                                                    case "1":
                                                                        int subVideo130 = 130;
                                                                        if (subVideo130 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subVideo130 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA VIDEO+ 130!");
                                                                            Console.WriteLine("            You received 6.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subVideo130) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;

                                                            case "2": // Double Giga Video+ 399
                                                                Console.WriteLine("You are about to Subscrube to DOUBLE GIGA VIDEO+ 399");
                                                                Console.WriteLine("      Unli Allnet Calls & Texts & TOTAL 64 GB: 2 GB VIDEO \n EVERY DAY for YouTube, Netflix, Smart Livestream, \n iWantTFC + 4 GB for 7 days");
                                                                Console.WriteLine("Get 5% Giga Points as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P399");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                 video399 = Console.ReadLine();
                                                                switch (video399)
                                                                {
                                                                    case "1":
                                                                        int subVideo399 = 399;
                                                                        if (subVideo399 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subVideo399 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA VIDEO+ 399!");
                                                                            Console.WriteLine("            You received 19.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subVideo399) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // Double Giga Stories+ 130
                                                                Console.WriteLine("You are about to Subscrube to DOUBLE GIGA STORIES+ 130");
                                                                Console.WriteLine("      Unli Allnet Calls & Texts & TOTAL 17 GB: 2 GB STOREIS \n EVERY DAY for TikTok, IG, FB, Twitter, Kumu + 3 GB for 7 days");
                                                                Console.WriteLine("Get 5% Giga Points as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P130");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                 stories130 = Console.ReadLine();
                                                                switch (stories130)
                                                                {
                                                                    case "1":
                                                                        int subStories130 = 130;
                                                                        if (subStories130 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subStories130 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA STORIES+ 130!");
                                                                            Console.WriteLine("            You received 6.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subStories130) + ".00");
                                                                        }
                                                                        break;
                                                                }

                                                                break;
                                                            case "4": // Double Giga Stores+ 399
                                                                Console.WriteLine("You are about to Subscrube to DOUBLE GIGA STORIES+ 130");
                                                                Console.WriteLine("      Unli Allnet Calls & Texts & TOTAL 64 GB: 2 GB STOREIS \n EVERY DAY for TikTok, IG, FB, Twitter, Kumu + 4 GB for 7 days");
                                                                Console.WriteLine("Get 5% Giga Points as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P399");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                 stories399 = Console.ReadLine();
                                                                switch (stories399)
                                                                {
                                                                    case "1":
                                                                        int subStories399 = 399;
                                                                        if (subStories399 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subStories399 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA STORIES+ 399!");
                                                                            Console.WriteLine("            You received 19.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subStories399) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                }
                                                break;
                                            case "2": // Hot Deals
                                                Console.WriteLine("HOT DEALS");
                                                Console.WriteLine("       HOT SUPER VALUE DEALS");
                                                Console.WriteLine("     Looking for the best deals? We got you!");
                                                Console.WriteLine("1. POWER ALL 149 with FREEBIE!");

                                                string?
                                 hotDealsChoice = Console.ReadLine();
                                                switch (hotDealsChoice)
                                                {
                                                    case "1":
                                                        Console.WriteLine("You are about to subcribe to POWER ALL 149 with FREEBIE!");
                                                        Console.WriteLine("w/FREE 1GB for 2 days");
                                                        Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                        Console.WriteLine("Payment Method");
                                                        Console.WriteLine("       Load: P" + load);
                                                        Console.WriteLine("Amount           P149");
                                                        Console.WriteLine("1. Subscribe         2. Cancel");

                                                        string?
                                         subChoice = Console.ReadLine();
                                                        switch (subChoice)
                                                        {
                                                            case "1":
                                                                int powerAll149 = 149;
                                                                if (powerAll149 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Balance");
                                                                }
                                                                if (powerAll149 <= load)
                                                                {
                                                                    Console.WriteLine("Thank you for subcribing to POWER ALL 149");
                                                                    Console.WriteLine("            You received 7.45 Giga Points!");
                                                                    Console.WriteLine("Your new balance load: P" + (load - powerAll149) + ".00");
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                }
                                                break; // case 2                                                                                                                                                   

                                            case "3": // Double Giga+
                                                Console.WriteLine("NEW & IMPROVED DOUBLE GIGA+");
                                                Console.WriteLine("WITH UNLI ALLNET CALSS & TEXTS");
                                                Console.WriteLine("2 GB GIGA EVERY DAY");
                                                Console.WriteLine("1. VIDEO");
                                                Console.WriteLine("2. STORIES");
                                                string?
                                 doubleGigaChoice = Console.ReadLine();

                                                switch (doubleGigaChoice) // case 3 for Double Giga+
                                                {
                                                    case "1": // video
                                                        Console.WriteLine("1. DOUBLE GIGA VIDEO+ 65");
                                                        Console.WriteLine("2. DOUBLE GIGA VIDEO+ 130");
                                                        Console.WriteLine("3. DOUBLE GIGA VIDEO+ 399");
                                                        string?
                                         doubleGigaVideo = Console.ReadLine();

                                                        switch (doubleGigaVideo)
                                                        {
                                                            case "1": // Double GIGA video+ 65
                                                                Console.WriteLine("You are about to Subscrube to DOUBLE GIGA VIDEO+ 65");
                                                                Console.WriteLine("      Unli Allnet Calls & Texts & TOTAL 8 GB: 2 GB VIDEO \n      EVERY DAY for YouTube, Netflix, Smart Livestream \n      iWantTFC + 2 GB for 3 days");
                                                                Console.WriteLine("Get 1% Giga Points as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P65");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                 gigaVideo65 = Console.ReadLine();
                                                                switch (gigaVideo65)
                                                                {
                                                                    case "1":
                                                                        int doubleVideo65 = 65;
                                                                        if (doubleVideo65 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleVideo65 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA VIDEO+ 65!");
                                                                            Console.WriteLine("            You received 0.65 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleVideo65) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2":// Double GIGA video+ 130
                                                                Console.WriteLine("You are about to Subscrube to DOUBLE GIGA VIDEO+ 130");
                                                                Console.WriteLine("      Unli Allnet Calls & Texts & TOTAL 17 GB: 2 GB VIDEO \n      EVERY DAY for YouTube, Netflix, Smart Livestream \n      iWantTFC + 3 GB for 7 days");
                                                                Console.WriteLine("Get 5% Giga Points as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P130");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                 gigaVideo130 = Console.ReadLine();
                                                                switch (gigaVideo130)
                                                                {
                                                                    case "1":
                                                                        int doubleVideo130 = 130;
                                                                        if (doubleVideo130 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleVideo130 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA VIDEO+ 130!");
                                                                            Console.WriteLine("            You received 6.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleVideo130) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // Double GIGA video+ 399
                                                                Console.WriteLine("You are about to Subscrube to DOUBLE GIGA VIDEO+ 399");
                                                                Console.WriteLine("      Unli Allnet Calls & Texts & TOTAL 64 GB: 2 GB VIDEO \n      EVERY DAY for YouTube, Netflix, Smart Livestream \n      iWantTFC + 4 GB for 30 days");
                                                                Console.WriteLine("Get 5% Giga Points as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P399");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                 gigaVideo399 = Console.ReadLine();
                                                                switch (gigaVideo399)
                                                                {
                                                                    case "1":
                                                                        int doubleVideo399 = 399;
                                                                        if (doubleVideo399 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleVideo399 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA VIDEO+ 399!");
                                                                            Console.WriteLine("            You received 19.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleVideo399) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "2": // stories
                                                        Console.WriteLine("1. DOUBLE GIGA STORIES+ 65");
                                                        Console.WriteLine("2. DOUBLE GIGA STORIES+ 130");
                                                        Console.WriteLine("3. DOUBLE GIGA STORIES+ 399");
                                                        string?
                                         doubleGigaStories = Console.ReadLine();

                                                        switch (doubleGigaStories)
                                                        {
                                                            case "1": // Double GIGA+ stories 65
                                                                Console.WriteLine("You are about to Subscrube to DOUBLE GIGA STORIES+ 65");
                                                                Console.WriteLine("      Unli Allnet Calls & Texts & TOTAL 8 GB: 2 GB STORIES \n      EVERY DAY for TitTok, IG, FB, Twitter, Kumu + 2 GB for \n      3 days");
                                                                Console.WriteLine("Get 1% Giga Points as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P65");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                 gigaStories65 = Console.ReadLine();
                                                                switch (gigaStories65)
                                                                {
                                                                    case "1":
                                                                        int doubleStories65 = 65;
                                                                        if (doubleStories65 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleStories65 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA STORIES+ 65!");
                                                                            Console.WriteLine("            You received 0.65 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleStories65) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // Double GIGA+ stories 130
                                                                Console.WriteLine("You are about to Subscrube to DOUBLE GIGA STORIES+ 130");
                                                                Console.WriteLine("      Unli Allnet Calls & Texts & TOTAL 17 GB: 2 GB STORIES \n      EVERY DAY for TitTok, IG, FB, Twitter, Kumu + 3 GB for \n      7 days");
                                                                Console.WriteLine("Get 5% Giga Points as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P130");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                 gigaStories130 = Console.ReadLine();
                                                                switch (gigaStories130)
                                                                {
                                                                    case "1":
                                                                        int doubleStories130 = 130;
                                                                        if (doubleStories130 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleStories130 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA STORIES+ 130!");
                                                                            Console.WriteLine("            You received 6.5  Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleStories130) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // Double GIGA+ stories 399
                                                                Console.WriteLine("You are about to Subscrube to DOUBLE GIGA STORIES+ 399");
                                                                Console.WriteLine("      Unli Allnet Calls & Texts & TOTAL 64 GB: 2 GB STORIES \n      EVERY DAY for TitTok, IG, FB, Twitter, Kumu + 4 GB for \n      30 days");
                                                                Console.WriteLine("Get 5% Giga Points as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P399");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                 gigaStories399 = Console.ReadLine();
                                                                switch (gigaStories399)
                                                                {
                                                                    case "1":
                                                                        int doubleStories399 = 399;
                                                                        if (doubleStories399 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleStories399 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA STORIES+ 399!");
                                                                            Console.WriteLine("            You received 19.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleStories399) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                }
                                                break;
                                            case "4": //Giga everyday
                                                Console.WriteLine("GIGA EVERYDAY");
                                                Console.WriteLine("1. POWER");
                                                Console.WriteLine("2. POWER+");
                                                Console.WriteLine("3. VIDEO");
                                                Console.WriteLine("4. VIDEO+");
                                                Console.WriteLine("5. STORIES");
                                                Console.WriteLine("6. STORIES+");
                                                Console.WriteLine("7. GAMES-1");
                                                Console.WriteLine("8. GAMES-2");
                                                Console.WriteLine("9. DOUBLED DATA");
                                                Console.WriteLine("10. Exit");
                                                userChoice = Console.ReadLine();

                                                switch (userChoice)
                                                {
                                                    case "1": // power
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("POWER EVERY DAY");
                                                        Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITES & APPS");
                                                        Console.WriteLine("                +Shareable Data");
                                                        Console.WriteLine("1. 3 Days (3GB)\n        P75");
                                                        Console.WriteLine("2. 7 Days (6GB)\n       P149");
                                                        Console.WriteLine("3. 30 Days (24GB)\n     P499");
                                                        Console.WriteLine("4. 30 Days (36GB)\n     P599");
                                                        Console.WriteLine("5. 30 Days (48GB)\n     P699");
                                                        string?
                                         powerEveryDay = Console.ReadLine();

                                                        switch (powerEveryDay)
                                                        {
                                                            case "1": // Power3GB
                                                                Console.WriteLine("You are about to subcribe to GIGA POWER 75");
                                                                Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITE & APPS + 2\nGB Shareable Data for 3 days.");
                                                                Console.WriteLine("Get 1% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P75");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choicePower3GB = Console.ReadLine();
                                                                switch (choicePower3GB)
                                                                {
                                                                    case "1":
                                                                        int power3GB = 75;
                                                                        if (power3GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (power3GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER 75");
                                                                            Console.WriteLine("            You received 3.75 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - power3GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // Power6GB
                                                                Console.WriteLine("You are about to subcribe to GIGA POWER 149");
                                                                Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITE & APPS + 6\nGB Shareable Data for 7 days.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P149");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choicePower6GB = Console.ReadLine();
                                                                switch (choicePower6GB)
                                                                {
                                                                    case "1":
                                                                        int power6GB = 149;
                                                                        if (power6GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (power6GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER 149");
                                                                            Console.WriteLine("            You received 7.45 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - power6GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // Power24GB
                                                                Console.WriteLine("You are about to subcribe to GIGA POWER 499");
                                                                Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITE & APPS + 24\nGB Shareable Data for 30 days.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P499");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choicePower24GB = Console.ReadLine();
                                                                switch (choicePower24GB)
                                                                {
                                                                    case "1":
                                                                        int power24GB = 499;
                                                                        if (power24GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (power24GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER 499");
                                                                            Console.WriteLine("            You received 24.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - power24GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "4": // Power36GB
                                                                Console.WriteLine("You are about to subcribe to GIGA POWER 599");
                                                                Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITE & APPS + 36\nGB Shareable Data for 30 days.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P599");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choicePower36GB = Console.ReadLine();
                                                                switch (choicePower36GB)
                                                                {
                                                                    case "1":
                                                                        int power36GB = 599;
                                                                        if (power36GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (power36GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER 499");
                                                                            Console.WriteLine("            You received 29.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - power36GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "5": // Power48GB
                                                                Console.WriteLine("You are about to subcribe to GIGA POWER 699");
                                                                Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITE & APPS + 38\nGB Shareable Data for 30 days.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P699");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choicePower48GB = Console.ReadLine();
                                                                switch (choicePower48GB)
                                                                {
                                                                    case "1":
                                                                        int power48GB = 699;
                                                                        if (power48GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (power48GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER 599");
                                                                            Console.WriteLine("            You received 34.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - power48GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "2": //power+
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("POWER+ EVERYDAY");
                                                        Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITES & APPS");
                                                        Console.WriteLine("                 +Shareable Data\n             +UNLI ALLNET Calls & Texts");
                                                        Console.WriteLine("1. 3 Days (2GB)\n        P99");
                                                        Console.WriteLine("2. 7 Days (6GB)\n       P199");
                                                        Console.WriteLine("3. 30 Days (24GB)\n     P699");
                                                        Console.WriteLine("4. 30 Days (36GB)\n     P799");
                                                        Console.WriteLine("5. 30 Days (48GB)\n     P899");
                                                        string?
                                         powerPlus = Console.ReadLine();

                                                        switch (powerPlus)
                                                        {
                                                            case "1": // power+2GB
                                                                Console.WriteLine("You are about to subcribe to GIGA POWER+ 99");
                                                                Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITE & APPS + 2\nGB Shareable Data + Unli Allnet Calls & Text for 3\ndays.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choicePower3GB = Console.ReadLine();
                                                                switch (choicePower3GB)
                                                                {
                                                                    case "1":
                                                                        int power3GB = 99;
                                                                        if (power3GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (power3GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER+ 99");
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - power3GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // power+6GB
                                                                Console.WriteLine("You are about to subcribe to GIGA POWER+ 199");
                                                                Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITE & APPS + 6\nGB Shareable Data + Unli Allnet Calls & Text for 7\ndays.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P199");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choicePower6GB = Console.ReadLine();
                                                                switch (choicePower6GB)
                                                                {
                                                                    case "1":
                                                                        int power6GB = 199;
                                                                        if (power6GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (power6GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER+ 199");
                                                                            Console.WriteLine("            You received 9.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - power6GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // power+24GB
                                                                Console.WriteLine("You are about to subcribe to GIGA POWER+ 699");
                                                                Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITE & APPS + 24\nGB Shareable Data + Unli Allnet Calls & Text for 30\ndays.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P699");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choicePower24GB = Console.ReadLine();
                                                                switch (choicePower24GB)
                                                                {
                                                                    case "1":
                                                                        int power24GB = 699;
                                                                        if (power24GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (power24GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER+ 699");
                                                                            Console.WriteLine("            You received 34.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - power24GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "4": // // power+36GB
                                                                Console.WriteLine("You are about to subcribe to GIGA POWER+ 799");
                                                                Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITE & APPS + 36\nGB Shareable Data + Unli Allnet Calls & Text for 30\ndays.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P799");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choicePower36GB = Console.ReadLine();
                                                                switch (choicePower36GB)
                                                                {
                                                                    case "1":
                                                                        int power36GB = 799;
                                                                        if (power36GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (power36GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER+ 799");
                                                                            Console.WriteLine("            You received 39.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - power36GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "5": // power+48GB
                                                                Console.WriteLine("You are about to subcribe to GIGA POWER+ 899");
                                                                Console.WriteLine("2GB POWER EVERYDAY FOR ALL SITE & APPS + 48\nGB Shareable Data + Unli Allnet Calls & Text for 30\ndays.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P899");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choicePower48GB = Console.ReadLine();
                                                                switch (choicePower48GB)
                                                                {
                                                                    case "1":
                                                                        int power48GB = 899;
                                                                        if (power48GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (power48GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER+ 899");
                                                                            Console.WriteLine("            You received 44.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - power48GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "3": // video
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("VIDEO EVERYDAY");
                                                        Console.WriteLine("1GB VIDEO EVERY DAY");
                                                        Console.WriteLine("1. 3 Days (2GB)\n        P50");
                                                        Console.WriteLine("2. 7 Days (6GB)\n        P99");
                                                        Console.WriteLine("3. 30 Days (24GB)\n     P299");
                                                        string?
                                         videoEveryDay = Console.ReadLine();

                                                        switch (videoEveryDay)
                                                        {
                                                            case "1": // video 2GB
                                                                Console.WriteLine("You are about to subcribe to GIGA VIDEO 50");
                                                                Console.WriteLine("1GB VIDEO EVERYDAY for YouTube, Netflix, Smart\nLivestream, iWantTFC + 1GB + Unli Allnet Texts for 3\ndays");
                                                                Console.WriteLine("Get 1% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P50");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceVideo2GB = Console.ReadLine();
                                                                switch (choiceVideo2GB)
                                                                {
                                                                    case "1":
                                                                        int video2GB = 50;
                                                                        if (video2GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (video2GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO 50");
                                                                            Console.WriteLine("            You received 0.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - video2GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // video 6GB
                                                                Console.WriteLine("You are about to subcribe to GIGA VIDEO 99");
                                                                Console.WriteLine("1GB VIDEO EVERYDAY for YouTube, Netflix, Smart\nLivestream, iWantTFC + 2GB for 7 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceVideo6GB = Console.ReadLine();
                                                                switch (choiceVideo6GB)
                                                                {
                                                                    case "1":
                                                                        int video6GB = 99;
                                                                        if (video6GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (video6GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO 99");
                                                                            Console.WriteLine("            You received 4.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - video6GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // video 24GB
                                                                Console.WriteLine("You are about to subcribe to GIGA VIDEO 299");
                                                                Console.WriteLine("1GB VIDEO EVERYDAY for YouTube, Netflix, Smart\nLivestream, iWantTFC + 4GB for 30 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P299");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceVideo24GB = Console.ReadLine();
                                                                switch (choiceVideo24GB)
                                                                {
                                                                    case "1":
                                                                        int video24GB = 299;
                                                                        if (video24GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (video24GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - video24GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "4": // video+
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("VIDEO+ EVERYDAY");
                                                        Console.WriteLine("1GB VIDEO EVERY DAY");
                                                        Console.WriteLine("+Unli Allnet Calls & Texts");
                                                        Console.WriteLine("1. 3 Days (1GB)\n         P75");
                                                        Console.WriteLine("2. 7 Days (2GB)\n        P149");
                                                        Console.WriteLine("3. 30 Days (4GB)\n       P449");
                                                        string?
                                         videoPLus = Console.ReadLine();

                                                        switch (videoPLus)
                                                        {
                                                            case "1": // video+ 1GB
                                                                Console.WriteLine("You are about to subcribe to GIGA VIDEO+ 75");
                                                                Console.WriteLine("1GB VIDEO EVERYDAY for YouTube, Netflix, Smart\nLivestream, iWantTFC + 1GB + Unli Allnet calls &\n Texts for 3 days");
                                                                Console.WriteLine("Get 1% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P75");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceVideo1GB = Console.ReadLine();
                                                                switch (choiceVideo1GB)
                                                                {
                                                                    case "1":
                                                                        int video1GB = 75;
                                                                        if (video1GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (video1GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO+ 75");
                                                                            Console.WriteLine("            You received 3.75 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - video1GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // Video+ 2GB
                                                                Console.WriteLine("You are about to subcribe to GIGA VIDEO+ 149");
                                                                Console.WriteLine("1GB VIDEO EVERYDAY for YouTube, Netflix, Smart\nLivestream, iWantTFC + 2GB + Unli Allnet calls &\n Texts for 7 days");
                                                                Console.WriteLine("Get %5 GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P149");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceVideo2GB = Console.ReadLine();
                                                                switch (choiceVideo2GB)
                                                                {
                                                                    case "1":
                                                                        int video2GB = 149;
                                                                        if (video2GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (video2GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO+ 149");
                                                                            Console.WriteLine("            You received 7.45 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - video2GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // Video+ 4GB
                                                                Console.WriteLine("You are about to subcribe to GIGA VIDEO+ 449");
                                                                Console.WriteLine("1GB VIDEO EVERYDAY for YouTube, Netflix, Smart\nLivestream, iWantTFC + 4GB + Unli Allnet calls &\n Texts for 30 days");
                                                                Console.WriteLine("Get %5 GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P449");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceVideo4GB = Console.ReadLine();
                                                                switch (choiceVideo4GB)
                                                                {
                                                                    case "1":
                                                                        int video4GB = 449;
                                                                        if (video4GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (video4GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO+ 449");
                                                                            Console.WriteLine("            You received 22.45 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - video4GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "5": // stories
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("STORIES EVERYDAY");
                                                        Console.WriteLine("1GB STORIES EVERY DAY");
                                                        Console.WriteLine("1. 3 Days (1GB)\n         P50");
                                                        Console.WriteLine("2. 7 Days (2GB)\n         P99");
                                                        Console.WriteLine("3. 30 Days (4GB)\n       P299");
                                                        string?
                                         storiesEveryDay = Console.ReadLine();

                                                        switch (storiesEveryDay)
                                                        {
                                                            case "1": // stories 1GB
                                                                Console.WriteLine("You are about to subcribe to GIGA STORIES 50");
                                                                Console.WriteLine("1GB STORIES EVERY DAY for TikTOK, IG, FB, Twitter,\nKumu, (Total 3 GB) + 1 GB for 3 days");
                                                                Console.WriteLine("Get %1 GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P50");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceStories1GB = Console.ReadLine();

                                                                switch (choiceStories1GB)
                                                                {
                                                                    case "1":
                                                                        int stories1GB = 50;
                                                                        if (stories1GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (stories1GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES 50");
                                                                            Console.WriteLine("            You received 0.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - stories1GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // stories 2GB
                                                                Console.WriteLine("You are about to subcribe to GIGA STORIES 99");
                                                                Console.WriteLine("1GB STORIES EVERY DAY for TikTOK, IG, FB, Twitter,\nKumu, (Total 7 GB) + 2 GB for 7 days");
                                                                Console.WriteLine("Get %5 GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceStories2GB = Console.ReadLine();

                                                                switch (choiceStories2GB)
                                                                {
                                                                    case "1":
                                                                        int stories2GB = 99;
                                                                        if (stories2GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (stories2GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES 99");
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - stories2GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // stories 4GB
                                                                Console.WriteLine("You are about to subcribe to GIGA STORIES 299");
                                                                Console.WriteLine("1GB STORIES EVERY DAY for TikTOK, IG, FB, Twitter,\nKumu, (Total 30 GB) + 4 GB for 30 days");
                                                                Console.WriteLine("Get %5 GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P299");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceStories4GB = Console.ReadLine();

                                                                switch (choiceStories4GB)
                                                                {
                                                                    case "1":
                                                                        int stories4GB = 299;
                                                                        if (stories4GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (stories4GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - stories4GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "6": // stories+
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("STORIES EVERYDAY");
                                                        Console.WriteLine("1GB STORIES+ EVERY DAY");
                                                        Console.WriteLine("+ Unli Allnet Calls & Texts");
                                                        Console.WriteLine("1. 3 Days (1GB)\n          P75");
                                                        Console.WriteLine("2. 7 Days (2GB)\n         P149");
                                                        Console.WriteLine("3. 30 Days (4GB)\n        P499");
                                                        string?
                                         storiesPlus = Console.ReadLine();

                                                        switch (storiesPlus)
                                                        {
                                                            case "1": // stories+ 1GB
                                                                Console.WriteLine("You are about to subcribe to GIGA STORIES 75");
                                                                Console.WriteLine("1GB STORIES EVERY DAY for TikTOK, IG, FB, Twitter,\nKumu, (Total 3 GB) + 1 GB + Unli Allnet Calls & Texts\n for 3 days");
                                                                Console.WriteLine("Get %1 GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P75");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceStories1GB = Console.ReadLine();

                                                                switch (choiceStories1GB)
                                                                {
                                                                    case "1":
                                                                        int stories1GB = 70;
                                                                        if (stories1GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (stories1GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES+ 75");
                                                                            Console.WriteLine("            You received 3.75 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - stories1GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // stories+ 2GB
                                                                Console.WriteLine("You are about to subcribe to GIGA STORIES 149");
                                                                Console.WriteLine("1GB STORIES EVERY DAY for TikTOK, IG, FB, Twitter,\nKumu, (Total 7 GB) + 2 GB + Unli Allnet Calls & Texts\n for 7 days");
                                                                Console.WriteLine("Get %5 GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P149");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceStories2GB = Console.ReadLine();

                                                                switch (choiceStories2GB)
                                                                {
                                                                    case "1":
                                                                        int stories2GB = 149;
                                                                        if (stories2GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (stories2GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES+ 149");
                                                                            Console.WriteLine("            You received 7.45 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - stories2GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // Stories+ 4GB
                                                                Console.WriteLine("You are about to subcribe to GIGA STORIES 449");
                                                                Console.WriteLine("1GB STORIES EVERY DAY for TikTOK, IG, FB, Twitter,\nKumu, (Total 7 GB) + 2 GB + Unli Allnet Calls & Texts\n for 7 days");
                                                                Console.WriteLine("Get %5 GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P449");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceStories4GB = Console.ReadLine();

                                                                switch (choiceStories4GB)
                                                                {
                                                                    case "1":
                                                                        int stories4GB = 449;
                                                                        if (stories4GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (stories4GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES+ 449");
                                                                            Console.WriteLine("            You received 22.45 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - stories4GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }

                                                        break;
                                                    case "7": // Games-1
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("GAMES-1 EVERYDAY");
                                                        Console.WriteLine("1GB GAME EVERY DAY");
                                                        Console.WriteLine("+ Free Giga Arena Tickets");
                                                        Console.WriteLine("1. 3 Days (1GB)\n          P50");
                                                        Console.WriteLine("2. 7 Days (2GB)\n          P99");
                                                        Console.WriteLine("3. 30 Days (4GB)\n        P299");
                                                        string?
                                         games1EveryDay = Console.ReadLine();

                                                        switch (games1EveryDay)
                                                        {
                                                            case "1": // games-1 (1GB)
                                                                Console.WriteLine("You are about to subcribe to GIGA GAMES-1 50");
                                                                Console.WriteLine("1GB GAMES EVERY DAY for PUBG Mobile, ML, CoC,\nAoV, Clash Royale, FB Gaming, Giga Arena + 1 GB\nfor 3 days + Free Giga Arena Tickets.");
                                                                Console.WriteLine("Get 1% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P50");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceGames1GB = Console.ReadLine();

                                                                switch (choiceGames1GB)
                                                                {
                                                                    case "1":
                                                                        int games1GB = 50;
                                                                        if (games1GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (games1GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-1 50");
                                                                            Console.WriteLine("            You received 0.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - games1GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // games-1 (2GB)
                                                                Console.WriteLine("You are about to subcribe to GIGA GAMES-1 99");
                                                                Console.WriteLine("1GB GAMES EVERY DAY for PUBG Mobile, ML, CoC,\nAoV, Clash Royale, FB Gaming, Giga Arena + 2 GB\nfor 7 days + Free Giga Arena Tickets.");
                                                                Console.WriteLine("Get 1% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceGames2GB = Console.ReadLine();

                                                                switch (choiceGames2GB)
                                                                {
                                                                    case "1":
                                                                        int games2GB = 99;
                                                                        if (games2GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (games2GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-1 99");
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - games2GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // games-1 (4GB)
                                                                Console.WriteLine("You are about to subcribe to GIGA GAMES-1 299");
                                                                Console.WriteLine("1GB GAMES EVERY DAY for PUBG Mobile, ML, CoC,\nAoV, Clash Royale, FB Gaming, Giga Arena + 7 GB\nfor 30 days + Free Giga Arena Tickets.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P299");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceGames4GB = Console.ReadLine();

                                                                switch (choiceGames4GB)
                                                                {
                                                                    case "1":
                                                                        int games4GB = 299;
                                                                        if (games4GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (games4GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-1 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - games4GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "8": // games-2
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("GAMES-2 EVERYDAY");
                                                        Console.WriteLine("1GB GAME EVERY DAY");
                                                        Console.WriteLine("+ Free Giga Arena Tickets");
                                                        Console.WriteLine("1. 3 Days (1GB)\n          P50");
                                                        Console.WriteLine("2. 7 Days (2GB)\n          P99");
                                                        Console.WriteLine("3. 30 Days (4GB)\n        P299");
                                                        string?
                                         games2EveryDay = Console.ReadLine();

                                                        switch (games2EveryDay)
                                                        {
                                                            case "1": // Games-2 (1GB)
                                                                Console.WriteLine("You are about to subcribe to GIGA GAMES-2 50");
                                                                Console.WriteLine("1GB GAMES EVERY DAY for Wild Rift, Call of Duty, Ml\nFB Gaming, Giga Arena (Total 3 GB) + 1 GB for 3\ndays + FREE Giga Arena Tickets.");
                                                                Console.WriteLine("Get 1% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P50");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceGames1GB = Console.ReadLine();

                                                                switch (choiceGames1GB)
                                                                {
                                                                    case "1":
                                                                        int games1GB = 50;
                                                                        if (games1GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (games1GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-2 50");
                                                                            Console.WriteLine("            You received 0.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - games1GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // Games-2 (2GB)
                                                                Console.WriteLine("You are about to subcribe to GIGA GAMES-2 99");
                                                                Console.WriteLine("1GB GAMES EVERY DAY for Wild Rift, Call of Duty, Ml\nFB Gaming, Giga Arena (Total 7 GB) + 2 GB for 3\ndays + FREE Giga Arena Tickets.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceGames2GB = Console.ReadLine();

                                                                switch (choiceGames2GB)
                                                                {
                                                                    case "1":
                                                                        int games2GB = 99;
                                                                        if (games2GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (games2GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-2 99");
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - games2GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // Games-2 (4GB)
                                                                Console.WriteLine("You are about to subcribe to GIGA GAMES-2 299");
                                                                Console.WriteLine("1GB GAMES EVERY DAY for Wild Rift, Call of Duty, Ml\nFB Gaming, Giga Arena (Total 30 GB) + 4 GB for 3\ndays + FREE Giga Arena Tickets.");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P299");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                string?
                                                 choiceGames4GB = Console.ReadLine();

                                                                switch (choiceGames4GB)
                                                                {
                                                                    case "1":
                                                                        int games4GB = 299;
                                                                        if (games4GB > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (games4GB <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-2 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - games4GB) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "9": // double data
                                                        Console.WriteLine("DOUBLE DATA FOR ALL");
                                                        Console.WriteLine("                 Get 2x SHAREABLE DATA\nwhen you subcribe to the offers below");
                                                        Console.WriteLine("1. 7 Days (4GB - VIDEO)\n              P99");
                                                        Console.WriteLine("2. 7 Days (4GB - STORIES\n             P99");
                                                        Console.WriteLine("3. 7 Days (4GB - GAMES-1)\n            P99");
                                                        Console.WriteLine("4. 7 Days (4GB - GAMES-2\n             P99");
                                                        Console.WriteLine("5. 30 Days (8GB - VIDEO\n             P299");
                                                        Console.WriteLine("6. 30 Days (8GB - STORIES)\n          P299");
                                                        string?
                                         doubleDataEveryDay = Console.ReadLine();

                                                        string?
                                         double99, double299;
                                                        switch (doubleDataEveryDay)
                                                        {
                                                            case "1":// Video99
                                                                Console.WriteLine("You are about to subcribe to GIGA VIDEO 99");
                                                                Console.WriteLine("1GB VIDEO EVERY DAY for YouTube, Netflix, Smart\nLivestream, iWantTFC + 4 GB for 7 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                double99 = Console.ReadLine();

                                                                switch (double99)
                                                                {
                                                                    case "1":
                                                                        int doubleVideo99 = 99;
                                                                        if (doubleVideo99 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleVideo99 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO 99");
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleVideo99) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // Stories99
                                                                Console.WriteLine("You are about to subcribe to GIGA STORIES 99");
                                                                Console.WriteLine("1GB STORIES EVERY DAY for TikTok, IG, FB, Twitter,\nKumu + 4 GB for 7 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                double99 = Console.ReadLine();

                                                                switch (double99)
                                                                {
                                                                    case "1":
                                                                        int doubleStories99 = 99;
                                                                        if (doubleStories99 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleStories99 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES 99");
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleStories99) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3":// Games-1 99
                                                                Console.WriteLine("You are about to subcribe to GIGA GAMES-1 99");
                                                                Console.WriteLine("1GB GAMES EVERY DAY for PUBG Mobile, ML, \nKumu + 4 GB for 7 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                double99 = Console.ReadLine();

                                                                switch (double99)
                                                                {
                                                                    case "1":
                                                                        int doubleGames99 = 99;
                                                                        if (doubleGames99 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleGames99 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-1 99");
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleGames99) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "4": // Games-2 99
                                                                Console.WriteLine("You are about to subcribe to GIGA GAMES-2 99");
                                                                Console.WriteLine("1GB GAMES EVERY DAY for Wild Rift, Call Of Duty,ML\nFB Gaming, Giga Arena + 4 GB for 7 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                double99 = Console.ReadLine();

                                                                switch (double99)
                                                                {
                                                                    case "1":
                                                                        int doubleGames99 = 99;
                                                                        if (doubleGames99 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleGames99 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-2 99");
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleGames99) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "5": // Video299
                                                                Console.WriteLine("You are about to subcribe to GIGA VIDEO 299");
                                                                Console.WriteLine("1GB GAMES EVERY DAY for YouTube, Netflix, Smart\nLivestream, iWantTFC + 8 GB for 30 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P299");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                double299 = Console.ReadLine();

                                                                switch (double299)
                                                                {
                                                                    case "1":
                                                                        int doubleVideo299 = 299;
                                                                        if (doubleVideo299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleVideo299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO  299");
                                                                            Console.WriteLine("            You received 14.955 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleVideo299) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "6": // Stories299
                                                                Console.WriteLine("You are about to subcribe to GIGA STORIES 299");
                                                                Console.WriteLine("1GB STORIES EVERY DAY for TikTok, IG, FB, Twitter,\nKumu + 8 GB for 30 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P299");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");
                                                                double299 = Console.ReadLine();

                                                                switch (double299)
                                                                {
                                                                    case "1":
                                                                        int doubleStories299 = 299;
                                                                        if (doubleStories299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (doubleStories299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - doubleStories299) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                }
                                                break;
                                            case "5": // Power all
                                                Console.WriteLine("Up to 5x GigaPoints");
                                                Console.WriteLine("New");
                                                Console.WriteLine("    POWERALL");
                                                Console.WriteLine("with FREE UNLI TikTok EVERY DAY\n  + Shareable Data & Unli Allnet Texts");
                                                Console.WriteLine("1. 7 Days (8GB)\n           P99");
                                                Console.WriteLine("2. 7 Days (12GB)\n         P149");
                                                userChoice = Console.ReadLine();

                                                switch (userChoice)
                                                {
                                                    case "1": // Power All (8GB)
                                                        Console.WriteLine("You are about to subcribe to POWER ALL 99");
                                                        Console.WriteLine("8 GB SHAREABLE DATA FOR ALL SITES & APPS + UNLI\nTikTok EVERYDAY + Unli Allnet Texts for 7 days.");
                                                        Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                        Console.WriteLine("Payment Method");
                                                        Console.WriteLine("       Load: P" + load);
                                                        Console.WriteLine("Amount           P99");
                                                        Console.WriteLine("1. Subscribe         2. Cancel");
                                                        string?
                                         choicePower8GB = Console.ReadLine();
                                                        switch (choicePower8GB)
                                                        {
                                                            case "1":
                                                                int power8GB = 99;
                                                                if (power8GB > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Balance");
                                                                }
                                                                if (power8GB <= load)
                                                                {
                                                                    Console.WriteLine("Thank you for subcribing to GIGA POWER 99");
                                                                    Console.WriteLine("            You received 4.95 Giga Points!");
                                                                    Console.WriteLine("Your new balance load: P" + (load - power8GB) + ".00");
                                                                }
                                                                break;
                                                        }
                                                        break; // Power All (12GB)
                                                    case "2": // Power All (12GB)
                                                        Console.WriteLine("You are about to subcribe to POWER ALL 149");
                                                        Console.WriteLine("12 GB SHAREABLE DATA FOR ALL SITES & APPS + UNLI\nTikTok EVERYDAY + Unli Allnet Texts for 7 days.");
                                                        Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                        Console.WriteLine("Payment Method");
                                                        Console.WriteLine("       Load: P" + load);
                                                        Console.WriteLine("Amount           P149");
                                                        Console.WriteLine("1. Subscribe         2. Cancel");
                                                        string?
                                         choicePower12GB = Console.ReadLine();
                                                        switch (choicePower12GB)
                                                        {
                                                            case "1":
                                                                int power12GB = 149;
                                                                if (power12GB > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Balance");
                                                                }
                                                                if (power12GB <= load)
                                                                {
                                                                    Console.WriteLine("Thank you for subcribing to GIGA POWER 149");
                                                                    Console.WriteLine("            You received 7.45 Giga Points!");
                                                                    Console.WriteLine("Your new balance load: P" + (load - power12GB) + ".00");
                                                                }
                                                                break;
                                                        }
                                                        break; // Power All (12GB)
                                                }
                                                break;
                                        }
                                        break;
                                    }
                                    break;
                            }
                            break;
                        case "3": // PASA                             
                            Console.WriteLine("Pasa");
                            Console.WriteLine("Enter a mobile number ");
                            Console.WriteLine("0 to exit");
                            pasaNoInput = Console.ReadLine();

                            while (pasaNoInput != "0")
                            {
                                string?
                 result2 = pasaNoInput == pasaNo ? "correct" : "incorrect";

                                if (result2 == "correct")
                                {
                                    Console.WriteLine("Do you want to continue?");
                                    Console.WriteLine("1. Yes      2. Exit");
                                    con = Console.ReadLine();
                                    if (con == "1")
                                    {
                                        switch (con)
                                        {
                                            case "1":
                                                Console.WriteLine("1. Pasa Load");
                                                Console.WriteLine("2. Pasa Points");
                                                Console.WriteLine("3. Pasa Data");
                                                Console.WriteLine("4. Exit");
                                                pasa = Console.ReadLine();
                                                switch (pasa)
                                                {
                                                    case "1":
                                                        Console.WriteLine("Pasa Load");
                                                        Console.WriteLine("CURRENT LOAD BALANCE = P" + load);
                                                        Console.WriteLine("Select Amount");
                                                        Console.WriteLine("1. P50.00");
                                                        Console.WriteLine("2. P100.00");
                                                        Console.WriteLine("3. P200.00");
                                                        Console.WriteLine("4. P300.00");
                                                        Console.WriteLine("5. P500.00");
                                                        Console.WriteLine("6. P1,000.00");
                                                        Console.WriteLine("7. Exit");

                                                        string?
                                         amountLoad = Console.ReadLine();
                                                        switch (amountLoad)
                                                        {
                                                            case "1":
                                                                int pasa50 = 50;
                                                                int pasaload50 = 50 + 1;
                                                                if (pasa50 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (pasa50 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send P50.00 load");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaload50 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send P50.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance is P" + (load - pasaload50) + ".00");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "2":
                                                                int pasa100 = 100;
                                                                int pasaload100 = 100 + 1;
                                                                if (pasa100 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (pasa100 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send P100.00 load");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaload100 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send P50.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance is P" + (load - pasaload100) + ".00");
                                                                            break;
                                                                    }
                                                                    break;
                                                                }
                                                                break;
                                                            case "3":
                                                                int pasa200 = 200;
                                                                int pasaload200 = 200 + 1;
                                                                if (pasa200 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (pasa200 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send P100.00 load");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaload200 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send P50.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance is P" + (load - pasaload200) + ".00");
                                                                            break;
                                                                    }
                                                                    break;
                                                                }
                                                                break;
                                                            case "4":
                                                                int pasa300 = 300;
                                                                int pasaload300 = 300 + 1;
                                                                if (pasa300 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (pasa300 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send P100.00 load");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaload300 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send P50.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance is P" + (load - pasaload300) + ".00");
                                                                            break;
                                                                    }
                                                                    break;
                                                                }
                                                                break;
                                                            case "5":
                                                                int pasa500 = 500;
                                                                int pasaload500 = 500 + 1;
                                                                if (pasa500 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (pasa500 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send P100.00 load");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaload500 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send P50.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance is P" + (load - pasaload500) + ".00");
                                                                            break;
                                                                    }
                                                                    break;
                                                                }
                                                                break;
                                                            case "6":
                                                                int pasa1000 = 1000;
                                                                int pasaload1000 = 1000 + 1;
                                                                if (pasa1000 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (pasa1000 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send P100.00 load");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaload1000 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send P50.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance is P" + (load - pasaload1000) + ".00");
                                                                            break;
                                                                    }
                                                                    break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "2": // PASA POINTS
                                                        Console.WriteLine("Pasa Points");
                                                        Console.WriteLine("CURRECTN GIGA POINTS = " + points);
                                                        Console.WriteLine("Select Points");
                                                        Console.WriteLine("1. 5 points");
                                                        Console.WriteLine("2. 10 points");
                                                        Console.WriteLine("3. 20 points");
                                                        Console.WriteLine("4. 30 points");
                                                        Console.WriteLine("5. 50 points");
                                                        Console.WriteLine("6. 100 points");
                                                        Console.WriteLine("7. Exit");

                                                        string?
                                         amountPoints = Console.ReadLine();
                                                        switch (amountPoints)
                                                        {
                                                            case "1":
                                                                int points5 = 5;
                                                                if (points5 > points)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (points5 <= points)
                                                                {
                                                                    Console.WriteLine("You are about to send 5 GigaPoints");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P 1.00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send " + points5 + "GigaPoints to " + pasaNo);
                                                                            Console.WriteLine("Your current GigaPoints = " + (points - points5) + " GigaPoints");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "2":
                                                                int points10 = 10;
                                                                int pasaPoints10 = 10 + 1;
                                                                if (points10 > points)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (points10 <= points)
                                                                {
                                                                    Console.WriteLine("You are about to send 10 GigaPoints");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaPoints10 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send " + points10 + "GigaPoints to " + pasaNo);
                                                                            Console.WriteLine("Your current GigaPoints = " + (points - pasaPoints10) + " GigaPoints");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "3":
                                                                int points20 = 20;
                                                                int pasaPoints20 = 20 + 1;
                                                                if (points20 > points)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (points20 <= points)
                                                                {
                                                                    Console.WriteLine("You are about to send 10 GigaPoints");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaPoints20 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send " + points20 + "GigaPoints to " + pasaNo);
                                                                            Console.WriteLine("Your current GigaPoints = " + (points - pasaPoints20) + " GigaPoints");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "4":
                                                                int points30 = 30;
                                                                int pasaPoints30 = 30 + 1;
                                                                if (points30 > points)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (points30 <= points)
                                                                {
                                                                    Console.WriteLine("You are about to send 10 GigaPoints");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaPoints30 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send " + points30 + "GigaPoints to " + pasaNo);
                                                                            Console.WriteLine("Your current GigaPoints = " + (points - pasaPoints30) + " GigaPoints");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "5":
                                                                int points50 = 50;
                                                                int pasaPoints50 = 50 + 1;
                                                                if (points50 > points)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (points50 <= points)
                                                                {
                                                                    Console.WriteLine("You are about to send 10 GigaPoints");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaPoints50 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send " + points50 + "GigaPoints to " + pasaNo);
                                                                            Console.WriteLine("Your current GigaPoints = " + (points - pasaPoints50) + " GigaPoints");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "6":
                                                                int points100 = 100;
                                                                int pasaPoints100 = 100 + 1;
                                                                if (points100 > points)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (points100 <= points)
                                                                {
                                                                    Console.WriteLine("You are about to send 10 GigaPoints");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaPoints100 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send " + points100 + "GigaPoints to " + pasaNo);
                                                                            Console.WriteLine("Your current GigaPoints = " + (points - pasaPoints100) + " GigaPoints");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "3": // PASA DATA
                                                        Console.WriteLine("Pasa Data");
                                                        Console.WriteLine("CURRECT SHAREABLE DATA = " + sharable + " GB");
                                                        Console.WriteLine("Select Data Amount");
                                                        Console.WriteLine("1. 100 MB");
                                                        Console.WriteLine("2. 300 MB");
                                                        Console.WriteLine("3. 500 MB");
                                                        Console.WriteLine("4. 1 GB");
                                                        Console.WriteLine("5. 2 GB");
                                                        Console.WriteLine("6. 4 GB");
                                                        Console.WriteLine("7. Exit");

                                                        string?
                                         dataAmount = Console.ReadLine();
                                                        switch (dataAmount)
                                                        {
                                                            case "1":
                                                                int data100 = 100;
                                                                int pasaData100 = 1;
                                                                if (data100 > sharable)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (data100 <= sharable)
                                                                {
                                                                    Console.WriteLine("You are about to send 100 MB");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaData100 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send " + data100 + "MB to " + pasaNo);
                                                                            Console.WriteLine("Your current GigaPoints = " + (sharable - pasaData100) + " MB");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "2":
                                                                int data300 = 300;
                                                                int pasaData300 = 1;
                                                                if (data300 > sharable)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (data300 <= sharable)
                                                                {
                                                                    Console.WriteLine("You are about to send 300 MB");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaData300 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send " + data300 + "MB to " + pasaNo);
                                                                            Console.WriteLine("Your current GigaPoints = " + (sharable - pasaData300) + " MB");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "3":
                                                                int data500 = 500;
                                                                int pasaData500 = 1;
                                                                if (data500 > sharable)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (data500 <= sharable)
                                                                {
                                                                    Console.WriteLine("You are about to send 300 MB");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaData500 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send " + data500 + "MB to " + pasaNo);
                                                                            Console.WriteLine("Your current GigaPoints = " + (sharable - pasaData500) + " MB");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "4":
                                                                int data1000 = 1000;
                                                                int pasaData1000 = 1;
                                                                if (data1000 > sharable)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (data1000 <= sharable)
                                                                {
                                                                    Console.WriteLine("You are about to send 300 MB");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaData1000 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send 1 GB to " + pasaNo);
                                                                            Console.WriteLine("Your current Shareable Data = " + (sharable - data1000) + " MB");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "5":
                                                                int data2000 = 2000;
                                                                int pasaData2000 = 1;
                                                                if (data2000 > sharable)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (data2000 <= sharable)
                                                                {
                                                                    Console.WriteLine("You are about to send 2 GB");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaData2000 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send 2 GB to " + pasaNo);
                                                                            Console.WriteLine("Your current Shareable Data = " + (sharable - data2000) + " GB");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "6":
                                                                int data4000 = 4000;
                                                                int pasaData4000 = 1;
                                                                if (data4000 > sharable)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                }
                                                                if (data4000 <= sharable)
                                                                {
                                                                    Console.WriteLine("You are about to send 2 GB");
                                                                    Console.WriteLine("+P1 transaction fee");
                                                                    Console.WriteLine("Payment Method = Load Balance: P" + load + ".00");
                                                                    Console.WriteLine("Amount           P" + pasaData4000 + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                     confirmation = Console.ReadLine();

                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully send 2 GB to " + pasaNo);
                                                                            Console.WriteLine("Your current Shareable Data = " + (sharable - data4000) + " GB");
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                }
                                                break;

                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid number. Try again.");
                                    Console.WriteLine("Enter a mobile number");
                                    pasaNoInput = Console.ReadLine();
                                } // Incorrect number for PASA
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Your number and password does not match. Try again.");
                    Console.WriteLine("Enter your Mobile Number");
                    userNumber = Console.ReadLine();
                    Console.WriteLine("Password");
                    userPin = Console.ReadLine();
                } // Para kapag mali - dito pupunta
            }
        }
    }
}