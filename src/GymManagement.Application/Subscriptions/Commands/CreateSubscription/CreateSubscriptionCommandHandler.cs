using ErrorOr;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Subscription>>
    {
        private readonly ISubscriptionsRepository _subscriptionRepository;
        private readonly IUnitOfWork _unitOfWork;


        public CreateSubscriptionCommandHandler(ISubscriptionsRepository subscriptionRepository, IUnitOfWork unitOfWork)
        {
            _subscriptionRepository = subscriptionRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<Subscription>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            //create a subscription
            var subscription = new Subscription
            {
                Id = Guid.NewGuid()
            };

            //add it to the database
            await _subscriptionRepository.AddSubscriptionAsync(subscription);

            //commit the changes to the database
            await _unitOfWork.CommitChangesAsync(cancellationToken);

            //return subscription
            return subscription;
        }
    }
}
