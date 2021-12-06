using _01.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _01.Framework.Repository
{
    public interface IRepository<Tkey,T> where T:DomainBase<Tkey>
    {
        void Create(T entity);
        List<T> GetAll();
        T GetBy(Tkey Id);
        bool Exist(Expression<Func<T, bool>> expression);
    }
}
