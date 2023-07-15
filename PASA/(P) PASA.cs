using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PPasa
{
    static GigaLife info = new GigaLife();

    public static void PasaMenu()
    {
        Console.WriteLine("1. Pasa Load");
        Console.WriteLine("2. Pasa Points");
        Console.WriteLine("3. Pasa Data");
        Console.WriteLine("4. Back");
        var userChoice = UserInput();

        PASA[] pasa = AvailablePASA.ArrayPASA();
        switch (userChoice)
        {
            case "1":
                Console.WriteLine("Pasa Load");
                Console.WriteLine("CURRENT LOAD BALANCE = P" + info.load);
                Console.WriteLine("Select Amount");
                Console.WriteLine("1. P50.00");
                Console.WriteLine("2. P100.00");
                Console.WriteLine("3. P200.00");
                Console.WriteLine("4. P300.00");
                Console.WriteLine("5. P500.00");
                Console.WriteLine("6. P1,000.00");
                Console.WriteLine("7. Back");
                userChoice = UserInput();

                switch (userChoice)
                {
                    case "1":
                        PasaLoad(new PASA[] { pasa[0] });
                        break;
                    case "2":
                        PasaLoad(new PASA[] { pasa[1] });
                        break;
                    case "3":
                        PasaLoad(new PASA[] { pasa[2] });
                        break;
                    case "4":
                        PasaLoad(new PASA[] { pasa[3] });
                        break;
                    case "5":
                        PasaLoad(new PASA[] { pasa[4] });
                        break;
                    case "6":
                        PasaLoad(new PASA[] { pasa[5] });
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                break;
            case "2":
                Console.WriteLine("Pasa Points");
                Console.WriteLine($"CURRECTN GIGA POINTS = {info.gigaPoints}");
                Console.WriteLine("Select Points");
                Console.WriteLine("1. 5 points");
                Console.WriteLine("2. 10 points");
                Console.WriteLine("3. 20 points");
                Console.WriteLine("4. 30 points");
                Console.WriteLine("5. 50 points");
                Console.WriteLine("6. 100 points");
                Console.WriteLine("7. Back");
                userChoice = UserInput();

                switch (userChoice)
                {
                    case "1":
                        PasaPoints(new PASA[] { pasa[6] });
                        break;
                    case "2":
                        PasaPoints(new PASA[] { pasa[7] });
                        break;
                    case "3":
                        PasaPoints(new PASA[] { pasa[8] });
                        break;
                    case "4":
                        PasaPoints(new PASA[] { pasa[9] });
                        break;
                    case "5":
                        PasaPoints(new PASA[] { pasa[10] });
                        break;
                    case "6":
                        PasaPoints(new PASA[] { pasa[11] });
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                break;
            case "3":
                Console.WriteLine("Pasa Data");
                Console.WriteLine("CURRECT SHAREABLE DATA = " + info.gigaPoints + " GB");
                Console.WriteLine("Select Data Amount");
                Console.WriteLine("1. 100 MB");
                Console.WriteLine("2. 300 MB");
                Console.WriteLine("3. 500 MB");
                Console.WriteLine("4. 1 GB");
                Console.WriteLine("5. 2 GB");
                Console.WriteLine("6. 4 GB");
                Console.WriteLine("7. Back");
                userChoice = UserInput();

                switch (userChoice)
                {
                    case "1":
                        PasaData(new PASA[] { pasa[12] });
                        break;
                    case "2":
                        PasaData(new PASA[] { pasa[13] });
                        break;
                    case "3":
                        PasaData(new PASA[] { pasa[14] });
                        break;
                    case "4":
                        PasaData(new PASA[] { pasa[15] });
                        break;
                    case "5":
                        PasaData(new PASA[] { pasa[16] });
                        break;
                    case "6":
                        PasaData(new PASA[] { pasa[17] });
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                break;
            case "4":
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
    public static int PasaData(PASA[] array)
    {
        foreach (PASA pasa in array)
        {

            var insufficient = info.shareableData <= pasa.PasaData;
            while (!insufficient)
            {
                if (insufficient)
                {
                    Console.WriteLine("Sorry. Insuffient Load Balance");
                    break;
                }
                if (pasa.PasaData <= info.gigaPoints)
                {
                    int iAmount = 1;
                    Console.WriteLine($"You about to send {pasa.pasaType} Data");
                    Console.WriteLine($"Valid for 1 day + P1 transaction fee");
                    Console.WriteLine($"SHAREABLE DATA: {info.shareableData}");
                    Console.WriteLine("Payment Method");
                    Console.WriteLine($"Load Balance= {info.load}");
                    Console.WriteLine($"Amount           P{iAmount}");
                    Console.WriteLine("1. Subscribe         2. Cancel");
                    var userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine($"You have successfully {pasa.pasaType} to {info.pasaNumber}");
                            info.load -= iAmount;
                            info.shareableData -= pasa.PasaData;
                            break;
                    }
                }
                break;
            }
        }
        return info.shareableData;
    }
    public static double PasaPoints(PASA[] array)
    {
        foreach (PASA pasa in array)
        {
            var insufficient = info.gigaPoints <= pasa.pasaPoints;
            while (!insufficient)
            {
                if (insufficient)
                {
                    Console.WriteLine("Sorry. Insuffient Load Balance");
                    break;
                }
                if (pasa.pasaPoints <= info.gigaPoints)
                {
                    int iAmount = 1;
                    Console.WriteLine($"You about to send {pasa.pasaType}");
                    Console.WriteLine("P1 transaction fee");
                    Console.WriteLine($"SHAREABLE POINTS: {info.gigaPoints}");
                    Console.WriteLine("Payment Method");
                    Console.WriteLine($"Load Balance= {info.load}");
                    Console.WriteLine($"Amount           P{iAmount}");
                    Console.WriteLine("1. Subscribe         2. Cancel");
                    var userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine($"You have successfully {pasa.pasaType} to {info.pasaNumber}");
                            info.load -= iAmount;
                            info.gigaPoints -= pasa.pasaPoints;
                            break;
                    }
                }
                break;
            }
        }
        return info.gigaPoints;
    }

    public static int PasaLoad(PASA[] array)
    {
        foreach (PASA pasa in array)
        {
            var insufficient = info.load <= pasa.pasaLoad;
            while (!insufficient)
            {
                if (insufficient)
                {
                    Console.WriteLine("Sorry. Insuffient Load Balance");
                    break;
                }
                if (pasa.pasaLoad <= info.load)
                {
                    int iAmount = 1;
                    iAmount += pasa.pasaLoad;
                    Console.WriteLine($"You about to send {pasa.pasaType}");
                    Console.WriteLine($"Valid for 30 days + P1 transaction fee");
                    Console.WriteLine($"CURRENT LOAD BALANCE: P{info.load}");
                    Console.WriteLine("Payment Method");
                    Console.WriteLine($"Amount           P{iAmount}");
                    Console.WriteLine("1. Subscribe         2. Cancel");
                    var userChoice = UserInput();
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine($"You have successfully {pasa.pasaType} to {info.pasaNumber}");
                            info.load -= iAmount;
                            break;
                    }
                    return info.load;
                }
                break;
            }
        }
        return info.load;
    }
}