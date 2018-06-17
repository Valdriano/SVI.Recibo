using System.Data.Entity.ModelConfiguration;

namespace SVI.Recibo.Infra.TypesConfigurations
{
    public abstract class AbstractTypeConfguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : class
    {
        public AbstractTypeConfguration()
        {
            Campos();
            ChaveEstrangeira();
            ChavePrimaria();
            Tabela();
        }

        protected abstract void Campos();
        protected abstract void ChaveEstrangeira();
        protected abstract void ChavePrimaria();
        protected abstract void Tabela();
    }
}
