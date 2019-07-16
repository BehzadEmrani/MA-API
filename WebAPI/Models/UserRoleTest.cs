using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class UserRoleTest
    {
        [Key]
        public int UserRoleID { get; set; }

        public string User_ID { get; set; }

        public bool Edit { get; set; }

        public bool Delete { get; set; }

        public bool Add { get; set; }

        public bool Active { get; set; }

        public string SetData { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; }

        public UserRoleTest()
        {
            ApplicationUsers = new List<ApplicationUser>();
        }
    }
}
