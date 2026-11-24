using Microsoft.EntityFrameworkCore;
using MVC___Session_1.Entities;

namespace MVC___Session_1.Context.Configuration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plan> builder)
        {
            builder.Property(P => P.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("Plan_DurationDays_Check", "DurationDays Between 1 And 365");
            });
        }
    }
}
