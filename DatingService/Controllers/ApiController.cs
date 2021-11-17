using DatingService.Domain.Auth;
using DatingService.Domain.Entities;
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
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "xui" + id;
        }
       /* [HttpPost]
        public async Task<ActionResult<Request>> Post(ApplicationUser sender, ApplicationUser receiver)
        {
            Request request = new Request();

            return Ok();
        }*/
    }
    
    
}
