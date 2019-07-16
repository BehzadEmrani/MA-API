using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class AuthenticationContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> option):base(option)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<UserRoleTest> UserRoleTests { get; set; }
        public DbSet<Person> Prsons { get; set; }

        public DbSet<Report> Reports { get; set; }

        public DbSet<Message> Messages { get; set; }
    }
}
