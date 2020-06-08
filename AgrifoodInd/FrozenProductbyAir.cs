using System;
using System.Collections.Generic;
using System.Text;

namespace AgrifoodInd
{
    class FrozenProductbyAir : FrozenProducts
    {
        public double Nitrogen { get; set; }
        public double Oxygen { get; set; }
        public double Carbon { get; set; }
        public double Watervapor { get; set; }

       public FrozenProductbyAir(string expirationDate, int numberlot, string packingDate, string countryoforigin, double
            nitrogen, double oxygen, double carbon, double watervapor) : base(expirationDate, numberlot,
                packingDate, countryoforigin)
        {
            this.Nitrogen = nitrogen;
            this.Oxygen = oxygen;
            this.Carbon = carbon;
            this.Watervapor = watervapor;
        }
    }
}
