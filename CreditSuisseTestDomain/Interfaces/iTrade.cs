using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisseTestDomain.Interfaces
{
    public interface ITrade
    {
        double Value { get; }

        string ClientSector { get; }
    }
}
