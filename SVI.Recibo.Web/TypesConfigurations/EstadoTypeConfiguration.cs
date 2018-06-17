using SVI.Recibo.Web.Models;

namespace SVI.Recibo.Web.TypesConfigurations
{
    public class EstadoTypeConfiguration : AbstractTypeConfguration<Estado>
    {
        protected override void Campos()
        {
            Property( x => x.Descricao ).HasMaxLength( 40 ).IsRequired();
            Property( x => x.Id ).HasDatabaseGeneratedOption( System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity ).IsRequired();
        }

        protected override void ChaveEstrangeira()
        {

        }

        protected override void ChavePrimaria()
        {
            HasKey( x => x.Id );
        }

        protected override void Tabela()
        {
            ToTable( "Estados" );
        }
    }
}