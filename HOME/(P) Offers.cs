using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class POffers
{
    static GigaLife info = new GigaLife();
    static Results result = new Results();
    static int updateLoad = UpdatedLoad();
    /* public double UPoints = info.gigaPoints;
    public int UCallText = info.limitedCallsTexts;
    public int Usharable = info.shareableData;
    

       
    /*public static void AcquireStoriePlus(Offers[] array)
    {
        foreach(Offers offer in array)
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
    }*/
    public static void HomeMenu()
    {
        // Results result = new Results();

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
                Console.WriteLine("3. Exit");
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
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
            case "7":
                if (userChoice == "7")
                {
                    break;
                }
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
                    info.UpdateBalance();
                    info.UpdateShareableData(offer);
                    info.GainGigaPoints(offer);
                    info.UpdateMagicData(offer);
                    info.UpdateTextCalls(offer);
                    Console.WriteLine($"Thank you for subcribing to {offer.Type}");
                    Console.WriteLine($"You recieved {offer.GainPoints}");
                    Console.WriteLine("gigapoint" + info.gigaPoints);

                    Console.WriteLine(info.load);
                }
                else
                {
                    Console.WriteLine("Insuficient Balacne");
                }
            }
        }

        result.Uload = info.load;
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
    public static int UpdatedLoad()
    {
        return info.load;
    }

}