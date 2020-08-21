using CreditSuisseTestDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisseTestDomain.Interfaces
{
    public interface IPortfolio
    {
        public List<Trade> Trade { get; set; }
    }
}
