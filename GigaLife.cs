using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GigaLife
{
    static public List<string> Subscribed = new List<string>();
    public List<string> callsTexts = new List<string>();
    
    public string PIN = "BSCpE2023";
    public string Number = "09206420898";
    public string pasaNumber = "09206420897";
    public int load = 500;
    public double gigaPoints = 990;
    public int shareableData = 2000;
    public int everyDay = 2;
    public int magicData = 0;
    public int limitedCallsTexts = 0;

    public bool UpdateBalance()
    {
        Offers[] offers = AvailableOffers.ArrayOffers();

        bool reduce = false;
        if (load >= offers[0].RequireLoad)
        {
            load -= offers[0].RequireLoad;
            reduce = true;
        }
        return reduce;
    }

    public bool ReduceGigaPoints()
    {
        Rewards[] rewards = AvailableRewards.ArrayRewards();
        bool reduce = false;
        if (gigaPoints >= rewards[0].RequirePoints)
        {
            gigaPoints -= rewards[0].RequirePoints;
            reduce = true;
        }

        return reduce;

    }
    public bool GainGigaPoints(Offers offer)
    {
        int load = offer.RequireLoad;
        double load_req = (double)load;
        bool gain = false;
        if (offer.RequireLoad >= 50 && offer.RequireLoad <= 75)
        {
            double pointsEarned = load_req *= 0.01;
            gigaPoints += pointsEarned;
            gain = true;
        }
        if (offer.RequireLoad >= 99 && offer.RequireLoad <= 899)
        {
            double pointsEarned = (load_req *= 0.05);
            gigaPoints += pointsEarned;
            gain = true;
        }
        return gain;
    }
    public int UpdateShareableData(Offers offer)
    {
        shareableData += offer.ShareableGB;
        return shareableData;
    }
    public int UpdateMagicData(Offers offer)
    {

        magicData += offer.MagicGB;
        return magicData;
    }
    public int UpdateTextCalls(Offers offer)
    {
        limitedCallsTexts += offer.CallText;
        return limitedCallsTexts;
    }
    public static List<string> subscription(Rewards[] array)
    {
        foreach (Rewards reward in array)
        {
            Subscribed.Add(reward.Type);

        }
        return Subscribed;
    }
    public static List<string> subscription(Offers[] array)
    {
        foreach (Offers offer in array)
        {
            Subscribed.Add(offer.Type);
        }
        return Subscribed;
    }

    public void DisplaySub()
    {
        if (Subscribed != null && Subscribed.Count > 0)
        {
            for (int i = 0; i < Subscribed.Count; i++)
            {
                Console.WriteLine(Subscribed[i]);
            }
        }
    }
}
