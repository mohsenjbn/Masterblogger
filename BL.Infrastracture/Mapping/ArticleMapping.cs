
using BL.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BL.Infrastracture.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.ArticleCategoryId).IsRequired();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.ShortDescribtion).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne(p => p.category).WithMany(p => p.Articles).HasForeignKey(p => p.ArticleCategoryId);
            builder.HasMany(p=>p.Comments).WithOne(p=>p.Article).HasForeignKey(p => p.ArticleId);

        }
    }
}
