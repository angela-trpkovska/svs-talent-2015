using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    /// <summary>
    /// Interface for the factory
    /// </summary>
    public interface IFactory
    {
        int StartShift();

        int CloseShift();

        int StartProductionLane();

        int StopProductionLane();

    }
}
