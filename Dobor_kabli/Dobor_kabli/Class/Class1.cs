using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobor_kabli.Class
{
    class obwod
    {
        int cableLength; //in meters
        string isolation; //PVC or XLPE
        double resistivity; //resistivity ohm/km
        double resistance; //ohm
        double reactance;
        double reaktanceDivKm;
        double maxTemp;
        double maxFaultTemp;
        double metodOfInstallation;
        double numberOfCables;
        double reduceingFactor;
        double load;
        double current;
    }
}
