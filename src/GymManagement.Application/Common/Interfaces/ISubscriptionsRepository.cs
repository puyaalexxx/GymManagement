using GymManagement.Domain.Subscriptions;

namespace GymManagement.Application.Common.Interfaces
{
    public interface ISubscriptionsRepository
    {
        Task AddSubscriptionAsync(Subscription subscription);

        Task<Subscription?> GetByIdAsync(Guid subscriptionId);

        /*Domain.Subscriptions.Subscription GetSubscriptionById(Guid id);
        IEnumerable<Domain.Subscriptions.Subscription> GetAllSubscriptions();
        void UpdateSubscription(Domain.Subscriptions.Subscription subscription);
        void DeleteSubscription(Guid id);*/
    }
}
