using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    public interface IPaint :IFactory
    {
        //the painters
        int Paint(int paintColour);

    }
}
