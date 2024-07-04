

using System.Linq.Expressions;

namespace HotelArquitectureClean.Common.Data.Repository
{
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetEntityBy(TType id);
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        bool Exists(Expression<Func<TEntity, bool>> filter);
    }
}
