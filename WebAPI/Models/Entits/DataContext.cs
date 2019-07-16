using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Entits
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option)
        { 
        }

        public DbSet<TypeMusicLocal> TypeMusicLocals { get; set; }

        public DbSet<LocationArtistPerformance> LocationArtistPerformances { get; set; }

        public DbSet<Instrumexts> Instrumexts { get; set; }
    }
}
