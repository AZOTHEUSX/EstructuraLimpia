using HotelArquitectureClean.Recepcion.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelArquitectureClean.Recepcion.Persistance.Repositories
{
    public class RecepcionRepository : IRecepcionRepository
    {
        public void Delete(Domain.Entities.Recepcion entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Domain.Entities.Recepcion, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Recepcion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Recepcion GetEntityBy(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Recepcion> GetRecepcionsByRecepcionId(int recepcionId)
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Entities.Recepcion entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entities.Recepcion entity)
        {
            throw new NotImplementedException();
        }
    }
}
