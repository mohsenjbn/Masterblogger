using BL.Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Infrastracture.Repositories
{
    public class ArticleRepository:IArticleRepository
    {
        private readonly BlogContext _context;
        public ArticleRepository(BlogContext context)
        {
            _context = context;
        }


    }
}
