﻿using GymManagement.Application.Commands.CreateSubscription;
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

            var subscriptionId = await _mediator.Send(command);

            var response = new SubscriptionResponse(subscriptionId, request.SubscriptionType);

            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetSubscription()
        {
            return Ok("success");
        }
    }
}
