using ExampleSrp.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class Phone : ILoggerState
    {
        public void LogChangeState(string stateChangeInfo)
        {
            Console.WriteLine("Phone message:==============Car changed state:{0}", stateChangeInfo);
        }
    }
}
