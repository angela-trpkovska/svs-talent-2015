using Registar.DomainModel;
using Registar.DomainModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Repository.Interfaces
{
    interface IBikeRepository :IRepository
    {
        IList<Bike> SearchBikes();

    }
}
