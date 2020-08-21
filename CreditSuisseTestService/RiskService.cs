using System;
using System.Collections.Generic;
using CreditSuisseTestDomain;
using CreditSuisseTestDomain.Entities;

namespace CreditSuisseTestService
{
    public class RiskService
    {
        public List<string> CheckRisk(Portfolio portfolio) 
        {
            List<string> results = new List<string>();
            foreach (var item in portfolio.Trade)
            {
                results.Add(DefineRisk(item));
            }

            return results;
        }

        private bool LowRiskRule(Trade trade) 
        {
            return (trade.Value < 1000000 && trade.ClientSector == "Public");
        }

        private bool MediumRiskRule(Trade trade)
        {
            return (trade.Value > 1000000 && trade.ClientSector == "Public");
        }

        private bool HighRiskRule(Trade trade)
        {
            return (trade.Value > 1000000 && trade.ClientSector == "Private");
        }

        private string DefineRisk(Trade trade) 
        {
            string result = "";

            if (LowRiskRule(trade))
                result = "LOWRISK";
            else if (MediumRiskRule(trade))
                result = "MEDIUMRISK";
            else if (HighRiskRule(trade))
                result = "HIGHRISK";

            return result;
        } 
    }
}
