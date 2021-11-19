using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IRequestService _requestService;
        public ApiController(IRequestService requestService)
        {
            _requestService = requestService;

        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "das" + id;
        }
        [HttpPost]
        public async Task<ActionResult<Request>> Post(RequestApi requestApi)
        {
            Request request = new Request();
            request.ReceiverId = Guid.Parse(requestApi.receiverId);
            request.SenderId = Guid.Parse(requestApi.senderId);
            _requestService.Add(request);

            return Ok(request);
        }

        public class RequestApi
        {
            public string receiverId { get; set; }
            public string senderId { get; set; }
        }
    }
    
    
}
