using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Entits
{
    public class Location
    {
        [Required]
        [MaxLength(50)]
        public string State { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string Village { get; set; }

        [MaxLength(150)]
        public string FullAddress { get; set; }

        [MaxLength(50)]
        public string LocationE { get; set; }

        [MaxLength(50)]
        public string LocationN { get; set; }
    }
}
