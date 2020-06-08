using System;
using System.Collections.Generic;
using System.Text;

namespace AgrifoodInd
{
    class FrozenProductbyWater : FrozenProducts
    {
        FrozenProductbyWater(string expirationDate, int numberlot, string packingDate, string countryoforigin,
            double recommendedtemperature, double salinity) : base(expirationDate, numberlot,
                 packingDate, countryoforigin)
        {
            this.RecommendedTemperature = recommendedtemperature;
            this.Salinity = salinity;
        }
        double RecommendedTemperature { get; set; }
        double Salinity { get; set; }
    }
}
