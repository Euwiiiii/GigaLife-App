using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PRewards
{
    static GigaLife info = new GigaLife();

    public static void RedeemRewards(Rewards[] array)
    {
        foreach (Rewards reward in array)
        {
            if (info.gigaPoints >= reward.RequirePoints)
            {
                info.ReduceGigaPoints();
                Console.WriteLine($"You have chosen {reward.Type}");
                Console.WriteLine($"Your remaining points: {info.gigaPoints} points");
                Console.WriteLine("Thank you for claiming. See you on your next transaction!");
            }
            else
            {
                Console.WriteLine("Insufficient load balance.");
            }
        }

    }
    public static double ReedeemMenu()
    {
        Console.WriteLine($"GigaPoints = {info.gigaPoints} points");
        Console.WriteLine("You can use your points to Redeem Rewards");
        Console.WriteLine("MOST POPULAR REWARDS");
        Console.WriteLine("1. GIGA VIDEO 99 (99 points)");
        Console.WriteLine("2. GIGA STORIES 99 (99 points");
        Console.WriteLine("3. GIGA POWER 149 (149 points)");
        Console.WriteLine("4. Other Items");
        var userChoice = UserInput();

        Rewards[] rewards = AvailableRewards.ArrayRewards();

        switch (userChoice)
        {
            case "1":
                RedeemRewards(new Rewards[] { rewards[0] });
                GigaLife.subscription(new Rewards[] { rewards[0] });
                break;
            case "2":
                RedeemRewards(new Rewards[] { rewards[1] });
                GigaLife.subscription(new Rewards[] { rewards[1] });
                break;
            case "3":
                RedeemRewards(new Rewards[] { rewards[2] });
                GigaLife.subscription(new Rewards[] { rewards[2] });
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
                    GigaLife.subscription(new Rewards[] { rewards[2] });
                }
                else if (userChoice == "2")
                {
                    RedeemRewards(new Rewards[] { rewards[4] });
                    GigaLife.subscription(new Rewards[] { rewards[4] });
                }
                else
                {
                    RedeemRewards(new Rewards[] { rewards[5] });
                    GigaLife.subscription(new Rewards[] { rewards[5] });
                }
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
        return info.gigaPoints;
    }

    private static string UserInput()
    {
        Console.Write("Enter your Choice: ");
        string userChoice = Console.ReadLine() ?? string.Empty;
        return userChoice;
    }

    public static double UpdatedGigaPoints()
    {
        return info.gigaPoints;
    }
}
