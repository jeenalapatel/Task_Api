﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TaskApi.Entities;

namespace TaskApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly TaskContext _context;

        public UserController(TaskContext context)
        {
            _context = context;
        }

        //Id will be autogenerated
        //we will make username and password unique field
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            try
            {
                var newUser = _context.Users.SingleOrDefaultAsync(s=>s.UserName==user.UserName);
                if (newUser != null)
                {
                    return BadRequest($"{newUser} is exist,give another username");
                }

                _context.Add(user);
                if (await _context.SaveChangesAsync() != 0)
                {
                    return Ok();
                }

                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("auth")]
        public async Task<IActionResult> AuthenticateUser(User user)
        {
            var ans = _context.Users.SingleOrDefaultAsync(s =>
                s.Password == user.Password && s.UserName == user.UserName);
            if (ans != null)
                return Ok();
            else
            {
                return BadRequest();
            }
            
        }

        //can't change Id
        //will get data using emailId
        [HttpPut("{username}")]
        public async Task<IActionResult> UpdateUserInfo(string username, User user)
        {
            try
            {
                var userDetail = _context.Users.SingleOrDefaultAsync(s=>s.UserName==user.UserName);
                if (userDetail == null) return BadRequest("user could not be found");
                _context.Add(user);
                if (await _context.SaveChangesAsync() != 0)
                {
                    return Ok();
                }

                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}