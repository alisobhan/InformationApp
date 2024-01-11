using Domain.Base;
using System.Linq.Expressions;

namespace Domain.Contracts;

public interface IGenericRepository<TEntity> where TEntity : BaseEntity 
{
    TEntity GetBy(int id);
    IEnumerable<TEntity> GetAll();
    IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);
    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void SaveChanges();
}
