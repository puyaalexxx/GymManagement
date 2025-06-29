using GymManagement.Domain.Subscriptions;
using Microsoft.EntityFrameworkCore;

namespace GymManagement.Infrastructure.Common.Persistence
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Subscription> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .ValueGeneratedNever();

            /* builder.Property("_maxGyms")
                 .HasColumnName("MaxGyms");*/

            builder.Property("_adminId").HasColumnName("AdminId");

            builder.Property(s => s.SubscriptionType)
                .HasConversion(
                    subscriptionType => subscriptionType.Name,
                    value => SubscriptionType.FromName(value, false));

            /*builder.Property<List<Guid>>("_gymIds")
                .HasColumnName("GymIds")
                .HasListOfIdsConverter();*/
        }
    }
}
