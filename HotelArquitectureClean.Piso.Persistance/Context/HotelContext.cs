using Microsoft.EntityFrameworkCore;
using HotelArquitectureClean.Piso.Domain.Entities;

namespace HotelArquitectureClean.Piso.Persistance.Context
{
    public class HotelContext : DbContext
    {
        #region "Constructor"
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }
        #endregion
        #region"Db Sets"
        public DbSet<Domain.Entities.Piso> Piso { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Domain.Entities.Piso>().ToTable("Piso");

        }

    }
}
