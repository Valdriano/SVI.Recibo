using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SVI.Recibo.Web.Repository
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        TEntity Get( TKey key );
        List<TEntity> GetList( Expression<Func<TEntity, bool>> where = null );
        void Insert( TEntity entity );
        void Update( TEntity entity );
        void Delete( TEntity entity );
        void DeleteForId( TKey key );
    }
}
