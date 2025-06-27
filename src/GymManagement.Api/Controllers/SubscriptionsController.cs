using GymManagement.Application.Commands.CreateSubscription;
using GymManagement.Contracts.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISender _mediator;

        public SubscriptionsController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubscription(CreateSubscriptionRequest request)
        {
            var command = new CreateSubscriptionCommand(request.SubscriptionType.ToString(), request.AdminId);

            var createSubscriptionResult = await _mediator.Send(command);

            return createSubscriptionResult.MatchFirst(
                guid => Ok(new SubscriptionResponse(guid, request.SubscriptionType)),
                errors => Problem()
            );
        }

        [HttpGet]
        public IActionResult GetSubscription()
        {
            return Ok("success");
        }
    }
}
