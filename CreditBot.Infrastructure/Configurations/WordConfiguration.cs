using CreditBot.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreditBot.Infrastructure.Configurations
{
    public class WordConfiguration : IEntityTypeConfiguration<Word>
    {
        public void Configure(EntityTypeBuilder<Word> builder)
        {
            builder.HasOne(x => x.CreatedByMember)
                   .WithMany(x => x.CreatedWords)
                   .HasForeignKey(x => x.CreatedByMemberId);

            builder.HasOne(x => x.DeletedByMember)
                   .WithMany(x => x.DeletedWords)
                   .HasForeignKey(x => x.DeletedByMemberId);
        }
    }
}
