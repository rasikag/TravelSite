using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSite.Models
{
    public class TripContext : DbContext
    {
        public TripContext()
        : base("TravelSiteConnectionString")
        {
        }

        public DbSet<Stop> Stops { get; set; }
        public DbSet<Trip> Trips { get; set; }

    }

}
