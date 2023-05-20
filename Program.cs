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

            // inside HOME
            int load = 5000, sharable = 6000, everDay = 2;
            string? subscription = "GIGA POWER 149";
            // OFFERS + POINTS
            int subOffers_50 = 50, subOffers_65 = 65, subOffers_75 = 75, subOffers_99 = 99, subOffers_130 = 130, subOffers_149 = 149, subOffers_199 = 199, subOffers_299 = 299 ;
            int subOffers_399 = 399, subOffers_449 = 449, subOffers_499 = 499, subOffers_599 = 599, subOffers_699 = 699, subOffers_799 = 799, subOffers_899 = 899;

            // inside PASA
            string? pasaNo = "09496314907";
            string? pasaNoInput;
            string? con, pasa;


            // intro
            string? mobileNumber = "09206420898";
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
                    Console.WriteLine("4. Account");
                    Console.WriteLine("5. Exit");
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
                                    if (points < subOffers_99)
                                    {
                                        Console.WriteLine("Insufficient GigaPoints");
                                    }
                                    if (points > subOffers_99)
                                    {
                                        int remaining1 = points - subOffers_99;
                                        Console.WriteLine("You have choosen GIGA VIDEO 99.");
                                        Console.WriteLine("Your remaining points is " + remaining1 + " points");
                                        Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                    }
                                    break;
                                case "2":
                                    if (points < subOffers_99)
                                    {
                                        Console.WriteLine("Insufficient GigaPoints");
                                    }
                                    if (points > subOffers_99)
                                    {
                                        int remaining2 = points - subOffers_99;
                                        Console.WriteLine("You have choosen GIGA STORIES 99.");
                                        Console.WriteLine("Your remaining points is " + remaining2 + " points");
                                        Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                    }
                                    break;
                                case "3":
                                    if (points < subOffers_149)
                                    {
                                        Console.WriteLine("Insufficient GigaPoints");
                                    }
                                    if (points > subOffers_149)
                                    {
                                        int remaining3 = points - subOffers_149;
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
                                            if (points < subOffers_99)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > subOffers_99)
                                            {
                                                int remaining1 = points - subOffers_99;
                                                Console.WriteLine("You have choosen GIGA VIDEO 99.");
                                                Console.WriteLine("Your remaining points is " + remaining1 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                        case "2":
                                            if (points < subOffers_99)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > subOffers_99)
                                            {
                                                int remaining2 = points - subOffers_99;
                                                Console.WriteLine("You have choosen GIGA STORIES 99.");
                                                Console.WriteLine("Your remaining points is " + remaining2 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                        case "3":
                                            if (points < subOffers_99)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > subOffers_99)
                                            {
                                                int remaining3 = points - subOffers_99;
                                                Console.WriteLine("You have choosen ALL NET 99.");
                                                Console.WriteLine("Your remaining points is " + remaining3 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                        case "4":
                                            if (points < subOffers_99)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > subOffers_99)
                                            {
                                                int remaining4 = points - subOffers_99;
                                                Console.WriteLine("You have choosen MAGIC DATA 99.");
                                                Console.WriteLine("Your remaining points is " + remaining4 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                        case "5":
                                            if (points < subOffers_99)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > subOffers_99)
                                            {
                                                int remaining5 = points - subOffers_99;
                                                Console.WriteLine("You have choosen ALL DATA 99.");
                                                Console.WriteLine("Your remaining points is " + remaining5 + " points");
                                                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                                            }
                                            break;
                                        case "6":
                                            if (points < subOffers_149)
                                            {
                                                Console.WriteLine("Insufficient GigaPoints");
                                            }
                                            if (points > subOffers_149)
                                            {
                                                int remaining6 = points - subOffers_149;
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
                                case "2": // Offers
                                    Console.WriteLine("1. DON'T MISS OUT!");
                                    Console.WriteLine("2. HOT DEALS");
                                    Console.WriteLine("3. DOUBLE GIGA +");
                                    Console.WriteLine("4. GIGA EVERYDAY");
                                    Console.WriteLine("5. POWER ALL");
                                    Console.WriteLine("6. ALL DATA");
                                    Console.WriteLine("7. ALLNET");
                                    Console.WriteLine("8. Exit");

                                    string?
                                        homePromo = Console.ReadLine();
                                    while (homePromo != "8")
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
                                                                        if (subOffers_130 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_130 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA VIDEO+ 130!");
                                                                            Console.WriteLine("            You received 6.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_130) + ".00");
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
                                                                        if (subOffers_399 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_399 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA VIDEO+ 399!");
                                                                            Console.WriteLine("            You received 19.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_399) + ".00");
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
                                                                        if (subOffers_130 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_130 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA STORIES+ 130!");
                                                                            Console.WriteLine("            You received 6.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_130) + ".00");
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
                                                                        if (subOffers_399 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_399 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA STORIES+ 399!");
                                                                            Console.WriteLine("            You received 19.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_399) + ".00");
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
                                                                if (subOffers_149 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Balance");
                                                                }
                                                                if (subOffers_149 <= load)
                                                                {
                                                                    Console.WriteLine("Thank you for subcribing to POWER ALL 149");
                                                                    Console.WriteLine("            You received 7.45 Giga Points!");
                                                                    Console.WriteLine("Your new balance load: P" + (load - subOffers_149) + ".00");
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
                                                                        if (subOffers_65 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_65 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA VIDEO+ 65!");
                                                                            Console.WriteLine("            You received 0.65 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_65) + ".00");
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
                                                                        if (subOffers_130 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_130 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA VIDEO+ 130!");
                                                                            Console.WriteLine("            You received 6.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_130) + ".00");
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
                                                                        if (subOffers_399 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_399 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA VIDEO+ 399!");
                                                                            Console.WriteLine("            You received 19.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_399) + ".00");
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
                                                                        if (subOffers_65 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_65 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA STORIES+ 65!");
                                                                            Console.WriteLine("            You received 0.65 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_65) + ".00");
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
                                                                        if (subOffers_130 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_130 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA STORIES+ 130!");
                                                                            Console.WriteLine("            You received 6.5  Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_130) + ".00");
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
                                                                        if (subOffers_399 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_399 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subscribing to DOUBLE GIGA STORIES+ 399!");
                                                                            Console.WriteLine("            You received 19.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_399) + ".00");
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
                                                                        if (subOffers_75 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_75 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER 75");
                                                                            Console.WriteLine("            You received 3.75 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_75) + ".00");
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
                                                                        if (subOffers_499 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_499 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER 499");
                                                                            Console.WriteLine("            You received 24.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_499) + ".00");
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
                                                                        if (subOffers_699 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_699 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER 599");
                                                                            Console.WriteLine("            You received 34.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_699) + ".00");
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
                                                                        if (subOffers_199 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_199 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER+ 199");
                                                                            Console.WriteLine("            You received 9.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_199) + ".00");
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
                                                                        if (subOffers_699 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_699 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER+ 699");
                                                                            Console.WriteLine("            You received 34.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_699) + ".00");
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
                                                                        if (subOffers_799 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_799 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER+ 799");
                                                                            Console.WriteLine("            You received 39.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_799) + ".00");
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
                                                                        if (subOffers_899 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_899 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA POWER+ 899");
                                                                            Console.WriteLine("            You received 44.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_899) + ".00");
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
                                                                        if (subOffers_50 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_50 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO 50");
                                                                            Console.WriteLine("            You received 0.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_50 + ".00"));
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
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
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
                                                                        if (subOffers_299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_299) + ".00");
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
                                                                        if (subOffers_75 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_75 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO+ 75");
                                                                            Console.WriteLine("            You received 3.75 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_75) + ".00");
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
                                                                        if (subOffers_449 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_449 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO+ 449!");
                                                                            Console.WriteLine("            You received 22.45 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_449) + ".00");
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
                                                                        if (subOffers_50 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_50 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES 50");
                                                                            Console.WriteLine("            You received 0.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_50) + ".00");
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
                                                                        if (subOffers_299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_299) + ".00");
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
                                                                        if (subOffers_75 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_75 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES+ 75");
                                                                            Console.WriteLine("            You received 3.75 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_75) + ".00");
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
                                                                        if (subOffers_449 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_449 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES+ 449");
                                                                            Console.WriteLine("            You received 22.45 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_449) + ".00");
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
                                                                        if (subOffers_50 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_50 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-1 50");
                                                                            Console.WriteLine("            You received 0.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_50) + ".00");
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
                                                                        if (subOffers_299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-1 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_299) + ".00");
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
                                                                        if (subOffers_50 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_50 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-2 50");
                                                                            Console.WriteLine("            You received 0.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_50) + ".00");
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
                                                                        if (subOffers_299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA GAMES-2 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_299) + ".00");
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
                                                                        if (subOffers_299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA VIDEO  299");
                                                                            Console.WriteLine("            You received 14.955 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_299) + ".00");
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
                                                                        if (subOffers_299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to GIGA STORIES 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_299) + ".00");
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
                                                Console.WriteLine("1. 7 Days (8GB)           P99");
                                                Console.WriteLine("2. 7 Days (12GB)         P149");
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
                                            case "6": // All Data
                                                Console.WriteLine("Up to 5x GigaPoints");
                                                Console.WriteLine("ALL Data Offers");
                                                Console.WriteLine("1. ALL DATA");
                                                Console.WriteLine("2. ALl DATA+");
                                                Console.WriteLine("3. MAGIC DATA");
                                                Console.WriteLine("4. MAGIC DATA+");
                                                Console.WriteLine("5. UNLI 5G DATA");
                                                Console.WriteLine("6. Exit");
                                                userChoice = Console.ReadLine();

                                                switch (userChoice)
                                                {
                                                    case "1": // ALL DATA
                                                        Console.WriteLine(" Up to 5x GigaPoints");
                                                        Console.WriteLine("1. 3 Days (2G)               P50");
                                                        Console.WriteLine("2. 7 Days (6GB)              P99");
                                                        Console.WriteLine("3. 30 Days (24GB)            P299");
                                                        Console.WriteLine("4. 30 Days (26GB)            P399");
                                                        Console.WriteLine("5. 30 Days (48GB)            P499");
                                                        Console.WriteLine("6. EXit");

                                                        string?
                                                            allData = Console.ReadLine();
                                                        switch (allData)
                                                        {
                                                            case "1": // alldata 50
                                                                Console.WriteLine("You are about to subcribe to ALL DATA 50");
                                                                Console.WriteLine("2 GB SHAREABLE DATA FOR ALL SITES for 3 days");
                                                                Console.WriteLine("Get 1% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P50");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceAll50 = Console.ReadLine();
                                                                switch (choiceAll50)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_50 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_50 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA 50");
                                                                            Console.WriteLine("            You received 0.5 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_50) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2":// alldata 99
                                                                Console.WriteLine("You are about to subcribe to ALL DATA 99");
                                                                Console.WriteLine("6 GB SHAREABLE DATA FOR ALL SITES for 7 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceAll99 = Console.ReadLine();
                                                                switch (choiceAll99)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_99 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_99 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA 99");
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_99) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // alldata 299
                                                                Console.WriteLine("You are about to subcribe to ALL DATA 299");
                                                                Console.WriteLine("24 GB SHAREABLE DATA FOR ALL SITES for 30 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P299");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceAll299 = Console.ReadLine();
                                                                switch (choiceAll299)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA 299");
                                                                            Console.WriteLine("            You received 14.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_299) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "4": // alldata 399
                                                                Console.WriteLine("You are about to subcribe to ALL DATA 399");
                                                                Console.WriteLine("36 GB SHAREABLE DATA FOR ALL SITES for 30 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P399");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceAll399 = Console.ReadLine();
                                                                switch (choiceAll399)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_399 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_399 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA 399");
                                                                            Console.WriteLine("            You received 19.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_399) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "5": // alldata499
                                                                Console.WriteLine("You are about to subcribe to ALL DATA 499");
                                                                Console.WriteLine("48 GB SHAREABLE DATA FOR ALL SITES for 30 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P499");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceAll499 = Console.ReadLine();
                                                                switch (choiceAll499)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_499 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_499 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA 499");
                                                                            Console.WriteLine("            You received 24.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_499) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "2": // ALL DATA+
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("All Data+");
                                                        Console.WriteLine("SHAREABLE DATA FOR ALL SITES");
                                                        Console.WriteLine("       + Unli Allnet Calls & Texts");
                                                        Console.WriteLine("1. 3 Days (2GB)              P75");
                                                        Console.WriteLine("2. 7 Days (6GB)              P149");
                                                        Console.WriteLine("3. 30 Days (24GB)            P499");
                                                        Console.WriteLine("4. 30 Days (36GB)            P599");
                                                        Console.WriteLine("5. 30 Days (48GB)            P699");
                                                        Console.WriteLine("6. Exit");
                                                        userChoice = Console.ReadLine();

                                                        switch (userChoice)
                                                        {
                                                            case "1": // AllData+ 75
                                                                Console.WriteLine("You are about to subcribe to ALL DATA+ 75");
                                                                Console.WriteLine("2 GB SHAREABLE DATA FOR ALL SITES + Unli Allnet\nCalls & Texts for 3 days");
                                                                Console.WriteLine("Get 1% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P75");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceAllPLus75 = Console.ReadLine();
                                                                switch (choiceAllPLus75)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_75 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_75 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA+ 75");
                                                                            Console.WriteLine("            You received 3.75 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_75) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // AllData+ 149
                                                                Console.WriteLine("You are about to subcribe to ALL DATA+ 149");
                                                                Console.WriteLine("6 GB SHAREABLE DATA FOR ALL SITES + Unli Allnet\nCalls & Texts for 7 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P149");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceAllPLus149 = Console.ReadLine();
                                                                switch (choiceAllPLus149)
                                                                {
                                                                    case "1":
                                                                        int allDataPlus149 = 149;
                                                                        if (allDataPlus149 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (allDataPlus149 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA+ 149");
                                                                            Console.WriteLine("            You received 7.45 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - allDataPlus149) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // AllData+499
                                                                Console.WriteLine("You are about to subcribe to ALL DATA+ 499");
                                                                Console.WriteLine("24 GB SHAREABLE DATA FOR ALL SITES + Unli Allnet\nCalls & Texts for 30 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P499");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceAllPlus499 = Console.ReadLine();
                                                                switch (choiceAllPlus499)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_499 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_499 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA+ 499");
                                                                            Console.WriteLine("            You received 24.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_499) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "4": // AllData+ 599
                                                                Console.WriteLine("You are about to subcribe to ALL DATA+ 599");
                                                                Console.WriteLine("36 GB SHAREABLE DATA FOR ALL SITES + Unli Allnet\nCalls & Texts for 30 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P599");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceAllPlus599 = Console.ReadLine();
                                                                switch (choiceAllPlus599)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_599 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_599 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA+ 599");
                                                                            Console.WriteLine("            You received 29.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_599) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "5": // AllData+ 699
                                                                Console.WriteLine("You are about to subcribe to ALL DATA+ 699");
                                                                Console.WriteLine("48 GB SHAREABLE DATA FOR ALL SITES + Unli Allnet\nCalls & Texts for 30 days");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P699");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceAllPlus699 = Console.ReadLine();
                                                                switch (choiceAllPlus699)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_699 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_699 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA+ 699");
                                                                            Console.WriteLine("            You received 34.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_699) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "3": // MAGIC DATA
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("MAGIC DATA");
                                                        Console.WriteLine("MAGIC DATA (NO EXPIRY)");
                                                        Console.WriteLine("    FOR ALL SITES");
                                                        Console.WriteLine("1. No Expiry (2GB)              P99");
                                                        Console.WriteLine("2. No Expiry (6GB)              P199");
                                                        Console.WriteLine("3. No Expiry (24GB)             P399");
                                                        Console.WriteLine("4. No Expiry (36GB)             P499");
                                                        Console.WriteLine("5. No Expiry (48GB)             P599");
                                                        Console.WriteLine("6. Exit");
                                                        userChoice = Console.ReadLine();
                                                        switch (userChoice)
                                                        {
                                                            case "1": // 2GB
                                                                Console.WriteLine("You are about to subcribe to MAGIC DATA 99");
                                                                Console.WriteLine("2 GB MAGIC DATA (NO EXPIRY) FOR ALL SITES");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P99");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceMagic99 = Console.ReadLine();
                                                                switch (choiceMagic99)
                                                                {
                                                                    case "1":
                                                                        int magic99 = 99;
                                                                        if (magic99 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (magic99 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to ALL DATA+ 99");
                                                                            Console.WriteLine("            You received 4,95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - magic99) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // 6GB
                                                                Console.WriteLine("You are about to subcribe to MAGIC DATA 199");
                                                                Console.WriteLine("6 GB MAGIC DATA (NO EXPIRY) FOR ALL SITES");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P199");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceMagic199 = Console.ReadLine();
                                                                switch (choiceMagic199)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_199 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_199 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to MAGIC DATA 199");
                                                                            Console.WriteLine("            You received 4.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_199) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // 24GB
                                                                Console.WriteLine("You are about to subcribe to MAGIC DATA 399");
                                                                Console.WriteLine("24 GB MAGIC DATA (NO EXPIRY) FOR ALL SITES");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P399");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceMagic399 = Console.ReadLine();
                                                                switch (choiceMagic399)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_399 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_399 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to MAGIC DATA 399");
                                                                            Console.WriteLine("            You received Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_399) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "4": // 36GB
                                                                Console.WriteLine("You are about to subcribe to MAGIC DATA 499");
                                                                Console.WriteLine("36 GB MAGIC DATA (NO EXPIRY) FOR ALL SITES");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P499");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceMagic499 = Console.ReadLine();
                                                                switch (choiceMagic499)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_499 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_499 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to MAGIC DATA 499");
                                                                            Console.WriteLine("            You received Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_499) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "5": // 48GB
                                                                Console.WriteLine("You are about to subcribe to MAGIC DATA 599");
                                                                Console.WriteLine("48 GB MAGIC DATA (NO EXPIRY) FOR ALL SITES");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P599");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceMagic599 = Console.ReadLine();
                                                                switch (choiceMagic599)
                                                                {
                                                                    case "1":
                                                                        int magic599 = 599;
                                                                        if (magic599 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (magic599 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to MAGIC DATA 599!");
                                                                            Console.WriteLine("            You received 29.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - magic599) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "4": // MAGIC DATA+ 
                                                        Console.WriteLine("NEW & IMPROVED");
                                                        Console.WriteLine("Magic Data+");
                                                        Console.WriteLine("MAGIC DATA WITH CALLS & TEXTS");
                                                        Console.WriteLine("      WHICH NEVER EXPIRE");
                                                        Console.WriteLine("1. No Expiry (2GB + 50 MINS & TEXTS)              P149");
                                                        Console.WriteLine("2. No Expiry (6GB + 100 MINS & TEXTS)             P299");
                                                        Console.WriteLine("3. No Expiry (24GB + 200 MINS & TEXTS)            P499");
                                                        Console.WriteLine("4. No Expiry (36GB + 300 MINS & TEXTS)            P649");
                                                        Console.WriteLine("5. No Expiry (48GB + 600 MINS & TEXTS)            P749");
                                                        Console.WriteLine("6. Exit");

                                                        userChoice = Console.ReadLine();
                                                        switch (userChoice)
                                                        {
                                                            case "1": // 2GB (149)
                                                                Console.WriteLine("You are about to subcribe to MAGIC DATA+ 149");
                                                                Console.WriteLine("2 GB MAGIC DATA (NO EXPIRY) FOR ALL SITES + 50 Mins Allnet\nCalls + 50 Allnet Texts (NO EXPIRY)");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P149");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceMagicPlus149 = Console.ReadLine();
                                                                switch (choiceMagicPlus149)
                                                                {
                                                                    case "1":
                                                                        int magicPlus149 = 149;
                                                                        if (magicPlus149 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (magicPlus149 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to MAGIC DATA+ 149");
                                                                            Console.WriteLine("            You received 7.45 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - magicPlus149) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // 6GB (299)
                                                                Console.WriteLine("You are about to subcribe to MAGIC DATA+ 299");
                                                                Console.WriteLine("6 GB MAGIC DATA (NO EXPIRY) FOR ALL SITES + 100 Mins Allnet\nCalls + 100 Allnet Texts (NO EXPIRY)");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P299");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceMagicPlus299 = Console.ReadLine();
                                                                switch (choiceMagicPlus299)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to MAGIC DATA+ 299");
                                                                            Console.WriteLine("            You received 5.98 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_299) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // 24GB (499)
                                                                Console.WriteLine("You are about to subcribe to MAGIC DATA+ 499");
                                                                Console.WriteLine("24 GB MAGIC DATA (NO EXPIRY) FOR ALL SITES + 200 Mins Allnet\nCalls + 200 Allnet Texts (NO EXPIRY)");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P499");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceMagicPlus499 = Console.ReadLine();
                                                                switch (choiceMagicPlus499)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_499 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_499 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to MAGIC DATA+ 499");
                                                                            Console.WriteLine("            You received 24.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_499) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "4": //36GB (649)
                                                                Console.WriteLine("You are about to subcribe to MAGIC DATA+ 649");
                                                                Console.WriteLine("36 GB MAGIC DATA (NO EXPIRY) FOR ALL SITES + 300 Mins Allnet\nCalls + 300 Allnet Texts (NO EXPIRY)");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P649");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceMagicPlus649 = Console.ReadLine();
                                                                switch (choiceMagicPlus649)
                                                                {
                                                                    case "1":
                                                                        int magicPlus649 = 649;
                                                                        if (magicPlus649 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (magicPlus649 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to MAGIC DATA+ 649");
                                                                            Console.WriteLine("            You received 12.98 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - magicPlus649) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "5": //48 (749)
                                                                Console.WriteLine("You are about to subcribe to MAGIC DATA+ 749");
                                                                Console.WriteLine("36 GB MAGIC DATA (NO EXPIRY) FOR ALL SITES + 600 Mins Allnet\nCalls + 600 Allnet Texts (NO EXPIRY)");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P749");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceMagicPlus749 = Console.ReadLine();
                                                                switch (choiceMagicPlus749)
                                                                {
                                                                    case "1":
                                                                        int magicPlus749 = 749;
                                                                        if (magicPlus749 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (magicPlus749 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to MAGIC DATA+ 749");
                                                                            Console.WriteLine("            You received 37. Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - magicPlus749) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;

                                                        }
                                                        break;
                                                    case "5": // UNLI 5G DATA
                                                        Console.WriteLine("Up to 5x GigaPoints");
                                                        Console.WriteLine("           Unli 5G Data");
                                                        Console.WriteLine("Exclusiively for 5G Certified Devices");
                                                        Console.WriteLine("        in 5G Exlusive Location");
                                                        Console.WriteLine("1. 7 Days Unli 5G (3 GB Non-5G)                P299");
                                                        Console.WriteLine("2. 30 Days Unli 5G (12 GB Non-5G)              P599");
                                                        Console.WriteLine("3. 30 Days Unli 5G (24 GB Non-5G)              P799");
                                                        Console.WriteLine("4. Exit");
                                                        userChoice = Console.ReadLine();

                                                        switch (userChoice)
                                                        {
                                                            case "1": // Unli 5G 299
                                                                Console.WriteLine("You are about to subcribe to UNLI 5G DATA 299");
                                                                Console.WriteLine("UNLI 5G DATA for 7 days + EXTRA 3 GB DATA (when you use in Non-5G areas");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P299");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceUnli299 = Console.ReadLine();
                                                                switch (choiceUnli299)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_299 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_299 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to UNLI 5G DATA 299");
                                                                            Console.WriteLine("            You received Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_299) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "2": // Unli 5G 599
                                                                Console.WriteLine("You are about to subcribe to UNLI 5G DATA 599");
                                                                Console.WriteLine("UNLI 5G DATA for 30 days + EXTRA 12 GB DATA (when you use in Non-5G areas");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P599");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceUnli599 = Console.ReadLine();
                                                                switch (choiceUnli599)
                                                                {
                                                                    case "1":
                                                                        int unli5G599 = 599;
                                                                        if (unli5G599 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (unli5G599 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to UNLI 5G DATA 599");
                                                                            Console.WriteLine("            You received Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - unli5G599) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                            case "3": // Unli 5G 799
                                                                Console.WriteLine("You are about to subcribe to UNLI 5G DATA 799");
                                                                Console.WriteLine("UNLI 5G DATA for 30 days + EXTRA 24 GB DATA (when you use in Non-5G areas");
                                                                Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                                Console.WriteLine("Payment Method");
                                                                Console.WriteLine("       Load: P" + load);
                                                                Console.WriteLine("Amount           P799");
                                                                Console.WriteLine("1. Subscribe         2. Cancel");

                                                                string?
                                                                    choiceUnli799 = Console.ReadLine();
                                                                switch (choiceUnli799)
                                                                {
                                                                    case "1":                                                                        
                                                                        if (subOffers_799 > load)
                                                                        {
                                                                            Console.WriteLine("Sorry. Insuffient Balance");
                                                                        }
                                                                        if (subOffers_799 <= load)
                                                                        {
                                                                            Console.WriteLine("Thank you for subcribing to UNLI 5G DATA 799!");
                                                                            Console.WriteLine("            You received 39.95 Giga Points!");
                                                                            Console.WriteLine("Your new balance load: P" + (load - subOffers_799) + ".00");
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                }
                                                break;
                                            case "7": // ALLNET
                                                Console.WriteLine("Up to 5x GigaPoints");
                                                Console.WriteLine("ALLNET");
                                                Console.WriteLine("Unli Allnet Calls & Texts");
                                                Console.WriteLine("1. 1 Day (100 MB)         P30");
                                                Console.WriteLine("2. 3 Days (500 MB)        P50");
                                                Console.WriteLine("3. 7 Days (1 GB)          P99");
                                                Console.WriteLine("4. 30 Days (2 GB)         P299");
                                                Console.WriteLine("5. 60 Days (4 GB)         P499");
                                                Console.WriteLine("6. 90 Days (6 GB)         P599");
                                                Console.WriteLine("7. Exit");
                                                string?
                                                    userChoiceallNet = Console.ReadLine();
                                                switch (userChoiceallNet)
                                                {
                                                    case "1": // 100 MB
                                                        Console.WriteLine("You are about to subcribe to Allnet 30");
                                                        Console.WriteLine("100 MB + Unli Allnet Calls & Texts for 1 day");
                                                        Console.WriteLine("Get 1% GigaPoints as Cashback!");
                                                        Console.WriteLine("Payment Method");
                                                        Console.WriteLine("       Load: P" + load);
                                                        Console.WriteLine("Amount           P30");
                                                        Console.WriteLine("1. Subscribe         2. Cancel");

                                                        string?
                                                            allnet30 = Console.ReadLine();
                                                        switch (allnet30)
                                                        {
                                                            case "1":
                                                                int allNet30 = 30;
                                                                if (allNet30 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Balance");
                                                                }
                                                                if (allNet30 <= load)
                                                                {
                                                                    Console.WriteLine("Thank you for subcribing to Allnet 30");
                                                                    Console.WriteLine("            You received 0.3 Giga Points!");
                                                                    Console.WriteLine("Your new balance load: P" + (load - allNet30) + ".00");
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "2": // 500 MB
                                                        Console.WriteLine("You are about to subcribe to Allnet 50");
                                                        Console.WriteLine("500 MB + Unli Allnet Calls & Texts for 3 day");
                                                        Console.WriteLine("Get 1% GigaPoints as Cashback!");
                                                        Console.WriteLine("Payment Method");
                                                        Console.WriteLine("       Load: P" + load);
                                                        Console.WriteLine("Amount           P50");
                                                        Console.WriteLine("1. Subscribe         2. Cancel");

                                                        string?
                                                            allnet50 = Console.ReadLine();
                                                        switch (allnet50)
                                                        {
                                                            case "1":
                                                                if (subOffers_50 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Balance");
                                                                }
                                                                if (subOffers_50 <= load)
                                                                {
                                                                    Console.WriteLine("Thank you for subcribing to Allnet 50!");
                                                                    Console.WriteLine("            You received 0.5 Giga Points!");
                                                                    Console.WriteLine("Your new balance load: P" + (load - subOffers_50) + ".00");
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "3": // 1 GB
                                                        Console.WriteLine("You are about to subcribe to Allnet 99");
                                                        Console.WriteLine("1 GB + Unli Allnet Calls & Texts for 7 day");
                                                        Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                        Console.WriteLine("Payment Method");
                                                        Console.WriteLine("       Load: P" + load);
                                                        Console.WriteLine("Amount           P99");
                                                        Console.WriteLine("1. Subscribe         2. Cancel");

                                                        string?
                                                            allnet099 = Console.ReadLine();
                                                        switch (allnet099)
                                                        {
                                                            case "1":
                                                                int allNet099 = 99;
                                                                if (allNet099 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Balance");
                                                                }
                                                                if (allNet099 <= load)
                                                                {
                                                                    Console.WriteLine("Thank you for subcribing to Allnet 99");
                                                                    Console.WriteLine("            You received 4.95 Giga Points!");
                                                                    Console.WriteLine("Your new balance load: P" + (load - allNet099) + ".00");
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "4": // 2 GB
                                                        Console.WriteLine("You are about to subcribe to Allnet 299");
                                                        Console.WriteLine("2 GB + Unli Allnet Calls & Texts for 30 day");
                                                        Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                        Console.WriteLine("Payment Method");
                                                        Console.WriteLine("       Load: P" + load);
                                                        Console.WriteLine("Amount           P299");
                                                        Console.WriteLine("1. Subscribe         2. Cancel");

                                                        string?
                                                            allnet299 = Console.ReadLine();
                                                        switch (allnet299)
                                                        {
                                                            case "1":                                                                
                                                                if (subOffers_299 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Balance");
                                                                }
                                                                if (subOffers_299 <= load)
                                                                {
                                                                    Console.WriteLine("Thank you for subcribing to Allnet 299");
                                                                    Console.WriteLine("            You received Giga Points!");
                                                                    Console.WriteLine("Your new balance load: P" + (load - subOffers_299) + ".00");
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "5": // 4 GB
                                                        Console.WriteLine("You are about to subcribe to Allnet 499");
                                                        Console.WriteLine("4 GB + Unli Allnet Calls & Texts for 60 day");
                                                        Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                        Console.WriteLine("Payment Method");
                                                        Console.WriteLine("       Load: P" + load);
                                                        Console.WriteLine("Amount           P499");
                                                        Console.WriteLine("1. Subscribe         2. Cancel");

                                                        string?
                                                            allnet499 = Console.ReadLine();
                                                        switch (allnet499)
                                                        {
                                                            case "1":                                                                
                                                                if (subOffers_499 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Balance");
                                                                }
                                                                if (subOffers_499 <= load)
                                                                {
                                                                    Console.WriteLine("Thank you for subcribing to Allnet 499!");
                                                                    Console.WriteLine("            You received 24.95 Giga Points!");
                                                                    Console.WriteLine("Your new balance load: P" + (load - subOffers_499) + ".00");
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "6": // 6 GB
                                                        Console.WriteLine("You are about to subcribe to Allnet 599");
                                                        Console.WriteLine("6 GB + Unli Allnet Calls & Texts for 90 day");
                                                        Console.WriteLine("Get 5% GigaPoints as Cashback!");
                                                        Console.WriteLine("Payment Method");
                                                        Console.WriteLine("       Load: P" + load);
                                                        Console.WriteLine("Amount           P599");
                                                        Console.WriteLine("1. Subscribe         2. Cancel");

                                                        string?
                                                            allnet599 = Console.ReadLine();
                                                        switch (allnet599)
                                                        {
                                                            case "1":
                                                                int allNet599 = 599;
                                                                if (allNet599 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Balance");
                                                                }
                                                                if (allNet599 <= load)
                                                                {
                                                                    Console.WriteLine("Thank you for subcribing to Allnet 599!");
                                                                    Console.WriteLine("            You received 29.95 Giga Points!");
                                                                    Console.WriteLine("Your new balance load: P" + (load - allNet599) + ".00");
                                                                }
                                                                break;
                                                        }
                                                        break;
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
                                                Console.WriteLine("4. Pasa Load");
                                                Console.WriteLine("5. Exit");
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
                                                    case "4": // PASA LOAD
                                                        Console.WriteLine("Pasa Load");
                                                        Console.WriteLine("CURRENT SHAREABLE DATA = " + load);
                                                        Console.WriteLine("Select Ammount (This required P1 trasction fee)");
                                                        Console.WriteLine("1. P50");
                                                        Console.WriteLine("2. P100");
                                                        Console.WriteLine("3. P200");
                                                        Console.WriteLine("4. P300");
                                                        Console.WriteLine("5. P500");
                                                        Console.WriteLine("6. 1000");
                                                        string?
                                                            loadAmount = Console.ReadLine();
                                                        switch (loadAmount)
                                                        {
                                                            case "1": // 50
                                                                int pasaLoad50 = 50;
                                                                if (pasaLoad50 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                    break;
                                                                }
                                                                if (pasaLoad50 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send 50.00 load");
                                                                    Console.WriteLine("Valid for 30 days + P1 transaction fee");
                                                                    Console.WriteLine("CURRENT LOAD BALANCE: P"+load);
                                                                    Console.WriteLine("Amount           P" + (pasaLoad50+1) + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                                        confirmation = Console.ReadLine();
                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully P50.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance = " + (load - (pasaLoad50 + 1)));
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "2": // 100
                                                                int pasaLoad100 = 100;
                                                                if (pasaLoad100 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                    break;
                                                                }
                                                                if (pasaLoad100 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send 100.00 load");
                                                                    Console.WriteLine("Valid for 30 days + P1 transaction fee");
                                                                    Console.WriteLine("CURRENT LOAD BALANCE: P" + load);
                                                                    Console.WriteLine("Amount           P" + (pasaLoad100 + 1) + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                                        confirmation = Console.ReadLine();
                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully P100.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance = " + (load - (pasaLoad100 + 1)));
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "3": //200
                                                                int pasaLoad200 = 200;
                                                                if (pasaLoad200 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                    break;
                                                                }
                                                                if (pasaLoad200 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send 200.00 load");
                                                                    Console.WriteLine("Valid for 30 days + P1 transaction fee");
                                                                    Console.WriteLine("CURRENT LOAD BALANCE: P" + load);
                                                                    Console.WriteLine("Amount           P" + (pasaLoad200 + 1) + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                                        confirmation = Console.ReadLine();
                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully P200.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance = " + (load - (pasaLoad200 + 1)));
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "4": // 300
                                                                int pasaLoad300 = 300;
                                                                if (pasaLoad300 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                    break;
                                                                }
                                                                if (pasaLoad300 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send 300.00 load");
                                                                    Console.WriteLine("Valid for 30 days + P1 transaction fee");
                                                                    Console.WriteLine("CURRENT LOAD BALANCE: P" + load);
                                                                    Console.WriteLine("Amount           P" + (pasaLoad300 + 1) + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                                        confirmation = Console.ReadLine();
                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully P300.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance = " + (load - (pasaLoad300 + 1)));
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "5": // 500
                                                                int pasaLoad500 = 500;
                                                                if (pasaLoad500 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                    break;
                                                                }
                                                                if (pasaLoad500 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send 500.00 load");
                                                                    Console.WriteLine("Valid for 30 days + P1 transaction fee");
                                                                    Console.WriteLine("CURRENT LOAD BALANCE: P" + load);
                                                                    Console.WriteLine("Amount           P" + (pasaLoad500 + 1) + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                                        confirmation = Console.ReadLine();
                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully P500.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance = " + (load - (pasaLoad500 + 1)));
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            case "6": //600
                                                                int pasaLoad600 = 600;
                                                                if (pasaLoad600 > load)
                                                                {
                                                                    Console.WriteLine("Sorry. Insuffient Load Balance");
                                                                    break;
                                                                }
                                                                if (pasaLoad600 <= load)
                                                                {
                                                                    Console.WriteLine("You are about to send 600.00 load");
                                                                    Console.WriteLine("Valid for 30 days + P1 transaction fee");
                                                                    Console.WriteLine("CURRENT LOAD BALANCE: P" + load);
                                                                    Console.WriteLine("Amount           P" + (pasaLoad600 + 1) + ".00");
                                                                    Console.WriteLine("Do you want to confirm?");
                                                                    Console.WriteLine("1. Confirm           2. Cancel");
                                                                    string?
                                                                        confirmation = Console.ReadLine();
                                                                    switch (confirmation)
                                                                    {
                                                                        case "1":
                                                                            Console.WriteLine("You have successfully P600.00 load to " + pasaNo);
                                                                            Console.WriteLine("Your current load balance = " + (load - (pasaLoad600 + 1)));
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
                        case "4": // ACCOUNTS
                            Console.WriteLine("1. Link Smart (Prepaid, Postpaid, Bro, Signature");
                            Console.WriteLine("2. Link TNT (TNT)");
                            Console.WriteLine("3. Link PLDT");
                            Console.WriteLine("Accounts");
                            Console.WriteLine("Link more accounts to manage all your numbers");
                            Console.WriteLine(mobileNumber + "(Smart Prepaid)");
                            Console.WriteLine("Do you want to add you another Mobile Number");
                            Console.WriteLine("1. Confirm           2. Cancel");
                            userChoice = Console.ReadLine();
                            string? number;
                            switch (userChoice)
                            {                               
                                case "1": // smart
                                    Console.WriteLine("Link Account");
                                    Console.WriteLine("Add Smart number to easliy manage your accounts");
                                    number = Console.ReadLine();
                                    Console.WriteLine("SUCCESFULLY ADDED");
                                    break;
                                case "2": // TNT
                                    Console.WriteLine("Link Account");
                                    Console.WriteLine("Add TNT number to easliy manage your accounts");
                                    number = Console.ReadLine();
                                    Console.WriteLine("SUCCESFULLY ADDED");
                                    break;
                                case "3": // PLDT
                                    Console.WriteLine("Link Account");
                                    Console.WriteLine("Add PLDT number to easliy manage your accounts");
                                    number = Console.ReadLine();
                                    Console.WriteLine("SUCCESFULLY ADDED");
                                    break;
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