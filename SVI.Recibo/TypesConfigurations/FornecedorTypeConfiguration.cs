using SVI.Recibo.Model;
using System.Data.Entity.ModelConfiguration;

namespace SVI.Recibo.TypesConfigurations
{
    public class FornecedorTypeConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorTypeConfiguration()
        {
            ToTable( "Fornecedores" );
            HasKey( pk => pk.IDFornecedor );
            Property( p => p.Bairro ).IsRequired().HasMaxLength( 60 );
            Property( p => p.CEP ).IsOptional();
            Property( p => p.Complemento ).IsOptional().HasMaxLength( 150 );
            Property( p => p.CPFCNPJ ).IsRequired();
            Property( p => p.IDFornecedor ).HasDatabaseGeneratedOption( System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity );
            Property( p => p.Lougradouro ).IsRequired().HasMaxLength( 60 );
            Property( p => p.Nome ).IsRequired().HasMaxLength( 60 );
            Property( p => p.Numero ).IsOptional().HasMaxLength( 10 );
            Property( p => p.Logo ).IsOptional();
        }
    }
}
