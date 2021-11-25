﻿using BL.Domain.ArticleAgg;
using BL.Domain.ArticleCategoryAgg;
using BL.Domain.Services;
using BL.Infrastracture.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BL.Infrastracture
{
    public class BlogContext:DbContext
    {
        public DbSet<ArticleCategory> ArticleCategories { get; set; }

        public DbSet<Article> Articles { get; set; }



        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}