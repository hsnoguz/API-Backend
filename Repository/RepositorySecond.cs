using DAL.BaseEntites;
using DAL.Model;
using DAL.SecondModel;
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
  /*  public class RepositorySecond<T> : IRepository<T> where T : class
    {
        SecondDbContext _context;

        private DbSet<T> _entities;
        string _db = "";

        IQueryable<T> IRepository<T>.Table => throw new NotImplementedException();

        IQueryable<T> IRepository<T>.TableNoTracking => throw new NotImplementedException();
        
        public RepositorySecond(string db)
        {
            _db = db;
            //_context = new SecondDbContext(db);
            // _entities = _context.Set<T>();
        }
        public void createDB() {
            using (_context = new SecondDbContext(_db))
            {
                _context.Database.EnsureCreated();
            }
        }

        public virtual T GetById(object id)
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
                return _entities.Find(id);
            }

        }
        public IList<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using (_context = new SecondDbContext(_db))
            {
                return filter == null
                    ? _context.Set<T>().ToList()
                    : _context.Set<T>().Where(filter).ToList();
            }
        }


        public virtual T GetElement(Expression<Func<T, bool>> inclute)
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
                return _entities.Where(inclute).FirstOrDefault();
            }
        }

        public void Insert(T entity)
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
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
        }
        public virtual void Insert(IEnumerable<T> entities)
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
                if (entities == null)
                    throw new ArgumentNullException(nameof(entities));

                foreach (var entity in entities)
                    _entities.Add(entity);

                _context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
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
        }

        public virtual void Update(IEnumerable<T> entities)
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
                if (entities == null)
                    throw new ArgumentNullException(nameof(entities));

                _context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));
                _entities.Remove(entity);
                _context.SaveChanges();
            }
        }

        public virtual void Delete(IEnumerable<T> entities)
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
                if (entities == null)
                    throw new ArgumentNullException(nameof(entities));

                foreach (var entity in entities)
                    _entities.Remove(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<T> GetSql(string sql)
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
                return _entities.FromSqlRaw(sql);
            }
        }

        public int UpdateSql(string sql, params object[] _params)
        {
            using (_context = new SecondDbContext(_db))
            {

                return _context.Database.ExecuteSqlRaw(sql, _params);
            }
        }


        public IQueryable<T> InculeteMany(params Expression<Func<T, object>>[] includes)
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
                return _entities.IncludeMultiple(includes);
            }
        }

        public virtual IQueryable<T> Table() { 
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
                return _entities;
            }
            return null;
        }

        public virtual IQueryable<T> TableNoTracking()
        {
            using (_context = new SecondDbContext(_db))
            {
                _entities = _context.Set<T>();
                return _entities.AsNoTracking();
            }
            return null;
        }

        //  protected virtual DbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());
    }*/
}
