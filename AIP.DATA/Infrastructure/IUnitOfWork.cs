using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.DATA.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
