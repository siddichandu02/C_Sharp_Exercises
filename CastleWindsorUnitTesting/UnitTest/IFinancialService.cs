using System;
using System.Collections.Generic;
using System.Text;

namespace CastleWindsorUnitTest
{
    public interface IFinancialService
    {
        string GetFinancialScore(decimal balance);
    }
}
