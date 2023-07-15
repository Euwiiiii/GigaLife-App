using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AvailablePASA
{
    public static PASA[] ArrayPASA()
    {

        PASA[] pasa = new PASA[18];

        // load
        pasa[0] = new PASA { pasaType = "P50", pasaLoad = 50 };
        pasa[1] = new PASA { pasaType = "P100", pasaLoad = 100 };
        pasa[2] = new PASA { pasaType = "P200", pasaLoad = 200 };
        pasa[3] = new PASA { pasaType = "P300", pasaLoad = 300 };
        pasa[4] = new PASA { pasaType = "P500", pasaLoad = 500 };
        pasa[5] = new PASA { pasaType = "P1000", pasaLoad = 1000 };

        // points
        pasa[6] = new PASA { pasaType = "5 points", pasaPoints = 5 };
        pasa[7] = new PASA { pasaType = "10 points", pasaPoints = 10 };
        pasa[8] = new PASA { pasaType = "20 points", pasaPoints = 20 };
        pasa[9] = new PASA { pasaType = "30 points", pasaPoints = 30 };
        pasa[10] = new PASA { pasaType = "50 points", pasaPoints = 50 };
        pasa[11] = new PASA { pasaType = "100 points", pasaPoints = 100 };

        // data
        pasa[12] = new PASA { pasaType = "100 MB", PasaData = 100 };
        pasa[13] = new PASA { pasaType = "300 MB", PasaData = 300 };
        pasa[14] = new PASA { pasaType = "500 MB", PasaData = 500 };
        pasa[15] = new PASA { pasaType = "1000 GB", PasaData = 1000 };
        pasa[16] = new PASA { pasaType = "2000 GB", PasaData = 2000 };
        pasa[17] = new PASA { pasaType = "4000 GB", PasaData = 4000 };
        return pasa;
    }
}
