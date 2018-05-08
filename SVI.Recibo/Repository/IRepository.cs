using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SVI.Recibo.Repository
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        List<TEntity> Listar( Expression<Func<TEntity, bool>> expression = null );
        TEntity SelecionarPorId( TKey key );
        void Inserir( TEntity entity );
        void Atualizar( TEntity entity );
        void Excluir( TEntity entity );
        void ExclirPorId( TKey key );
    }
}
