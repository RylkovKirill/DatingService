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
        public async Task<ActionResult<Request>> Post(Request request)
        {
            
            _requestService.Add(request);
            return Ok(request);
        }

        
    }
    
    
}
