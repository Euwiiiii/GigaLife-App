using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class POffers
{
    static GigaLife info = new GigaLife();

    // int updateLoad = UpdatedLoad();
    // int updateMagic = UpdatedMagic();
    // double updatePoints = r


    public static void HomeMenu()
    {      

        Console.WriteLine("1. DON'T MISS OUT!");
        Console.WriteLine("2. DOUBLE GIGA +");
        Console.WriteLine("3. GIGA EVERYDAY");
        Console.WriteLine("4. POWER ALL");
        Console.WriteLine("5. ALL DATA");
        Console.WriteLine("6. ALLNET");
        Console.WriteLine("7. Exit");


        Offers[] offer = AvailableOffers.ArrayOffers();

        var userChoice = UserInput();
        switch (userChoice)
        {
            case "1":
                Console.WriteLine("DON'T MISS OUT!");
                Console.WriteLine("1. DOUBLE GIGA+");
                Console.WriteLine("2. MAGIC DATA+");
                Console.WriteLine("3. Back");
                userChoice = UserInput();
                if (userChoice == "1")
                {
                    Console.WriteLine("DOUBLE GIGA+");
                    Console.WriteLine("1. DOUBLE GIGA VIDEO+ 130");
                    Console.WriteLine("2. DOUBLE GIGA VIDEO+ 399");
                    Console.WriteLine("3. DOUBLE GIGA STORIES+ 130");
                    Console.WriteLine("4. DOUBLE GIGA STORIES+ 399");
                    userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            AcquireVideoPlus(new Offers[] { offer[0] });
                            GigaLife.subscription(new Offers[] { offer[0] });
                            Confirmation(new Offers[] { offer[0] }, info);
                            break;
                        case "2":
                            AcquireVideoPlus(new Offers[] { offer[1] });
                            GigaLife.subscription(new Offers[] { offer[1] });
                            Confirmation(new Offers[] { offer[1] }, info);
                            break;
                        case "3":
                            AcquireStoriesPlus(new Offers[] { offer[2] });
                            GigaLife.subscription(new Offers[] { offer[2] });
                            Confirmation(new Offers[] { offer[2] }, info);
                            break;
                        case "4":
                            AcquireStoriesPlus(new Offers[] { offer[3] });
                            GigaLife.subscription(new Offers[] { offer[3] });
                            Confirmation(new Offers[] { offer[3] }, info);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("MAGIC DATA+");
                    Console.WriteLine("1. MAGIC DATA+ 499");
                    Console.WriteLine("2. MAGIC DATA+ 749");
                    Console.WriteLine("3. Back");
                    userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            AcquireMagicPlus(new Offers[] { offer[4] });
                            GigaLife.subscription(new Offers[] { offer[4] });
                            Confirmation(new Offers[] { offer[4] }, info);
                            break;
                        case "2":
                            AcquireMagicPlus(new Offers[] { offer[5] });
                            GigaLife.subscription(new Offers[] { offer[5] });
                            Confirmation(new Offers[] { offer[5] }, info);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
                break;
            case "2":
                Console.WriteLine("NEW & IMPROVED DOUBLE GIGA+");
                Console.WriteLine("WITH UNLI ALLNET CALSS & TEXTS");
                Console.WriteLine("2 GB GIGA EVERY DAY");
                Console.WriteLine("1. VIDEO");
                Console.WriteLine("2. STORIES");
                Console.WriteLine("3. Back");
                userChoice = UserInput();
                if (userChoice == "1")
                {
                    Console.WriteLine("1. DOUBLE GIGA VIDEO+ 65");
                    Console.WriteLine("2. DOUBLE GIGA VIDEO+ 130");
                    Console.WriteLine("3. DOUBLE GIGA VIDEO+ 399");
                    Console.WriteLine("4. Back");
                    userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            AcquireVideoPlus(new Offers[] { offer[6] });
                            GigaLife.subscription(new Offers[] { offer[6] });
                            Confirmation(new Offers[] { offer[6] }, info);
                            break;
                        case "2":
                            AcquireVideoPlus(new Offers[] { offer[0] });
                            GigaLife.subscription(new Offers[] { offer[0] });
                            Confirmation(new Offers[] { offer[0] }, info);
                            break;
                        case "3":
                            AcquireVideoPlus(new Offers[] { offer[1] });
                            GigaLife.subscription(new Offers[] { offer[1] });
                            Confirmation(new Offers[] { offer[1] }, info);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("1. DOUBLE GIGA STORIES+ 65");
                    Console.WriteLine("2. DOUBLE GIGA STORIES+ 130");
                    Console.WriteLine("3. DOUBLE GIGA STORIES+ 399");
                    Console.WriteLine("4. Back");
                    userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            AcquireStoriesPlus(new Offers[] { offer[7] });
                            GigaLife.subscription(new Offers[] { offer[7] });
                            Confirmation(new Offers[] { offer[7] }, info);
                            break;
                        case "2":
                            AcquireStoriesPlus(new Offers[] { offer[2] });
                            GigaLife.subscription(new Offers[] { offer[2] });
                            Confirmation(new Offers[] { offer[2] }, info);
                            break;
                        case "3":
                            AcquireStoriesPlus(new Offers[] { offer[3] });
                            GigaLife.subscription(new Offers[] { offer[3] });
                            Confirmation(new Offers[] { offer[3] }, info);
                            break;
                        case "4":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
                break;
            case "3":
                Console.WriteLine("GIGA EVERYDAY");
                Console.WriteLine("1. POWER");
                Console.WriteLine("2. POWER+");
                Console.WriteLine("3. VIDEO");
                Console.WriteLine("4. VIDEO+");
                Console.WriteLine("5. STORIES");
                Console.WriteLine("6. STORIES+");
                Console.WriteLine("7. GAMES-1");
                Console.WriteLine("8. GAMES-2");
                Console.WriteLine("9. Back");
                userChoice = UserInput();

                if (userChoice == "1")
                {
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

                    switch (userChoice)
                    {
                        case "1":
                            AcquirePower(new Offers[] { offer[8] });
                            GigaLife.subscription(new Offers[] { offer[8] });
                            Confirmation(new Offers[] { offer[8] }, info);
                            break;
                        case "2":
                            AcquirePower(new Offers[] { offer[9] });
                            GigaLife.subscription(new Offers[] { offer[9] });
                            Confirmation(new Offers[] { offer[9] }, info);
                            break;
                        case "3":
                            AcquirePower(new Offers[] { offer[10] });
                            GigaLife.subscription(new Offers[] { offer[10] });
                            Confirmation(new Offers[] { offer[10] }, info);
                            break;
                        case "4":
                            AcquirePower(new Offers[] { offer[11] });
                            GigaLife.subscription(new Offers[] { offer[11] });
                            Confirmation(new Offers[] { offer[11] }, info);
                            break;
                        case "5":
                            AcquirePower(new Offers[] { offer[12] });
                            GigaLife.subscription(new Offers[] { offer[12] });
                            Confirmation(new Offers[] { offer[12] }, info);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "2")
                {
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

                    switch (userChoice)
                    {
                        case "1":
                            AcquirePowerPlus(new Offers[] { offer[13] });
                            GigaLife.subscription(new Offers[] { offer[13] });
                            Confirmation(new Offers[] { offer[13] }, info);
                            break;
                        case "2":
                            AcquirePowerPlus(new Offers[] { offer[14] });
                            GigaLife.subscription(new Offers[] { offer[14] });
                            Confirmation(new Offers[] { offer[14] }, info);
                            break;
                        case "3":
                            AcquirePowerPlus(new Offers[] { offer[15] });
                            GigaLife.subscription(new Offers[] { offer[15] });
                            Confirmation(new Offers[] { offer[15] }, info);
                            break;
                        case "4":
                            AcquirePowerPlus(new Offers[] { offer[16] });
                            GigaLife.subscription(new Offers[] { offer[16] });
                            Confirmation(new Offers[] { offer[16] }, info);
                            break;
                        case "5":
                            AcquirePowerPlus(new Offers[] { offer[17] });
                            GigaLife.subscription(new Offers[] { offer[17] });
                            Confirmation(new Offers[] { offer[17] }, info);
                            break;
                        case "6":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "3")
                {
                    Console.WriteLine("Up to 5x GigaPoints");
                    Console.WriteLine("VIDEO EVERYDAY");
                    Console.WriteLine("1GB VIDEO EVERY DAY");
                    Console.WriteLine("1. 3 Days (2GB)        P50");
                    Console.WriteLine("2. 7 Days (6GB)        P99");
                    Console.WriteLine("3. 30 Days (24GB)     P299");
                    Console.WriteLine("4. Back");
                    userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            AcquireVideo(new Offers[] { offer[18] });
                            GigaLife.subscription(new Offers[] { offer[18] });
                            Confirmation(new Offers[] { offer[18] }, info);
                            break;
                        case "2":
                            AcquireVideo(new Offers[] { offer[19] });
                            GigaLife.subscription(new Offers[] { offer[19] });
                            Confirmation(new Offers[] { offer[19] }, info);
                            break;
                        case "3":
                            AcquireVideo(new Offers[] { offer[20] });
                            GigaLife.subscription(new Offers[] { offer[20] });
                            Confirmation(new Offers[] { offer[20] }, info);
                            break;
                        case "4":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "4")
                {
                    Console.WriteLine("Up to 5x GigaPoints");
                    Console.WriteLine("VIDEO+ EVERYDAY");
                    Console.WriteLine("1GB VIDEO EVERY DAY");
                    Console.WriteLine("+Unli Allnet Calls & Texts");
                    Console.WriteLine("1. 3 Days (1GB)         P75");
                    Console.WriteLine("2. 7 Days (2GB)        P149");
                    Console.WriteLine("3. 30 Days (4GB)       P449");
                    Console.WriteLine("4. Back");
                    userChoice = UserInput();

                    switch (userChoice)
                    {
                        case "1":
                            AcquireVideoPlus(new Offers[] { offer[21] });
                            GigaLife.subscription(new Offers[] { offer[21] });
                            Confirmation(new Offers[] { offer[21] }, info);
                            break;
                        case "2":
                            AcquireVideoPlus(new Offers[] { offer[22] });
                            GigaLife.subscription(new Offers[] { offer[22] });
                            Confirmation(new Offers[] { offer[22] }, info);
                            break;
                        case "3":
                            AcquireVideoPlus(new Offers[] { offer[23] });
                            GigaLife.subscription(new Offers[] { offer[23] });
                            Confirmation(new Offers[] { offer[23] }, info);
                            break;
                        case "4":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "5")
                {
                    Console.WriteLine("Up to 5x GigaPoints");
                    Console.WriteLine("STORIES EVERYDAY");
                    Console.WriteLine("1GB STORIES EVERY DAY");
                    Console.WriteLine("1. 3 Days (1GB)         P50");
                    Console.WriteLine("2. 7 Days (2GB)         P99");
                    Console.WriteLine("3. 30 Days (4GB)       P299");
                    Console.WriteLine("4. Back");
                    userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            AcquireStories(new Offers[] { offer[24] });
                            GigaLife.subscription(new Offers[] { offer[24] });
                            Confirmation(new Offers[] { offer[24] }, info);
                            break;
                        case "2":
                            AcquireStories(new Offers[] { offer[25] });
                            GigaLife.subscription(new Offers[] { offer[25] });
                            Confirmation(new Offers[] { offer[25] }, info);
                            break;
                        case "3":
                            AcquireStories(new Offers[] { offer[26] });
                            GigaLife.subscription(new Offers[] { offer[26] });
                            Confirmation(new Offers[] { offer[26] }, info);
                            break;
                        case "4":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "6")
                {
                    Console.WriteLine("Up to 5x GigaPoints");
                    Console.WriteLine("STORIES+ EVERYDAY");
                    Console.WriteLine("1GB STORIES+ EVERY DAY");
                    Console.WriteLine("+ Unli Allnet Calls & Texts");
                    Console.WriteLine("1. 3 Days (1GB)          P75");
                    Console.WriteLine("2. 7 Days (2GB)         P149");
                    Console.WriteLine("3. 30 Days (4GB)        P499");
                    Console.WriteLine("4. Back");
                    userChoice = UserInput();

                    switch (userChoice)
                    {
                        case "1":
                            AcquireStoriesPlus(new Offers[] { offer[27] });
                            GigaLife.subscription(new Offers[] { offer[27] });
                            Confirmation(new Offers[] { offer[27] }, info);
                            break;
                        case "2":
                            AcquireStoriesPlus(new Offers[] { offer[28] });
                            GigaLife.subscription(new Offers[] { offer[28] });
                            Confirmation(new Offers[] { offer[28] }, info);
                            break;
                        case "3":
                            AcquireStoriesPlus(new Offers[] { offer[29] });
                            GigaLife.subscription(new Offers[] { offer[29] });
                            Confirmation(new Offers[] { offer[29] }, info);
                            break;
                        case "4":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "7")
                {
                    Console.WriteLine("Up to 5x GigaPoints");
                    Console.WriteLine("GAMES-1 EVERYDAY");
                    Console.WriteLine("1GB GAME EVERY DAY");
                    Console.WriteLine("1. 3 Days (1GB)          P50");
                    Console.WriteLine("2. 7 Days (2GB)          P99");
                    Console.WriteLine("3. 30 Days (4GB)        P299");
                    Console.WriteLine("4. Back");
                    userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            AcquireGames(new Offers[] { offer[30] });
                            GigaLife.subscription(new Offers[] { offer[30] });
                            Confirmation(new Offers[] { offer[30] }, info);
                            break;
                        case "2":
                            AcquireGames(new Offers[] { offer[31] });
                            GigaLife.subscription(new Offers[] { offer[31] });
                            Confirmation(new Offers[] { offer[31] }, info);
                            break;
                        case "3":
                            AcquireGames(new Offers[] { offer[32] });
                            GigaLife.subscription(new Offers[] { offer[32] });
                            Confirmation(new Offers[] { offer[32] }, info);
                            break;
                        case "4":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;

                    }
                }
                else if (userChoice == "8")
                {
                    Console.WriteLine("Up to 5x GigaPoints");
                    Console.WriteLine("GAMES-2 EVERYDAY");
                    Console.WriteLine("1GB GAME EVERY DAY");
                    Console.WriteLine("1. 3 Days (1GB)          P50");
                    Console.WriteLine("2. 7 Days (2GB)          P99");
                    Console.WriteLine("3. 30 Days (4GB)        P299");
                    Console.WriteLine("4. Back");
                    userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            AcquireGames(new Offers[] { offer[33] });
                            GigaLife.subscription(new Offers[] { offer[33] });
                            Confirmation(new Offers[] { offer[33] }, info);
                            break;
                        case "2":
                            AcquireGames(new Offers[] { offer[34] });
                            GigaLife.subscription(new Offers[] { offer[34] });
                            Confirmation(new Offers[] { offer[34] }, info);
                            break;
                        case "3":
                            AcquireGames(new Offers[] { offer[35] });
                            GigaLife.subscription(new Offers[] { offer[35] });
                            Confirmation(new Offers[] { offer[35] }, info);
                            break;
                        case "4":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "9")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
                break;
            case "4":
                Console.WriteLine("Up to 5x GigaPoints");
                Console.WriteLine("New");
                Console.WriteLine("    POWERALL");
                Console.WriteLine("with FREE UNLI TikTok EVERY DAY\n  + Shareable Data & Unli Allnet Texts");
                Console.WriteLine("1. 7 Days (8GB)           P99");
                Console.WriteLine("2. 7 Days (12GB)         P149");
                Console.WriteLine("3. Back");
                userChoice = UserInput();
                if (userChoice == "1")
                {
                    AcquirePower(new Offers[] { offer[36] });
                    GigaLife.subscription(new Offers[] { offer[36] });
                    Confirmation(new Offers[] { offer[36] }, info);
                }
                else if (userChoice == "2")
                {
                    AcquirePower(new Offers[] { offer[37] });
                    GigaLife.subscription(new Offers[] { offer[37] });
                    Confirmation(new Offers[] { offer[37] }, info);
                }
                else if (userChoice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }

                break;
            case "5": // deleted 5G
                Console.WriteLine("Up to 5x GigaPoints");
                Console.WriteLine("ALL Data Offers");
                Console.WriteLine("1. ALL DATA");
                Console.WriteLine("2. ALl DATA+");
                Console.WriteLine("3. MAGIC DATA");
                Console.WriteLine("4. MAGIC DATA+");
                Console.WriteLine("5. Back");
                userChoice = UserInput();

                if (userChoice == "1")
                {
                    Console.WriteLine(" Up to 5x GigaPoints");
                    Console.WriteLine("1. 3 Days (2G)               P50");
                    Console.WriteLine("2. 7 Days (6GB)              P99");
                    Console.WriteLine("3. 30 Days (24GB)            P299");
                    Console.WriteLine("4. 30 Days (36GB)            P399");
                    Console.WriteLine("5. 30 Days (48GB)            P499");
                    Console.WriteLine("6. Back");
                    userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            AcquireAllDATA(new Offers[] { offer[38] });
                            GigaLife.subscription(new Offers[] { offer[38] });
                            Confirmation(new Offers[] { offer[38] }, info);
                            break;
                        case "2":
                            AcquireAllDATA(new Offers[] { offer[39] });
                            GigaLife.subscription(new Offers[] { offer[39] });
                            Confirmation(new Offers[] { offer[39] }, info);
                            break;
                        case "3":
                            AcquireAllDATA(new Offers[] { offer[40] });
                            GigaLife.subscription(new Offers[] { offer[40] });
                            Confirmation(new Offers[] { offer[40] }, info);
                            break;
                        case "4":
                            AcquireAllDATA(new Offers[] { offer[41] });
                            GigaLife.subscription(new Offers[] { offer[41] });
                            Confirmation(new Offers[] { offer[42] }, info);
                            break;
                        case "5":
                            AcquireAllDATA(new Offers[] { offer[42] });
                            GigaLife.subscription(new Offers[] { offer[42] });
                            Confirmation(new Offers[] { offer[42] }, info);
                            break;
                        case "6":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "2")
                {
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

                    switch (userChoice)
                    {
                        case "1":
                            AcquireAllDATA(new Offers[] { offer[43] });
                            GigaLife.subscription(new Offers[] { offer[43] });
                            Confirmation(new Offers[] { offer[43] }, info);
                            break;
                        case "2":
                            AcquireAllDATA(new Offers[] { offer[44] });
                            GigaLife.subscription(new Offers[] { offer[44] });
                            Confirmation(new Offers[] { offer[44] }, info);
                            break;
                        case "3":
                            AcquireAllDATA(new Offers[] { offer[45] });
                            GigaLife.subscription(new Offers[] { offer[45] });
                            Confirmation(new Offers[] { offer[45] }, info);
                            break;
                        case "4":
                            AcquireAllDATA(new Offers[] { offer[46] });
                            GigaLife.subscription(new Offers[] { offer[46] });
                            Confirmation(new Offers[] { offer[46] }, info);
                            break;
                        case "5":
                            AcquireAllDATA(new Offers[] { offer[47] });
                            GigaLife.subscription(new Offers[] { offer[47] });
                            Confirmation(new Offers[] { offer[47] }, info);
                            break;
                        case "6":
                            break;
                    }
                }
                else if (userChoice == "3")
                {
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

                    switch (userChoice)
                    {
                        case "1":
                            AcquireMagic(new Offers[] { offer[48] });
                            GigaLife.subscription(new Offers[] { offer[48] });
                            Confirmation(new Offers[] { offer[48] }, info);
                            break;
                        case "2":
                            AcquireMagic(new Offers[] { offer[49] });
                            GigaLife.subscription(new Offers[] { offer[49] });
                            Confirmation(new Offers[] { offer[49] }, info);
                            break;
                        case "3":
                            AcquireMagic(new Offers[] { offer[50] });
                            GigaLife.subscription(new Offers[] { offer[50] });
                            Confirmation(new Offers[] { offer[50] }, info);
                            break;
                        case "4":
                            AcquireMagic(new Offers[] { offer[51] });
                            GigaLife.subscription(new Offers[] { offer[51] });
                            Confirmation(new Offers[] { offer[51] }, info);
                            break;
                        case "5":
                            AcquireMagic(new Offers[] { offer[52] });
                            GigaLife.subscription(new Offers[] { offer[52] });
                            Confirmation(new Offers[] { offer[52] }, info);
                            break;
                        case "6":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (userChoice == "4")
                {
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

                    switch (userChoice)
                    {
                        case "1":
                            AcquireMagic(new Offers[] { offer[53] });
                            GigaLife.subscription(new Offers[] { offer[53] });
                            Confirmation(new Offers[] { offer[53] }, info);
                            break;
                        case "2":
                            AcquireMagic(new Offers[] { offer[54] });
                            GigaLife.subscription(new Offers[] { offer[54] });
                            Confirmation(new Offers[] { offer[54] }, info);
                            break;
                        case "3":
                            AcquireMagic(new Offers[] { offer[55] });
                            GigaLife.subscription(new Offers[] { offer[55] });
                            Confirmation(new Offers[] { offer[55] }, info);
                            break;
                        case "4":
                            AcquireMagic(new Offers[] { offer[56] });
                            GigaLife.subscription(new Offers[] { offer[56] });
                            Confirmation(new Offers[] { offer[56] }, info);
                            break;
                        case "5":
                            AcquireMagic(new Offers[] { offer[57] });
                            GigaLife.subscription(new Offers[] { offer[57] });
                            Confirmation(new Offers[] { offer[57] }, info);
                            break;
                        case "6":
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;

                    }
                }
                else if (userChoice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
                break;
            case "6":
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

                switch (userChoice)
                {
                    case "1":
                        AcquireAllnet(new Offers[] { offer[58] });
                        GigaLife.subscription(new Offers[] { offer[58] });
                        Confirmation(new Offers[] { offer[58] }, info);
                        break;
                    case "2":
                        AcquireAllnet(new Offers[] { offer[59] });
                        GigaLife.subscription(new Offers[] { offer[59] });
                        Confirmation(new Offers[] { offer[59] }, info);
                        break;
                    case "3":
                        AcquireAllnet(new Offers[] { offer[60] });
                        GigaLife.subscription(new Offers[] { offer[60] });
                        Confirmation(new Offers[] { offer[60] }, info);
                        break;
                    case "4":
                        AcquireAllnet(new Offers[] { offer[61] });
                        GigaLife.subscription(new Offers[] { offer[61] });
                        Confirmation(new Offers[] { offer[61] }, info);
                        break;
                    case "5":
                        AcquireAllnet(new Offers[] { offer[62] });
                        GigaLife.subscription(new Offers[] { offer[62] });
                        Confirmation(new Offers[] { offer[62] }, info);
                        break;
                    case "6":
                        AcquireAllnet(new Offers[] { offer[63] });
                        GigaLife.subscription(new Offers[] { offer[63] });
                        Confirmation(new Offers[] { offer[63] }, info);
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
                break;
            case "7":
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
    private static string UserInput()
    {
        Console.Write("Enter your Choice: ");
        string userChoice = Console.ReadLine() ?? string.Empty;
        return userChoice;
    }
    public static Results Confirmation(Offers[] array, GigaLife info)
    {
        Results result = new Results();

        var userChoice = UserInput();
        if (userChoice == "1")
        {
            foreach (Offers offer in array)
            {
                if (info.load >= offer.RequireLoad)
                {
                    info.UpdateBalance(offer);
                    info.UpdateShareableData(offer);
                    info.UpdateMagicData(offer);
                    info.UpdateTextCalls(offer);
                    info.GainGigaPoints(offer);

                    Console.WriteLine($"Thank you for subcribing to {offer.Type}");
                    Console.WriteLine($"You recieved {offer.GainPoints}");

                    result.Uload = info.load;
                    result.UPoints = info.gigaPoints;
                    result.UMagicData = info.magicData;
                    result.UCallsTexts = info.limitedCallsTexts;
                }
                else
                {
                    Console.WriteLine("Insuficient Balacne");
                }
            }
        }



        return result;
    }
    public static void AcquireStoriesPlus(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about to subcribe to {offer.Type}");
                Console.WriteLine($"{offer.Add} & TOTAL {offer.TotalEverydayGB} GB: {offer.EverydayGB} GB STORIES \n EVERY DAY for TikTok, IG, FB, Twitter, Kumu {offer.Add} GB for {offer.Date} days");
                Console.WriteLine($"Get {offer.Percentage} % GigaPoints as Cashback");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");

            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }
        }
    }
    public static void AcquireStories(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about to subcribe to {offer.Type}");
                Console.WriteLine($"{offer.EverydayGB} GB STORIES EVERY DAY for TikTok, IG, FB, Twitter, \nKumu (TOTAL{offer.TotalEverydayGB} + {offer.Add} GB for {offer.Date} days");
                Console.WriteLine($"Get {offer.Percentage} % GigaPoints as Cashback");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");

            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }
        }
    }
    public static void AcquireMagicPlus(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about to subcribe to {offer.Type}");
                Console.WriteLine($"{offer.MagicGB} GB MAGIC DATA FOR ALL SITES + {offer.CallText} Mins Allnet Calls + {offer.CallText} Allnet Texts (NO EXPIRY)");
                Console.WriteLine($"Get {offer.Percentage} % GigaPoints as Cashback");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");
            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }
        }
    }
    public static void AcquireVideoPlus(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about to subcribe to {offer.Type}");
                Console.WriteLine($"{offer.Add} & TOTAL {offer.TotalEverydayGB} GB: {offer.EverydayGB} GB VIDEO \n EVERY DAY for YouTube, Netflix, Smart Livestream, \n iWantTFC + {offer.Add} GB for {offer.Date} days");
                Console.WriteLine($"Get {offer.Percentage} % GigaPoints as Cashback");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");

            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }
        }
    }
    public static void AcquireVideo(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about to subcribe to {offer.Type}");
                Console.WriteLine($"{offer.EverydayGB} VIDEO EVERYDAY for YouTube, Netflix, Smart\nLivestream, iWantTFC + {offer.ShareableGB} GB {offer.Add} for {offer.Date} days");
                Console.WriteLine($"Get {offer.Percentage}% GigaPoints as Cashback!");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");
            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }
        }
    }
    public static void AcquirePower(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about to subcribe to {offer.Type}");
                Console.WriteLine($"{offer.EverydayGB} POWER EVERYDAY FOR ALL SITE & APPS + {offer.ShareableGB}\nGB Shareable Data for {offer.Date} days.");
                Console.WriteLine($"Get {offer.Percentage}% GigaPoints as Cashback!");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");
            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }
        }
    }
    public static void AcquirePowerPlus(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about to subcribe to {offer.Type}");
                Console.WriteLine($"{offer.EverydayGB} POWER EVERYDAY FOR ALL SITE & APPS + {offer.ShareableGB}\nGB Shareable Data + {offer.Add} for {offer.Date}\ndays.");
                Console.WriteLine($"Get {offer.Percentage}  GigaPoints as Cashback!");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");
            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }

        }
    }
    public static void AcquireGames(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about subcribe to {offer.Type}");
                Console.WriteLine($"{offer.EverydayGB} GB GAMES EVERYDAY for {offer.Add} + {offer.ShareableGB} GB +\nfor {offer.Date} days");
                Console.WriteLine($"Get {offer.Percentage}% GigaPoints as Cashback");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");
            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }
        }
    }
    public static void AcquireAllDATA(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about to subcribe to {offer.Type}");
                Console.WriteLine($"{offer.ShareableGB} GB SHARABLE DATA FOR ALL SITES {offer.Add} for {offer.Date} days");
                Console.WriteLine($"Get {offer.Percentage}% GigaPoints as Cashback");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");
            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }
        }
    }
    public static void AcquireAllnet(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about to subscribe to {offer.Type}");
                Console.WriteLine($"{offer.ShareableGB} MB + Unli Allnet Calls & Texts for {offer.Date}");
                Console.WriteLine($"Get {offer.Percentage}% GigaPoints as Cashback");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");
            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }

        }

    }
    public static void AcquireMagic(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Console.WriteLine($"You are about to subcribe to {offer.Type}");
                Console.WriteLine($"{offer.ShareableGB} GB MAGIC DATA FOR ALL SITES {offer.CallText} {offer.Add} (NO EXPIRY)");
                Console.WriteLine($"Get {offer.Percentage}% GigaPoints as Cashback");
                Console.WriteLine("Payment Method");
                Console.WriteLine($"       Load: P {info.load}");
                Console.WriteLine($"Amount           p{offer.RequireLoad}");
                Console.WriteLine("1. Subscribe         2. Cancel");
            }
            else
            {
                Console.WriteLine("Insifficient load Balance");
            }
        }
    }
    public static int UpdatedLoad()
    {
        return info.load;
    }
    public static double UpdatePoints()
    {
        return info.gigaPoints;
    }
    public static int UpdateMagic()
    {
        return info.magicData;
    }
    public static int UpdateShareable()
    {
        return info.shareableData;
    }
    public static int UpdateCallsTexts()
    {
        return info.limitedCallsTexts;
    }
}