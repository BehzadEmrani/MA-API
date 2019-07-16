using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Entits
{
    public class Instrumexts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Comment { get; set; }

        public bool Active { get; set; }


        public ICollection<LocationArtistPerformance> LocationArtistPerformances { get; set; }

        public Instrumexts()
        {
            LocationArtistPerformances = new List<LocationArtistPerformance>();
        }
    }
}
