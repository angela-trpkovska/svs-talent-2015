using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class Test
    {
        public static void  Main(string[] args)
        {
            AcmeCar car = new AcmeCar("cloud", "phone");
            car.Lock();
            car.Unlock();
           
        }



    }
}
