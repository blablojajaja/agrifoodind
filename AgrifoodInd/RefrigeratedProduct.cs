using System;
using System.Collections.Generic;
using System.Text;

namespace AgrifoodInd
{
    class RefrigeratedProduct : FreshProduct
    {
        public RefrigeratedProduct(string expirationDate, int numberlot, string packingDate, string countryoforigin, int supervision_code,
            double recommended_temperature) : base(expirationDate, numberlot, packingDate, countryoforigin)
        {
            this.Supervision_code = supervision_code;
            this.Recommended_temperature = recommended_temperature;
        }

        public int Supervision_code { get; set; }

        public double Recommended_temperature { get; set; }


    }
}
