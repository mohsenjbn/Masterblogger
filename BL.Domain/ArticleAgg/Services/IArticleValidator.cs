using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Domain.ArticleAgg.Services
{
    public interface IArticleValidator
    {
        void IsDoblicationName(string name);
    }

    public class ArticleValidator : IArticleValidator
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleValidator(IArticleRepository articleRepository)
        {
            _articleRepository=articleRepository;
        }
        public void IsDoblicationName(string name)
        {
            if (_articleRepository.IsExist(name))
                throw new Exception();
        }
    }
}
