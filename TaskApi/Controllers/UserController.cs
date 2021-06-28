using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TaskApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> CreateUser()
        {
            
        }

        [HttpGet("{userName}")]
        public async Task<ActionResult> GetUserByPassword()
        {
            
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult>UpdateUserInfo()
        {
            
        }
    }
}
