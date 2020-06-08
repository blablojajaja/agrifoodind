using System;
using System.Collections.Generic;
using System.Text;

namespace AgrifoodInd
{
    class FrozenProductbyNit : FrozenProducts
    {
        private string FreezingMethod { get; set; }
        private string ExhibithionTime { get; set; }

        FrozenProductbyNit(string expirationDate, int numberlot, string packingDate, string countryoforigin,
            string freezingMethod, string exhibithionTime) : base(expirationDate, numberlot, packingDate, countryoforigin)
        {
            this.FreezingMethod = freezingMethod;
            this.ExhibithionTime = exhibithionTime;
        }
    }
}
