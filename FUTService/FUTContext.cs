namespace FUTService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FUTContext : DbContext
    {
        public FUTContext()
            : base("name=FUTContext")
        {
            base.Configuration.ProxyCreationEnabled = true;
        }

        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .Property(e => e.Position)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
