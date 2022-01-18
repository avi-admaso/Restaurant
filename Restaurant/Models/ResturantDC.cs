using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Restaurant.Models
{
    public partial class ResturantDC : DbContext
    {
        public ResturantDC()
            : base("name=ResturantDC")
        {
        }
        public virtual DbSet<Waiter> Waiters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
