namespace championsleague.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class playermodel : DbContext
    {
        public playermodel()
            : base("name=playermodel")
        {
        }

        public virtual DbSet<Rank> Ranks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rank>()
                .Property(e => e.Player_name)
                .IsUnicode(false);

            modelBuilder.Entity<Rank>()
                .Property(e => e.Team_name)
                .IsUnicode(false);
        }
    }
}
