using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Common
{
    /// <summary>
    /// struct for time period
    /// </summary>
    public struct TimePeriod
    {
        public int period;
        public UnitOfTime unit;

        public TimePeriod(int period, UnitOfTime unit)
        {
            this.period = period;
            this.unit = unit;

        }

    }
}
