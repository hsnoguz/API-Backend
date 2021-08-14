using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Table { get; }
        IQueryable<T> InculeteMany(params Expression<Func<T, object>>[] includes);
        IQueryable<T> TableNoTracking { get; }
        T GetById(object id);

        T GetElement(Expression<Func<T, bool>> inclute);
        void Insert(T entity);
        void Insert(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        public int UpdateSql(string sql, params object[] _params);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        IEnumerable<T> GetSql(string sql);

    }
}
