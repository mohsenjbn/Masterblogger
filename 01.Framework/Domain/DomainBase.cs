

namespace _01.Framework.Domain
{
    public class DomainBase<TKey>
    {
        public TKey Id { get; private set; }
        public DateTime CreationDate { get; set; }

        public DomainBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
