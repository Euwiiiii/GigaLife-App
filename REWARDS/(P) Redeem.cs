using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.XPath;

public class PRewards
{
    static GigaLife info = new GigaLife();
     static double deduction = 0;
    /*static double AddedPoints = POffers.AddPoints(); */
    // static 

    public static double RedeemRewards(Rewards[] array)
    {
        // Result2 result = new Result2();
        double forPoints = GigaLife.returnThisPoints();
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (Rewards reward in array)
        {
            
            if (forPoints >= reward.RequirePoints)
            {
                
                info.ReduceGigaPoints(reward);                
                Console.WriteLine($"You have chosen {reward.Type}");
                // Console.WriteLine($"Your remaining points: {info.gigaPoints} points");
                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
                
                // result.
                    deduction += reward.RequirePoints;
                    forPoints -= reward.RequirePoints;
                // result.points = info.gigaPoints + AddedPoints;
            }
            else
            {
                Console.WriteLine("Insufficient load balance.");
            }           
        }
        return deduction;       
    }
    public static void ReedeemMenu()
    {
        //  Result2 result = new Result2();
        double forPoints = GigaLife.returnThisPoints();
        Console.WriteLine($"GigaPoints = {forPoints} points");
        Console.WriteLine("You can use your points to Redeem Rewards");
        Console.WriteLine("MOST POPULAR REWARDS");
        Console.WriteLine("1. GIGA VIDEO 99 (99 points)");
        Console.WriteLine("2. GIGA STORIES 99 (99 points");
        Console.WriteLine("3. GIGA POWER 149 (149 points)");
        Console.WriteLine("4. Other Items");
        var userChoice = UserInput();

        Rewards[] rewards = AvailableRewards.ArrayRewards();
        Offers offers = new Offers();

        switch (userChoice)
        {
            case "1":
                RedeemRewards(new Rewards[] { rewards[0] });
                GigaLife.subscription(new Rewards[] { rewards[0] }, offers);
                break;
            case "2":
                RedeemRewards(new Rewards[] { rewards[1] });
                GigaLife.subscription(new Rewards[] { rewards[1] }, offers);
                break;
            case "3":
                RedeemRewards(new Rewards[] { rewards[2] });
                GigaLife.subscription(new Rewards[] { rewards[2] }, offers);
                break;
            case "4":
                Console.WriteLine("1. ALLNET  99 (99 points)");
                Console.WriteLine("2. MAGIC DATA 99 (99 points");
                Console.WriteLine("3. ALLDATA 99 (99 points)");
                userChoice = UserInput();
                if (userChoice == "1")
                {
                    Console.Clear();
                    RedeemRewards(new Rewards[] { rewards[2] });
                    GigaLife.subscription(new Rewards[] { rewards[2] }, offers);
                }
                else if (userChoice == "2")
                {
                    RedeemRewards(new Rewards[] { rewards[4] });
                    GigaLife.subscription(new Rewards[] { rewards[4] }, offers);
                }
                else
                {
                    RedeemRewards(new Rewards[] { rewards[5] });
                    GigaLife.subscription(new Rewards[] { rewards[5] }, offers);
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

    public static double UpdatedGigaPoints()
    {
        return deduction;
    }
}


