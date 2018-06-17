using SVI.Recibo.Model;

namespace SVI.Recibo.Infra.TypesConfigurations
{
    public class EstadosTypeConfiguration : AbstractTypeConfguration<Estados>
    {
        protected override void Campos()
        {
            this.Property( x => x.Descricao ).HasMaxLength( 40 ).IsRequired();
            this.Property( x => x.Id ).HasDatabaseGeneratedOption( System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity ).IsRequired();
        }

        protected override void ChaveEstrangeira()
        {
          
        }

        protected override void ChavePrimaria()
        {
            this.HasKey( x => x.Id );
        }

        protected override void Tabela()
        {
            this.ToTable( "Estados" );
        }
    }
}
