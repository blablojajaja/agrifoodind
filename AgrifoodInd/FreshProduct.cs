using System;
using System.Collections.Generic;
using System.Text;

namespace AgrifoodInd
{
    class FreshProduct
    {
        public string ExpirationDate { get; set; }
        public int Numberlot { get ; set; }
        public string PackingDate { get; set;}
        public string Countryoforigin { get; set; }

        public FreshProduct(string expirationDate, int numberlot, string packingDate, string countryoforigin)
        {
            ExpirationDate = expirationDate;
            Numberlot = numberlot;
            PackingDate = packingDate;
            Countryoforigin = countryoforigin;
        }



    }
}
