using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AvailableRewards
{
    public static Rewards[] ArrayRewards()
    {
        Rewards[] rewards = new Rewards[6];

        rewards[0] = new Rewards { Type = "Giga VIDEO 99", RequirePoints = 99 };
        rewards[1] = new Rewards { Type = "Giga STORIES 99", RequirePoints = 99 };
        rewards[2] = new Rewards { Type = "Giga POWER 149", RequirePoints = 149 };
        rewards[3] = new Rewards { Type = "ALLNET 99", RequirePoints = 149 };
        rewards[4] = new Rewards { Type = "MAGIC DATA 99", RequirePoints = 99 };
        rewards[5] = new Rewards { Type = "ALLDATA 99", RequirePoints = 99 };

        return rewards;
    }
}

