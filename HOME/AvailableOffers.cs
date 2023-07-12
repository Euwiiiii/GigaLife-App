using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AvailableOffers
{
    public static Offers[] ArrayOffers()
    {
        Offers[] offer = new Offers[6];

        // Dont'Miss Out = DOUBLE GIGA+
        offer[0] = new Offers { Type = "DOUBLE GIGA VIDEO+ 130", RequireLoad = 130, TotalEverydayGB = 17, EverydayGB = 2, ShareableGB = 3000, Date = 7, Percentage = 5, GainPoints = 6.5, Add = "Unli Allnet Calls & Texts" };
        offer[1] = new Offers { Type = "DOUBLE GIGA VIDEO+ 399", RequireLoad = 399, TotalEverydayGB = 64, EverydayGB = 2, ShareableGB = 4000, Date = 30, Percentage = 5, GainPoints = 19.95, Add = "Unli ALlnet Calls & Texts" };
        offer[2] = new Offers { Type = "DOUBLE GIGA STORIES+ 130", RequireLoad = 130, TotalEverydayGB = 17, EverydayGB = 2, ShareableGB = 3000, Date = 7, Percentage = 5, GainPoints = 6.5, Add = "Unli Allnet Calls & Texts" };
        offer[3] = new Offers { Type = "DOUBLE GIGA STORIES+ 399", RequireLoad = 399, TotalEverydayGB = 64, EverydayGB = 2, ShareableGB = 4000, Date = 30, Percentage = 5, GainPoints = 19.95, Add = "Unli ALlnet Calls & Texts" };

        // Don't Miss Out = MAGIC DATA+
        offer[4] = new Offers { Type = "MAGIC DATA+ 499", RequireLoad = 499, MagicGB = 2400, CallText = 200, Percentage = 5, GainPoints = 24.95 };
        offer[5] = new Offers { Type = "MAGIC DATA+ 749", RequireLoad = 749, MagicGB = 4800, CallText = 600, Percentage = 5, GainPoints = 37.45 };

        return offer;
    }
}
