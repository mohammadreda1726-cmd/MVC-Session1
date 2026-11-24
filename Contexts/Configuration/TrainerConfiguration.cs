using Microsoft.EntityFrameworkCore;
using MVC___Session_1.Entities;

namespace MVC___Session_1.Context.Configuration
{
    public class TrainerConfiguration : GymUserConfigurations<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(T => T.CreatedAt)
                   .HasColumnName("HireDate")
                   .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
