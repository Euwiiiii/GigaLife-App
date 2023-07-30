using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GigaLife
{
    static public List<string> Subscribed = new List<string>();
    
    public string PIN = "BSCpE2023";
    public string Number = "09206420898";
    public string pasaNumber = "09206420897";
    public int load = 500;
    public double gigaPoints = 900; 
    public int shareableData = 2000;
    public int everyDay = 2;
    public int magicData = 0;
    public int limitedCallsTexts = 0;
       
    public bool UpdateBalance(Offers offer)
    {       
        bool reduce = false;
        if (load >= offer.RequireLoad)
        {
            load -= offer.RequireLoad;
            reduce = true;
        }
        return reduce;
    }
    public bool ReduceGigaPoints(Rewards rewards)
    {
        bool reduce = false;        
        if (gigaPoints >= rewards.RequirePoints)
        {
            double AddedPoints = POffers.AddPoints();
            gigaPoints += AddedPoints - rewards.RequirePoints;
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
    public static List<string> subscription(Rewards[] array, Offers offers)
    {
        GigaLife info = new GigaLife();
        foreach (Rewards reward in array)
        {
            if (info.gigaPoints >= reward.RequirePoints)
            {
                Subscribed.Add(reward.Type);
            }

        }
        return Subscribed;
    }
    public static List<string> subscription(Offers[] array)
    {
        GigaLife info = new GigaLife();
        foreach (Offers offer in array)
        {
            if (info.load >= offer.RequireLoad)
            {
                Subscribed.Add(offer.Type);
            }
        }
        return Subscribed;
    }
    public void DisplaySub()
    {
        if (Subscribed != null && Subscribed.Count > 0)
        {
            Console.WriteLine("Subcripted to");
            for (int i = 0; i < Subscribed.Count; i++)
            {
                Console.WriteLine(Subscribed[i]);
            }
        }
    }
    public static void Usage(Offers offers)
    {
        GigaLife info = new GigaLife();

        double result2 = returnThisPoints();
        int load2 = returnThisLoad();
        int shareable = returnThisData();     
        int updateMagic = POffers.UpdateMagic();       
        int updateCallsTexts = POffers.UpdateCallsTexts();

        Console.WriteLine($"Load Balance = P{load2}.00");
        Console.WriteLine($"GigaPoints = {result2}"); 
        Console.WriteLine($"Shareable Data = {shareable} GB");
        if (info.magicData < updateMagic)
        {
            Console.WriteLine($"Magic Data Balance  = {updateMagic} GB");
        }
        if (info.limitedCallsTexts < updateCallsTexts)
        {
            Console.WriteLine($"Calls & Text = {updateCallsTexts}");
        }
        info.DisplaySub();
    }
    public static double returnThisPoints ()
    {
        GigaLife info = new GigaLife();
        double AddedPoints = POffers.AddPoints();
        double Reduct = PRewards.UpdatedGigaPoints();
        double reduct2 = PPasa.fromPasaPoints();
        double result = AddedPoints + info.gigaPoints - Reduct - reduct2;
        return result;
    }

    public static int returnThisLoad()
    {
        GigaLife info = new GigaLife();
        int reduc = POffers.loadRed();
        int reduct1 = PPasa.storedTheDeductionLoad();
        int result = info.load - reduct1 - reduc;
        return result;
    }

    public static int returnThisData()
    {
        GigaLife info = new GigaLife();
        int reduct1 = PPasa.theShareableDeduction();
        int updateShareable = POffers.UpdateShareable();
        int result = info.shareableData + updateShareable - reduct1;
        return result;
    }
}



