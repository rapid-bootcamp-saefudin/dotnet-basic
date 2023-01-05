using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample101Linq.DataSource
{
    public class AggregateOperator
    {
        public int CountSyntax()
        {
            #region
            int[] factorsOf300 = { 2, 2, 2, 3, 4, 4, 5, 6, 6, 7, 7, 7, 8 };
            int uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine($"There are {uniqueFactors} unique factors of 300.");
            #endregion
            return 0;
        }
    }
}
