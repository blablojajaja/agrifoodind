using System;
using System.Collections.Generic;
using System.Text;

namespace AgrifoodInd
{
    class FrozenProductbyWater : FrozenProducts
    {
       public FrozenProductbyWater(string expirationDate, int numberlot, string packingDate, string countryoforigin,
            double recommendedtemperature, double salinity) : base(expirationDate, numberlot,
                 packingDate, countryoforigin)
        {
            this.RecommendedTemperature = recommendedtemperature;
            this.Salinity = salinity;
        }
      public  double RecommendedTemperature { get; set; }
     public   double Salinity { get; set; }
    }
}
