using ErrorOr;
using MediatR;

namespace GymManagement.Application.Commands.CreateSubscription
{
    public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Guid>>
    {

        public async Task<ErrorOr<Guid>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            return Guid.NewGuid();
        }
    }
}
