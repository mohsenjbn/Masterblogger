

using _01.Framework.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _01.Framework.Repository
{
    public class BaseRepository <TKey, T> : IRepository<TKey, T> where T:DomainBase<TKey>
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context=context;
        }
        public void Create(T entity)
        {
            _context.Add<T>(entity);
        }

        public bool Exist(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public List<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        public T GetBy(TKey Id)
        {
            return _context.Find<T>(Id);
        }
    }
}
