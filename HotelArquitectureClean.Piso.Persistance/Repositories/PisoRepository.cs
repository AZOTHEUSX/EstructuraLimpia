



using HotelArquitectureClean.Piso.Domain.Interfaces;
using System.Linq.Expressions;

namespace HotelArquitectureClean.Piso.Persistance.Repositories
{
    public class PisoRepository : IPisoRepository
    {
        public void Delete(Domain.Entities.Piso entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Domain.Entities.Piso, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Piso> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Piso GetEntityBy(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Piso> GetPisosByPisoId(int pisoId)
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Entities.Piso entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entities.Piso entity)
        {
            throw new NotImplementedException();
        }
    }
}
