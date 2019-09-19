using Microsoft.EntityFrameworkCore;
using BelediyeUlasimProjesi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelediyeUlasimProjesi.EntityFramework
{
    public class BelediyeUlasimProjesiDbContext:DbContext
    {
        public BelediyeUlasimProjesiDbContext(DbContextOptions<BelediyeUlasimProjesiDbContext> options):base(options)
        {
        }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Station> Stations { get; set; }
    }
}
