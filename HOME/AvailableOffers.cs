using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AvailableOffers
{
    public static Offers[] ArrayOffers()
    {
        Offers[] offer = new Offers[64];

        // Dont'Miss Out = DOUBLE GIGA+
        offer[0] = new Offers { Type = "DOUBLE GIGA VIDEO+ 130", RequireLoad = 130, TotalEverydayGB = 17, EverydayGB = 2, ShareableGB = 3000, Date = 7, Percentage = 5, GainPoints = 6.5, Add = "Unli Allnet Calls & Texts" };
        offer[1] = new Offers { Type = "DOUBLE GIGA VIDEO+ 399", RequireLoad = 399, TotalEverydayGB = 64, EverydayGB = 2, ShareableGB = 4000, Date = 30, Percentage = 5, GainPoints = 19.95, Add = "Unli ALlnet Calls & Texts" };
        offer[2] = new Offers { Type = "DOUBLE GIGA STORIES+ 130", RequireLoad = 130, TotalEverydayGB = 17, EverydayGB = 2, ShareableGB = 3000, Date = 7, Percentage = 5, GainPoints = 6.5, Add = "Unli Allnet Calls & Texts" };
        offer[3] = new Offers { Type = "DOUBLE GIGA STORIES+ 399", RequireLoad = 399, TotalEverydayGB = 64, EverydayGB = 2, ShareableGB = 4000, Date = 30, Percentage = 5, GainPoints = 19.95, Add = "Unli ALlnet Calls & Texts" };

        // Don't Miss Out = MAGIC DATA+
        offer[4] = new Offers { Type = "MAGIC DATA+ 499", RequireLoad = 499, MagicGB = 2400, CallText = 200, Percentage = 5, GainPoints = 24.95 };
        offer[5] = new Offers { Type = "MAGIC DATA+ 749", RequireLoad = 749, MagicGB = 4800, CallText = 600, Percentage = 5, GainPoints = 37.45 };

        // DOUBLE GIGA+
        offer[6] = new Offers { Type = "DOUBLE GIGA VIDEO+ 65", RequireLoad = 65, TotalEverydayGB = 8, EverydayGB = 2, ShareableGB = 2000, Date = 3, Percentage = 1, GainPoints = 0.65, Add = "Unli Allnet Calls & Texts" };
        offer[7] = new Offers { Type = "DOUBLE GIGA STORIES+ 65", RequireLoad = 65, TotalEverydayGB = 8, EverydayGB = 2, ShareableGB = 2000, Date = 3, Percentage = 1, GainPoints = 0.65, Add = "Unli ALlnet Calls & Texts" };

        // POWER
        offer[8] = new Offers { Type = "GIGA POWER 75", RequireLoad = 75, EverydayGB = 2, ShareableGB = 2000, Date = 3, Percentage = 1, GainPoints = 0.75 };
        offer[9] = new Offers { Type = "GIGA POWER 149", RequireLoad = 149, EverydayGB = 2, ShareableGB = 6000, Date = 3, Percentage = 1, GainPoints = 0.75 };
        offer[10] = new Offers { Type = "GIGA POWER 499", RequireLoad = 499, EverydayGB = 2, ShareableGB = 24000, Date = 30, Percentage = 5, GainPoints = 24.95 };
        offer[11] = new Offers { Type = "GIGA POWER 599", RequireLoad = 599, EverydayGB = 2, ShareableGB = 36000, Date = 30, Percentage = 5, GainPoints = 29.95 };
        offer[12] = new Offers { Type = "GIGA POWER 699", RequireLoad = 699, EverydayGB = 2, ShareableGB = 48000, Date = 30, Percentage = 5, GainPoints = 34.95 };

        // POWER+
        offer[13] = new Offers { Type = "GIGA POWER 99", RequireLoad = 99, EverydayGB = 2, ShareableGB = 2000, Date = 3, Percentage = 5, GainPoints = 4.95, Add = "Unli ALlnet Calls & Texts" };
        offer[14] = new Offers { Type = "GIGA POWER 199", RequireLoad = 199, EverydayGB = 2, ShareableGB = 6000, Date = 7, Percentage = 5, GainPoints = 9.95, Add = "Unli ALlnet Calls & Texts" };
        offer[15] = new Offers { Type = "GIGA POWER 699", RequireLoad = 699, EverydayGB = 2, ShareableGB = 24000, Date = 30, Percentage = 5, GainPoints = 34.95, Add = "Unli ALlnet Calls & Texts" };
        offer[16] = new Offers { Type = "GIGA POWER 799", RequireLoad = 799, EverydayGB = 2, ShareableGB = 36000, Date = 30, Percentage = 5, GainPoints = 39.95, Add = "Unli ALlnet Calls & Texts" };
        offer[17] = new Offers { Type = "GIGA POWER 799", RequireLoad = 799, EverydayGB = 2, ShareableGB = 48000, Date = 30, Percentage = 5, GainPoints = 44.95, Add = "Unli ALlnet Calls & Texts" };

        // VIDEO
        offer[18] = new Offers { Type = "GIGA VIDEO 50", RequireLoad = 50, EverydayGB = 1, ShareableGB = 1000, Date = 3, Percentage = 1, GainPoints = 0.5, Add = "Unli Allnet Texts" };
        offer[19] = new Offers { Type = "GIGA VIDEO 99", RequireLoad = 99, EverydayGB = 1, ShareableGB = 2000, Date = 7, Percentage = 5, GainPoints = 4.95 };
        offer[20] = new Offers { Type = "GIGA VIDEO 299", RequireLoad = 299, EverydayGB = 1, ShareableGB = 4000, Date = 30, Percentage = 5, GainPoints = 14.95 };

        // VIDEO+ 
        offer[21] = new Offers { Type = "GIGA VIDEO+ 75", RequireLoad = 75, EverydayGB = 1, TotalEverydayGB = 3, ShareableGB = 1000, Date = 3, Percentage = 1, GainPoints = 0.75, Add = "Unli Allnet Calls & Texts" };
        offer[22] = new Offers { Type = "GIGA VIDEO+ 149", RequireLoad = 149, EverydayGB = 1, TotalEverydayGB = 7, ShareableGB = 2000, Date = 7, Percentage = 5, GainPoints = 7.45, Add = "Unli Allnet Calls & Texts" };
        offer[23] = new Offers { Type = "GIGA VIDEO+ 449", RequireLoad = 449, EverydayGB = 1, TotalEverydayGB = 30, ShareableGB = 4000, Date = 30, Percentage = 5, GainPoints = 22.45, Add = "Unli Allnet Calls & Texts" };

        // Stories
        offer[24] = new Offers { Type = "GIGA STORIES 50", RequireLoad = 50, EverydayGB = 1, ShareableGB = 1000, Date = 3, Percentage = 1, GainPoints = 0.5 };
        offer[25] = new Offers { Type = "GIGA STORIES 99", RequireLoad = 99, EverydayGB = 1, ShareableGB = 2000, Date = 7, Percentage = 5, GainPoints = 4.95 };
        offer[26] = new Offers { Type = "GIGA STORIES 299", RequireLoad = 299, EverydayGB = 1, ShareableGB = 4000, Date = 30, Percentage = 5, GainPoints = 14.95 };

        // STOREIS + 
        offer[27] = new Offers { Type = "GIGA STORIES+ 75", RequireLoad = 75, EverydayGB = 1, TotalEverydayGB = 3, ShareableGB = 1000, Date = 3, Percentage = 1, GainPoints = 0.75, Add = "Unli Allnet Calls & Texts" };
        offer[28] = new Offers { Type = "GIGA STORIES+ 149", RequireLoad = 149, EverydayGB = 1, TotalEverydayGB = 7, ShareableGB = 2000, Date = 7, Percentage = 5, GainPoints = 7.45, Add = "Unli Allnet Calls & Texts" };
        offer[29] = new Offers { Type = "GIGA STORIES+ 449", RequireLoad = 449, EverydayGB = 1, TotalEverydayGB = 30, ShareableGB = 4000, Date = 30, Percentage = 5, GainPoints = 22.45, Add = "Unli Allnet Calls & Texts" };

        // GAMES-1
        offer[30] = new Offers { Type = "GIGA GAMES-1 50", RequireLoad = 50, EverydayGB = 1, ShareableGB = 1000, Date = 3, Percentage = 1, GainPoints = 0.5, Add = "PUBG Mobile, ML, CoC, AoV, Clash Royale, Fb Gaming, Giga Arena" };
        offer[31] = new Offers { Type = "GIGA GAMES-1 75", RequireLoad = 75, EverydayGB = 1, ShareableGB = 2000, Date = 7, Percentage = 1, GainPoints = 0.75, Add = "PUBG Mobile, ML, CoC, AoV, Clash Royale, Fb Gaming, Giga Arena" };
        offer[32] = new Offers { Type = "GIGA GAMES-1 299", RequireLoad = 299, EverydayGB = 1, ShareableGB = 4000, Date = 30, Percentage = 5, GainPoints = 14.95, Add = "PUBG Mobile, ML, CoC, AoV, Clash Royale, Fb Gaming, Giga Arena" };

        //GAMES - 2
        offer[33] = new Offers { Type = "GIGA GAMES-2 50", RequireLoad = 50, EverydayGB = 1, ShareableGB = 1000, Date = 3, Percentage = 1, GainPoints = 0.5, Add = "Wild Rift, Call of Duty, ML, Fb Gaming, Giga Arena (TOTAL 3 GB)" };
        offer[34] = new Offers { Type = "GIGA GAMES-2 75", RequireLoad = 75, EverydayGB = 1, ShareableGB = 2000, Date = 7, Percentage = 1, GainPoints = 0.75, Add = "Wild Rift, Call of Duty, ML, Fb Gaming, Giga Arena (TOTAL 7 GB)" };
        offer[35] = new Offers { Type = "GIGA GAMES-2 299", RequireLoad = 299, EverydayGB = 1, ShareableGB = 4000, Date = 30, Percentage = 5, GainPoints = 14.95, Add = "Wild Rift, Call of Duty, ML, Fb Gaming, Giga Arena (TOTAL 30 GB)" };

        // PowerAll 
        offer[36] = new Offers { Type = "POWER ALL 99", RequireLoad = 99, ShareableGB = 8000, Date = 7, Percentage = 5, GainPoints = 4.95 };
        offer[37] = new Offers { Type = "POWER ALL 149", RequireLoad = 149, ShareableGB = 12000, Date = 7, Percentage = 5, GainPoints = 7.45 };

        // All Data
        offer[38] = new Offers { Type = "ALL DATA 50", RequireLoad = 50, ShareableGB = 2000, Date = 3, Percentage = 1, GainPoints = 0.5 };
        offer[39] = new Offers { Type = "ALL DATA 99", RequireLoad = 99, ShareableGB = 6000, Date = 7, Percentage = 5, GainPoints = 4.95 };
        offer[40] = new Offers { Type = "ALL DATA 299", RequireLoad = 299, ShareableGB = 24000, Date = 30, Percentage = 5, GainPoints = 14.95 };
        offer[41] = new Offers { Type = "ALL DATA 399", RequireLoad = 399, ShareableGB = 36000, Date = 30, Percentage = 5, GainPoints = 19.95 };
        offer[42] = new Offers { Type = "ALL DATA 499", RequireLoad = 499, ShareableGB = 48000, Date = 30, Percentage = 5, GainPoints = 24.95 };

        //All Data+
        offer[43] = new Offers { Type = "ALL DATA+ 75", RequireLoad = 75, ShareableGB = 2000, Date = 3, Percentage = 1, GainPoints = 0.75, Add = "+Unli Allnet Calls & Texts" };
        offer[44] = new Offers { Type = "ALL DATA+ 149", RequireLoad = 149, ShareableGB = 6000, Date = 7, Percentage = 5, GainPoints = 7.45, Add = "+Unli Allnet Calls & Texts" };
        offer[45] = new Offers { Type = "ALL DATA+ 499", RequireLoad = 499, ShareableGB = 24000, Date = 30, Percentage = 5, GainPoints = 24.95, Add = "+Unli Allnet Calls & Texts" };
        offer[46] = new Offers { Type = "ALL DATA+ 599", RequireLoad = 599, ShareableGB = 36000, Date = 30, Percentage = 5, GainPoints = 29.95, Add = "+Unli Allnet Calls & Texts" };
        offer[47] = new Offers { Type = "ALL DATA+ 699", RequireLoad = 699, ShareableGB = 48000, Date = 30, Percentage = 5, GainPoints = 34.95, Add = "+Unli Allnet Calls & Texts" };

        // Magic Data
        offer[48] = new Offers { Type = "MAGIC DATA 99", RequireLoad = 99, ShareableGB = 2000, Percentage = 5, GainPoints = 4.95 };
        offer[49] = new Offers { Type = "MAGIC DATA 199", RequireLoad = 199, ShareableGB = 6000, Percentage = 5, GainPoints = 14.95 };
        offer[50] = new Offers { Type = "MAGIC DATA 399", RequireLoad = 399, ShareableGB = 24000, Percentage = 5, GainPoints = 19.95 };
        offer[51] = new Offers { Type = "MAGIC DATA 499", RequireLoad = 499, ShareableGB = 36000, Percentage = 5, GainPoints = 24.95 };
        offer[52] = new Offers { Type = "MAGIC DATA 599", RequireLoad = 599, ShareableGB = 48000, Percentage = 5, GainPoints = 29.95 };

        //Magic Data+
        offer[53] = new Offers { Type = "MAGIC DATA+ 149", RequireLoad = 149, ShareableGB = 2000, Percentage = 5, GainPoints = 7.45, CallText = 50, Add = "Mins Allnet Calls & Allnet Texts" };
        offer[54] = new Offers { Type = "MAGIC DATA+ 149", RequireLoad = 149, ShareableGB = 6000, Percentage = 5, GainPoints = 14.95, CallText = 100, Add = "Mins Allnet Calls & Allnet Texts" };
        offer[55] = new Offers { Type = "MAGIC DATA+ 499", RequireLoad = 499, ShareableGB = 24000, Percentage = 5, GainPoints = 24.95, CallText = 200, Add = "Mins Allnet Calls & Allnet Texts" };
        offer[56] = new Offers { Type = "MAGIC DATA+ 649", RequireLoad = 649, ShareableGB = 36000, Percentage = 5, GainPoints = 32.45, CallText = 300, Add = "Mins Allnet Calls & Allnet Texts" };
        offer[57] = new Offers { Type = "MAGIC DATA+ 749", RequireLoad = 749, ShareableGB = 48000, Percentage = 5, GainPoints = 37.45, CallText = 600, Add = "Mins Allnet Calls & Allnet Texts" };

        //Allnet
        offer[58] = new Offers { Type = "Allnet 30", RequireLoad = 30, ShareableGB = 100, Percentage = 1, GainPoints = 0.3, Date = 1 };
        offer[59] = new Offers { Type = "Allnet 50", RequireLoad = 50, ShareableGB = 500, Percentage = 1, GainPoints = 0.5, Date = 3 };
        offer[60] = new Offers { Type = "Allnet 99", RequireLoad = 99, ShareableGB = 1000, Percentage = 5, GainPoints = 4.95, Date = 7 };
        offer[61] = new Offers { Type = "Allnet 299", RequireLoad = 299, ShareableGB = 2000, Percentage = 5, GainPoints = 14.95, Date = 30 };
        offer[62] = new Offers { Type = "Allnet 499", RequireLoad = 499, ShareableGB = 4000, Percentage = 5, GainPoints = 24.95, Date = 60 };
        offer[63] = new Offers { Type = "Allnet 599", RequireLoad = 599, ShareableGB = 6000, Percentage = 5, GainPoints = 29.95, Date = 90 };

        return offer;
    }
}
