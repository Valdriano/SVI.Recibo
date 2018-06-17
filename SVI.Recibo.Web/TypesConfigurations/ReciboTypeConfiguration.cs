namespace SVI.Recibo.Web.TypesConfigurations
{
    public class ReciboTypeConfiguration : AbstractTypeConfguration<Models.Recibo>
    {
        protected override void Campos()
        {
            Property( x => x.Data ).IsRequired();
            Property( x => x.Id ).HasDatabaseGeneratedOption( System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity ).IsRequired();
            Property( x => x.IdEstado ).IsRequired();
            Property( x => x.IdFornecedor ).IsRequired();
            Property( x => x.IdMunicipio ).IsRequired();
            Property( x => x.QuantidadeImpressao ).IsRequired();
            Property( x => x.Referencia ).HasMaxLength( 100 ).IsRequired();
            Property( x => x.Valor ).HasPrecision( 13, 4 ).IsRequired();
        }

        protected override void ChaveEstrangeira()
        {
            HasRequired( x => x.Estado ).WithMany( x => x.Recibos ).HasForeignKey( x => x.IdEstado ).WillCascadeOnDelete( false );
            HasRequired( x => x.Fornecedor ).WithMany( x => x.Recibos ).HasForeignKey( x => x.IdFornecedor ).WillCascadeOnDelete( false );
            HasRequired( x => x.Municipio ).WithMany( x => x.Recibos ).HasForeignKey( x => x.IdMunicipio ).WillCascadeOnDelete( false );
        }

        protected override void ChavePrimaria()
        {
            HasKey( x => x.Id );
        }

        protected override void Tabela()
        {
            ToTable( "Recibos" );
        }
    }
}