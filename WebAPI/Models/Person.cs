using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string User_ID { get; set; }

        public int Age { get; set; }

        public string PersonalCode { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; }

        public Person()
        {
            ApplicationUsers = new List<ApplicationUser>();
        }
    }
}
