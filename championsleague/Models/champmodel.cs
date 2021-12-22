namespace championsleague.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class champmodel : DbContext
    {
        public champmodel()
            : base("name=champmodel")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.Team_name)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.League)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Country)
                .IsUnicode(false);
        }
    }
}
