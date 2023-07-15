using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Account
{
    static public List<string> numberList = new()
    {
        "09206420898"
    };
    static public void DisplayAccountList()
    {
        for (int i = 0; i < numberList.Count; i++)
        {
            Console.WriteLine(numberList[i]);
        }
    }
    static public void SmartAccount(string Add)
    {
        numberList.Add(Add + " (SMART)");
    }
    static public void TNTAccount(string Add)
    {
        numberList.Add(Add + " (TNT)");
    }
    static public void PLDTAccount(string Add)
    {
        numberList.Add(Add + " (TNT)");
    }
}
