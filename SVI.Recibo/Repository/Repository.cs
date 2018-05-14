﻿using SVI.Recibo.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SVI.Recibo.Repository
{
    public abstract class Repository<TEntity, TKey> : IRepository<TEntity, TKey>, IDisposable where TEntity : class
    {
        protected SVIReciboDbContext context;

        public  Repository( SVIReciboDbContext context )
        {
            this.context = context;
        }

        public virtual void Atualizar( TEntity entity )
        {
            context.Entry( entity ).State = EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Inserir( TEntity entity )
        {
            context.Set<TEntity>().Add( entity );
            context.SaveChanges();
        }

        public void Dispose()
        {
            if( this.context != null )
                context.Dispose();
        }

        public virtual void ExclirPorId( TKey key )
        {
            TEntity entity = SelecionarPorId( key );
            Excluir( entity );
        }

        public virtual void Excluir( TEntity entity )
        {
            context.Entry( entity ).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public virtual List<TEntity> Listar( Expression<Func<TEntity, bool>> expression = null )
        {
            DbSet<TEntity> entities = context.Set<TEntity>();

            if( expression == null )
            {
                return entities.ToList();
            }
            else
            {
                return entities.Where( expression ).ToList();
            }
        }

        public virtual TEntity SelecionarPorId( TKey key )
        {
            return context.Set<TEntity>().Find( key );
        }
    }
}
