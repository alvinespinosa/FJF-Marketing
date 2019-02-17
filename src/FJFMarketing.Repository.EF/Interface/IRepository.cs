using System.Collections.Generic;

namespace FJFMarketing.Repository.EF.Interface
{
    public interface IRepository<T> where T : class
    {
        //T FindId(Guid id);
        //IEnumerable<T> GetAll();
        //IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
