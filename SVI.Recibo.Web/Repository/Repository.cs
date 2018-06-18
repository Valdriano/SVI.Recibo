using SVI.Recibo.Web.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SVI.Recibo.Web.Repository
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        protected ApplicationDbContext dbContext;

        public Repository( ApplicationDbContext dbContext )
        {
            try
            {
                this.dbContext = dbContext;
            }
            catch( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }

        public virtual void Delete( TEntity entity )
        {
            try
            {
                dbContext.Entry( entity ).State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
            catch( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }

        public virtual void DeleteForId( TKey key )
        {
            try
            {
                TEntity entity = Get( key );
                Delete( entity );
            }
            catch( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }

        public virtual TEntity Get( TKey key )
        {
            try
            {
                return dbContext.Set<TEntity>().Find( key );
            }
            catch( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }

        public virtual List<TEntity> GetList( Expression<Func<TEntity, bool>> where = null )
        {
            try
            {
                DbSet<TEntity> dbTable = dbContext.Set<TEntity>();

                if( where == null )
                {
                    return dbTable.ToList();
                }
                else
                {
                    return dbTable.Where( where ).ToList();
                }
            }
            catch( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }

        public virtual void Insert( TEntity entity )
        {
            try
            {
                dbContext.Set<TEntity>().Add( entity );
                dbContext.SaveChanges();
            }
            catch( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }

        public virtual void Update( TEntity entity )
        {
            try
            {
                dbContext.Entry( entity ).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
            catch( Exception ex )
            {

                throw new Exception(ex.Message);
            }
        }
    }
}