using System;
using System.Collections.Generic;
using System.Text;
using CreditSuisseTestDomain.Interfaces;

namespace CreditSuisseTestDomain.Entities
{
    public class Trade : ITrade
    {
        public double Value { get; set; }

        public string ClientSector { get; set; }
    }
}
