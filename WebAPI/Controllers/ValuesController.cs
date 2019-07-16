using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private AuthenticationContext _context;

        public ValuesController(AuthenticationContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;

            _userManager = userManager;
        }

        // GET api/values
        [HttpGet]
        public async Task<object> Get()
        {
           // ApplicationUser user = await _userManager.FindByIdAsync("1");

           // string name = user.FullName;

            

           // //var role = user.UserRoleTest.Role1;
           // var role = _context.UserRoleTests.Find(user.UserRoleID);

           // var roles = user.UserRoleTest.UserRoleID;

           //var user1 = user.UserRoleTest.UserRoleID.ToString();

            return new object[] { "reza", "nouri"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
