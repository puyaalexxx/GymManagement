namespace GymManagement.Domain.Subscriptions
{
    public class Subscription
    {
        private readonly Guid _adminId;

        public Guid Id { get; private set; }

        public SubscriptionType SubscriptionType { get; private set; } = null!;

        private Subscription()
        {
        }

        public Subscription(SubscriptionType subscriptionType, Guid adminId, Guid? id = null)
        {
            SubscriptionType = subscriptionType;
            _adminId = adminId;
            Id = id ?? Guid.NewGuid();
        }
    }
}
