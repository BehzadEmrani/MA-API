using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Entits
{
    public class LocationArtistPerformance : Location
    {
        [Key]
        public int Id { get; set; }

        public int TypeMusicLocal { get; set; }

        [ForeignKey("TypeMusicLocal")]
        public virtual TypeMusicLocal TypeMusicLocals { get; set; }

        public int Instrumext { get; set; }

        [ForeignKey("Instrumext")]
        public virtual Instrumexts Instrumexts { get; set; }

        public bool SingleSinging { get; set; }

        [MaxLength(150)]
        public string Commented { get; set; }

        public bool TimeFree { get; set; }

        public bool TimeChange { get; set; }

      
    }
}
