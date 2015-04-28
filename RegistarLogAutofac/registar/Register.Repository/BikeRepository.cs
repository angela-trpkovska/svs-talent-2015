using Registar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;
using Register;
using Registar.DataLayer;
using Registar.BusinessLayer.Contracts;
using log4net;
using System.IO;


namespace Registar.Repository
{
    
    internal class BikeRepository : IBikeRepository
    {
        
        private static readonly ILog logger = LogManager.GetLogger("Test");
        
           
        
        public IList<Bike> SearchBikes()
        {
            //
            //Logging.LogWarn("===============StarSearchBike=============");
           logger.Warn("===============StarSearchBike=============");
            //using (var context = DataContextManager.CreateContext<IRegistarContext>())
           // {
            //}
            //Logging.LogWarn("===============EndSearchBike===============");
            logger.Warn("===============StarSearchBike=============");

            return null;
        }
      }

    }

