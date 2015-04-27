using Register.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;
using Common;
using Registar.DomainModel.Interfaces;

namespace Register.Repository
{
    internal class BikeRepository : IBikeRepository
    {
        public IList<Bike> SearchBikes()
        {

            IRepository repository = RepositoryManager.CreateRepository<IBikeRepository>();



            using (var context = RepositoryManager.CreateRepository<IBikeRepository>())

                
            using (RegistarDbContext context = new RegistarDbContext())
            {
                //IEnumerable<Bike> bikes = new List<Bike>();
                //bikes = context.Bikes
                //        .OrderBy(p => p.BikeId)
                //        .Take(10);
                //.ToList();

                var query = from b in context.Bikes  //Include("BikeHistory")
                            select b;
                if (!string.IsNullOrEmpty(command.Colour))
                {
                    query = query.Where(x => x.Colour == command.Colour);
                }
                if (!string.IsNullOrEmpty(command.Producer))
                {
                    query = query.Where(x => x.Producer == command.Producer);
                }

                query = query
                        .OrderBy(x => x.BikeId)
                        .Skip(command.PageIndex * command.PageSize)
                        .Take(command.PageSize);
                //

                BikeSearchResult result = new BikeSearchResult();
                result.Result = query.ToList();
                return result;



            }
            */
            }

    }
}
