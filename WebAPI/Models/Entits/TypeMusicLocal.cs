using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Entits
{
    public class TypeMusicLocal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Comment { get; set; }

        public bool Active { get; set; }

        public ICollection<LocationArtistPerformance> LocationArtistPerformances { get; set; }

        public TypeMusicLocal()
        {
            LocationArtistPerformances = new List<LocationArtistPerformance>();
        }
    }
}
