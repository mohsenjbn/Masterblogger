using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Framework.Repository
{
    public interface  IUnitOfWork
    {
        void BeginTran();
        void CommitTran();
        void RollTran();
    }
}
