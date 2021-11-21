using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Application.Contracts.ArticleCategory
{
    public class EditCategory:ArticleCategoryCreate
    {
        public int id { get; set; }
    }
}
