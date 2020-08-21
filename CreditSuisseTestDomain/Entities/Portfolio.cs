using CreditSuisseTestDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisseTestDomain.Entities
{
    public class Portfolio : IPortfolio
    {
        public List<Trade> Trade { get; set; }
    }
}
