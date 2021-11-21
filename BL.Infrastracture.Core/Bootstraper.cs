
using BL.Application;
using BL.Application.Contracts.ArticleCategory;
using BL.Domain.ArticleCategoryAgg;
using BL.Infrastracture.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BL.Domain.Services;

namespace BL.Infrastracture.Core
{
    public  class Bootstraper
    {
        public static void config(IServiceCollection services,string connectionstring )
        {
            services.AddTransient<IArticleCategpryRepository, ArticleCategoryRepository>();
            services.AddTransient<IArticleCategoryApplication, ApplicationArticleCategory>();
            services.AddTransient<IArticleCategoryValidator, ArticleCategoryValidator>();
            services.AddDbContext<BlogContext>(options=>options.UseSqlServer(connectionstring));
        }

    }
}