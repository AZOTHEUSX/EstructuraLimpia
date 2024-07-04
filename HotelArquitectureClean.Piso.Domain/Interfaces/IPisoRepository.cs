
using HotelArquitectureClean.Piso.Domain.Entities;
using HotelArquitectureClean.Common.Data.Repository;

namespace HotelArquitectureClean.Piso.Domain.Interfaces
{
    public interface IPisoRepository : IBaseRepository<Domain.Entities.Piso, int>
    {
        List<Piso.Domain.Entities.Piso> GetPisosByPisoId(int pisoId);
    }
}
