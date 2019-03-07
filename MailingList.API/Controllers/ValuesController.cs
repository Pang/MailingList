using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailingList.API.Data;
using MailingList.API.Dtos;
using MailingList.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace MailingList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ISignupRepository _repo;
        public ValuesController(ISignupRepository repo)
        {
            _repo = repo;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return null;
        }

        // POST api/values
        [HttpPost("register")]
        public async Task<IActionResult> Signup(MemberForSignupDto memberForSignupDto)
        {
            memberForSignupDto.Email = memberForSignupDto.Email.ToLower();

            var newMember = new Member
            {
                Email = memberForSignupDto.Email,
                Name = memberForSignupDto.Name
            };
            
            await _repo.Signup(newMember);
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
