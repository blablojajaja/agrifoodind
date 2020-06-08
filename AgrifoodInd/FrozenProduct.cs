using System;
using System.Collections.Generic;
using System.Text;

namespace AgrifoodInd
{
    class FrozenProducts : FreshProduct
    {
        public FrozenProducts(string expirationDate, int numberlot, string packingDate, string countryoforigin)
       : base(expirationDate, numberlot, packingDate, countryoforigin) { }
    }
}
