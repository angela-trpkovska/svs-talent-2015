using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Common
{
    /// <summary>
    /// struct for the interest rate
    /// </summary>
    public struct InterestRate
    {
        public decimal percent;
        public UnitOfTime unit;


        public InterestRate(decimal percent, UnitOfTime unit)
        {
            this.percent = percent;
            this.unit = unit;
        }
    }
}
