﻿
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Microsoft.Net.Http.Headers;
using Motor.Models;
using Motor.Constant;
using web_motor.Models;

namespace AuthenticationAndAuthorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        R4rContext _context = new R4rContext();

        public static User user = new User();
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpPost("getAllUser")]
        [Authorize(Roles = DefaultString.ROLE_1)]
        public ActionResult<User> getAllUser()
        {
            return Ok(_context.Users.ToList());
        }

        [HttpPost("editUser")]
        [Authorize()]
        public async Task<ActionResult> editUser(editUser user)
        {
            var checkUser = _context.Users.Where(e => e.Email == user.Email).FirstOrDefault();

            if (checkUser == null)
            {
                return BadRequest("Không tìm thấy user");
            }
            // string passwordHash = BCrypt.Net.BCrypt.HashPassword(user.Password);
            checkUser.Fullname = user.Fullname;
            checkUser.Phone= user.Phone;
            // checkUser.Password = passwordHash;
            checkUser.Status = user.Status;
            checkUser.Roleid = user.Roleid;

            _context.Users.Update(checkUser);
            _context.SaveChanges();

            return Ok(checkUser);
        }

        [HttpPost("deleteUser")]
        [Authorize(Roles = DefaultString.ROLE_1)]
        public async Task<ActionResult> deleteUser(deleteUser user)
        {
            var Check = _context.Users.Where(e => e.Id == user.Id).FirstOrDefault();

            if (Check == null)
            {
                return BadRequest("Không tìm thấy User");
            }

            _context.Users.Remove(Check);
            _context.SaveChanges();

            return Ok();
        }
    }
}
