using DAL.BaseEntites;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        ManagerContext _context;

        private DbSet<T> _entities;

        public Repository(ManagerContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public virtual T GetById(object id)
        {
            return Entities.Find(id);
        }

        public virtual T GetElement(Expression<Func<T, bool>> inclute)
        {
            return _entities.Where(inclute).FirstOrDefault();
        }

        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            //            _context.Entry(entity).Property("InsertTime").CurrentValue = DateTime.Now;
            //---------------

            MetadataTypeAttribute[] metadataTypes = entity.GetType().GetCustomAttributes(true).OfType<MetadataTypeAttribute>().ToArray();
            foreach (MetadataTypeAttribute metadata in metadataTypes)
            {
                System.Reflection.PropertyInfo[] properties = metadata.MetadataClassType.GetProperties();
                //Metadata atanmış entity'nin tüm propertyleri tek tek alınır.
                foreach (System.Reflection.PropertyInfo pi in properties)
                {
                    //Eğer ilgili property ait CryptoData flag'i var ise ilgili deger encrypt edilir.
                    if (Attribute.IsDefined(pi, typeof(SetCurrentDate)))
                    {

                        _context.Entry(entity).Property(pi.Name).CurrentValue = DateTime.Now;
                    }
                }
            }


            _entities.Add(entity);
            _context.SaveChanges();
        }

        public virtual void Insert(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach (var entity in entities)
                Entities.Add(entity);

            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            MetadataTypeAttribute[] metadataTypes = entity.GetType().GetCustomAttributes(true).OfType<MetadataTypeAttribute>().ToArray();
            foreach (MetadataTypeAttribute metadata in metadataTypes)
            {
                System.Reflection.PropertyInfo[] properties = metadata.MetadataClassType.GetProperties();
                //Metadata atanmış entity'nin tüm propertyleri tek tek alınır.
                foreach (System.Reflection.PropertyInfo pi in properties)
                {
                    //Eğer ilgili property ait CryptoData flag'i var ise ilgili deger encrypt edilir.
                    if (Attribute.IsDefined(pi, typeof(SetCurrentDate)))
                    {

                        _context.Entry(entity).Property(pi.Name).CurrentValue = DateTime.Now;
                    }
                }
            }


            _context.SaveChanges();
        }

        public virtual void Update(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            Entities.Remove(entity);
            _context.SaveChanges();
        }

        public virtual void Delete(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach (var entity in entities)
                Entities.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetSql(string sql)
        {
            return Entities.FromSqlRaw(sql);
        }

        public int UpdateSql(string sql, params object[] _params)
        {
            return _context.Database.ExecuteSqlRaw(sql, _params);
        }


        public IQueryable<T> InculeteMany(params Expression<Func<T, object>>[] includes)
        {
            return _entities.IncludeMultiple(includes);
        }

        public virtual IQueryable<T> Table => Entities;

        public virtual IQueryable<T> TableNoTracking => Entities.AsNoTracking();

        protected virtual DbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());
    }
}
