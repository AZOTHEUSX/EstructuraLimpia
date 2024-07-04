using Microsoft.EntityFrameworkCore;
using HotelArquitectureClean.Recepcion.Domain.Entities;

namespace HotelArquitectureClean.Recepcion.Persistance.Context
{
    public class HotelContext : DbContext
    {
        #region "Constructor"
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }
        #endregion
        #region"Db Sets"
        public DbSet<Domain.Entities.Recepcion> RECEPCION { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Recepcion>().ToTable("RECEPCION");

        }

    }
}
