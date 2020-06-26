using Microsoft.EntityFrameworkCore;
using MyTaxi.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taxi.Web.Data.Entities;

namespace MyTaxi.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        public DbSet<TaxiEntity> Taxis { get; set; }
        public DbSet<TripEntity> Trips { get; set; }
        public DbSet<TripDetailEntity> TripDetails { get; set; }
    }
}
