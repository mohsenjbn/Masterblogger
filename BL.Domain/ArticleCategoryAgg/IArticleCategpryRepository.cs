using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Domain.ArticleCategoryAgg
{
    public interface IArticleCategpryRepository
    {
        List<ArticleCategory> GetAll();

        void Add(ArticleCategory entity);

        void save();

        ArticleCategory GetBy(int id);

        bool Exist(string title);
    }
}
