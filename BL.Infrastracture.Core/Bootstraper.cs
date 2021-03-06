
using BL.Application;
using BL.Application.Contracts.ArticleCategory;
using BL.Domain.ArticleCategoryAgg;
using BL.Infrastracture.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BL.Domain.Services;
using BL.Domain.ArticleAgg;
using BL.Application.Contracts.Article;
using BL.Infrastracture.Query;
using BL.Domain.ArticleAgg.Services;
using BL.Domain.CommentAgg;
using BL.Application.Contracts.Comment;
using _01.Framework.Repository;

namespace BL.Infrastracture.Core
{
    public  class Bootstraper
    {
        public static void config(IServiceCollection services,string connectionstring )
        {
            services.AddTransient<IArticleCategpryRepository, ArticleCategoryRepository>();
            services.AddTransient<IArticleCategoryApplication, ApplicationArticleCategory>();
            services.AddTransient<IArticleCategoryValidator, ArticleCategoryValidator>();
            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IArticleValidator, ArticleValidator>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<ICommentApplication, CommentApplication>();

            services.AddTransient<IUnitOfWork,UnitOfWorkEf>();


            services.AddTransient<IArticleQuery, ArticleQuery>();

            services.AddDbContext<BlogContext>(options=>options.UseSqlServer(connectionstring));
        }

    }
}