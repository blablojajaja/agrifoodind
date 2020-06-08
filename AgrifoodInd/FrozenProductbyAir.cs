using System;
using System.Collections.Generic;
using System.Text;

namespace AgrifoodInd
{
    class FrozenProductbyAir : FrozenProducts
    {
        private double Nitrogen { get; set; }
        private double Oxygen { get; set; }
        private double Carbon { get; set; }
        private double Watervapor { get; set; }

        FrozenProductbyAir(string expirationDate, int numberlot, string packingDate, string countryoforigin, double
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
