using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private AuthenticationContext _context;
        public UserProfileController(UserManager<ApplicationUser> userManager, AuthenticationContext context)
        {
            _userManager = userManager;

            _context = context;
        }

        [HttpGet]
        [Authorize]
        //GET : /api/UserProfile
        public async Task<Object> GetUserProfile() {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);
            var role = _context.UserRoleTests.Find(user.UserRoleID);

            return new
            {
                user.Id,
                user.FullName,
                user.Email,
                user.UserName,
                user.UserRoleTest.UserRoleID,
                user.UserRoleTest.Add,
                user.UserRoleTest.Edit,
                user.UserRoleTest.Delete
            };
        }
    }
}