using ExampleSrp.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class Logger :ILoggerException
    {

        public void LockException()
        {
            Console.WriteLine("There was an error locking the car!");
        }


        public void UnlockException()
        {
            Console.WriteLine("There was an error unlocking the car!");

        }

    }
}
