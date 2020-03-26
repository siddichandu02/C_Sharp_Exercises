using System;
using System.Collections.Generic;
using System.Text;

namespace CastleWindsorUnitTesting
{
    public interface IFinancialService
    {
        string GetFinancialScore(decimal balance);
    }
}
