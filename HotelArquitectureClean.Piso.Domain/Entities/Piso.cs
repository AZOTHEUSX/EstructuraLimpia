

using HotelArquitectureClean.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelArquitectureClean.Piso.Domain.Entities
{
    public class Piso : AuditEntity<int>
    {
        [Column("IdPiso")]
        public override int Id { get; set; }
    }
}
