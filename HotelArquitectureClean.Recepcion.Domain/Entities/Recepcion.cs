

using HotelArquitectureClean.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelArquitectureClean.Recepcion.Domain.Entities
{
    public class Recepcion : AuditEntity<int>
    {
        [Column("IdRecepcion")]
        public override int Id { get; set; }
    }
}
