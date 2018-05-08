using System.Data.Entity.ModelConfiguration;

namespace SVI.Recibo.TypesConfigurations
{
    public class ReciboTypeConfiguration : EntityTypeConfiguration<Model.Recibo>
    {
        public ReciboTypeConfiguration()
        {
            ToTable("Recibos");
            HasKey(pk => pk.IDRecibo);
            HasRequired(r => r._Fornecedor).WithMany(w => w._Recibos).HasForeignKey(fk => fk.IDFornecedor);
            Property(p => p.DataHora).IsRequired();
            Property(p => p.IDFornecedor).IsRequired();
            Property(p=> p.IDRecibo).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(p => p.Referencia).IsRequired().HasMaxLength(100);
            Property(p => p.Valor).HasPrecision(13, 4).IsRequired();
        }
    }
}
