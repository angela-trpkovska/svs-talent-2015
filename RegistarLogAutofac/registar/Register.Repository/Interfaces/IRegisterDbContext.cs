using Register.Common.Interfaces;
using Register.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository.Interfaces
{
    public interface IRegisterDbContext :IDbContext
    {
        IDbContext getContext();
    }
}
