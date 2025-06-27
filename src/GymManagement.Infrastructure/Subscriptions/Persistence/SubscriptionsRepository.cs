using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using GymManagement.Infrastructure.Common.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.Subscriptions.Persistence
{
    public class SubscriptionsRepository : ISubscriptionsRepository
    {
        private readonly GymManagementDbContext _dbContext;

        public SubscriptionsRepository(GymManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddSubscriptionAsync(Subscription subscription)
        {
            _dbContext.Subscriptions.Add(subscription);
        }

        public async Task<Subscription?> GetByIdAsync(Guid subscriptionId)
        {
            return await _dbContext.Subscriptions.FindAsync(subscriptionId);
        }
    }
}
