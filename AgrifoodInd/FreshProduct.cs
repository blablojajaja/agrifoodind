using System;
using System.Collections.Generic;
using System.Text;

namespace AgrifoodInd
{
    class FreshProduct
    {
        private string ExpirationDate { get; set; }
        private int Numberlot { get; set; }
        private string PackingDate { get; set; }
        private string Countryoforigin { get; set; }

        public FreshProduct(string expirationDate, int numberlot, string packingDate, string countryoforigin)
        {
            ExpirationDate = expirationDate;
            Numberlot = numberlot;
            PackingDate = packingDate;
            Countryoforigin = countryoforigin;
        }



    }
}
