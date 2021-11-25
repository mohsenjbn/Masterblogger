﻿

using BL.Domain.ArticleCategoryAgg;

namespace BL.Domain.ArticleAgg
{
    public class Article
    {
        public int Id { get; private set; }
        public string Name { get; private set;}
        public string ShortDescribtion { get; private set; }
        public string Content { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public string Image { get; private set; }
        public int ArticleCategoryId { get; private set; }


        public ArticleCategory category { get; set; }

        protected Article()
        {

        }

        public Article(string name,string shortdescribtion,string content,string image,int articlecategoryid)
        {
            Name=name;
            ShortDescribtion=shortdescribtion;
            Content=content;
            Image=image;
            ArticleCategoryId = articlecategoryid;
            IsDeleted=false;
            CreationDate = DateTime.Now;
        }
    }
}
