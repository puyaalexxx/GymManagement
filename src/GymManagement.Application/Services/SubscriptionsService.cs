namespace GymManagement.Application.Services
{
    public class SubscriptionsService : ISubscriptionsWriteService
    {
        public Guid CreateSubscription(string subscriptionType, Guid adminId)
        {
            return Guid.NewGuid();
        }
    }
}
