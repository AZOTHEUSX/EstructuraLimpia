using HotelArquitectureClean.Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelArquitectureClean.Recepcion.Domain.Interfaces
{
    public interface IRecepcionRepository : IBaseRepository<Domain.Entities.Recepcion, int>
    {
        List<Recepcion.Domain.Entities.Recepcion> GetRecepcionsByRecepcionId(int recepcionId);
    }
}
