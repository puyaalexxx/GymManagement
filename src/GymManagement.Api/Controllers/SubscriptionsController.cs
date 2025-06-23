﻿using GymManagement.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SubscriptionsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateSubscription(CreateSubscriptionRequest request)
        {
            return Ok(request);
        }

        [HttpGet]
        public IActionResult GetSubscription()
        {
            return Ok("success");
        }
    }
}
