using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailingList.API.Data;
using MailingList.API.Dtos;
using MailingList.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MailingList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ISignupRepository _signupRepo;
        private readonly DataContext _context;
        public UsersController(DataContext context, ISignupRepository repo)
        {
            _context = context;
            _signupRepo = repo;
        }
        // GET api/users
        [HttpGet]
        // public async Task<IActionResult> GetAllUsers()
        // {
        //     var users = await _context.Members.ToListAsync();
        //     return Ok(users);
        // }

        // GET api/users/5
        [HttpGet("{id}")]
        // public async Task<IActionResult> GetUser(int id)
        // {
        //     var user = await _context.Members.FirstOrDefaultAsync(x => x.Id == id);
        //     return Ok(user);
        // }

        // POST api/values
        [HttpPost("register")]
        public async Task<IActionResult> Signup(MemberForSignupDto memberForSignupDto)
        { 
            memberForSignupDto.Email = memberForSignupDto.Email.ToLower();

            if(await _signupRepo.EmailExists(memberForSignupDto.Email))
                throw new Exception("This email has already registered");
                //return BadRequest("This email is already subscribed");

            var newMember = new Member
            {
                Email = memberForSignupDto.Email,
                Name = memberForSignupDto.Name
            };

            await _signupRepo.Signup(newMember);
            return StatusCode(201);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
