using GymManagement.Domain.Subscriptions;

namespace GymManagement.Application.Common.Interfaces
{
    public interface ISubscriptionRepository
    {
        void AddSubscriptionAsync(Subscription subscription);

        /*Domain.Subscriptions.Subscription GetSubscriptionById(Guid id);
        IEnumerable<Domain.Subscriptions.Subscription> GetAllSubscriptions();
        void UpdateSubscription(Domain.Subscriptions.Subscription subscription);
        void DeleteSubscription(Guid id);*/
    }
}
