using Registar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Interfaces
{
   public class BikeLogging:ILogger
    {
      public void LogError(string message, Exception e)
       {
           Console.WriteLine("Error:  " + message);
       }

       public void LogWarning(string message)
       {
           Console.WriteLine("Warning:  " + message);
       }


    }
}
