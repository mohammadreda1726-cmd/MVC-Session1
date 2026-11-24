using Microsoft.EntityFrameworkCore;
using MVC___Session_1.Entities;

namespace MVC___Session_1.Context.Configuration
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(M => M.Id);

            builder.Property(M => M.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");
        }
    }
}
