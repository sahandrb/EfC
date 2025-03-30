using System.Linq.Expressions;

namespace EfCore1
{
    public interface Repository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T,bool>>?filter);
        void Update(T entity);
        void Delete(T entity);
        

    }
}
