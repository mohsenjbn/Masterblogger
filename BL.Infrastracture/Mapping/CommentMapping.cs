

using BL.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BL.Infrastracture.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
          builder.HasKey(x => x.Id);
            builder.Property(p => p.Name);
            builder.Property(p => p.CreationDate);
            builder.Property(p => p.Email);
            builder.Property(p => p.Name);
            builder.Property(p => p.Status);
            
            builder.HasOne(p=>p.Article).WithMany(p=>p.Comments).HasForeignKey(p=>p.ArticleId);


        }
    }
}
