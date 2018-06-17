using SVI.Recibo.Web.Models;

namespace SVI.Recibo.Web.TypesConfigurations
{
    public class FornecedorTypeConfiguration : AbstractTypeConfguration<Fornecedor>
    {
        protected override void Campos()
        {
            Property( x => x.Bairro ).HasMaxLength( 40 ).IsRequired();
            Property( x => x.CEP ).IsOptional();
            Property( x => x.CNPJ ).IsOptional();
            Property( x => x.Complemento ).HasMaxLength( 40 ).IsOptional();
            Property( x => x.CPF ).IsOptional();
            Property( x => x.Fantasia ).HasMaxLength( 40 ).IsOptional();
            Property( x => x.Id ).HasDatabaseGeneratedOption( System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity ).IsRequired();
            Property( x => x.IdEstado ).IsRequired();
            Property( x => x.IdMunicipio ).IsRequired();
            Property( x => x.Logo ).IsOptional();
            Property( x => x.Logradouro ).HasMaxLength( 40 ).IsRequired();
            Property( x => x.Nome ).HasMaxLength( 40 ).IsRequired();
            Property( x => x.Numero ).HasMaxLength( 10 ).IsRequired();
        }

        protected override void ChaveEstrangeira()
        {
            HasRequired( x => x.Estado ).WithMany( x => x.Fornecedores ).HasForeignKey( x => x.IdEstado ).WillCascadeOnDelete( false );
            HasRequired( x => x.Municipio ).WithMany( x => x.Fornecedores ).HasForeignKey( x => x.IdMunicipio ).WillCascadeOnDelete( false );
        }

        protected override void ChavePrimaria()
        {
            HasKey( x => x.Id );
        }

        protected override void Tabela()
        {
            ToTable( "Fornecedores" );
        }
    }
}