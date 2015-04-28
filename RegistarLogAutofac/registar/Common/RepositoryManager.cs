using Registar.Common.Interfaces;
using Register.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public static class RepositoryManager
    {
        //kako singelton pattern
        private static IRepositoryFactory theFactory;

        public static TRepository CreateRepository<TRepository>() where TRepository : IRepository
        {
            TRepository result = theFactory.CreateRepository<TRepository>();
            return result;
            
        }

        public static void RegisterFactory(IRepositoryFactory factory)
        {
            theFactory = factory;
        }


    }
}
