
using _01.Framework.Repository;

namespace BL.Infrastracture
{
    public class UnitOfWorkEf : IUnitOfWork
    {
        private readonly BlogContext _Context;
        public UnitOfWorkEf(BlogContext context)
        {
            _Context = context;
        }
        public void BeginTran()
        {
          _Context.Database.BeginTransaction();
        }

        public void CommitTran()
        {
            _Context.SaveChanges(); 
            _Context.Database.CommitTransaction();

        }

        public void RollTran()
        {
            _Context.Database.RollbackTransaction();
        }
    }
}
