using SVI.Recibo.Model;

namespace SVI.Recibo.Infra.TypesConfigurations
{
    public class MunicipioTypeConfiguration : AbstractTypeConfguration<Municipio>
    {
        protected override void Campos()
        {
            this.Property( x => x.Descricao ).HasMaxLength( 40 ).IsRequired();
            this.Property( x => x.Id ).HasDatabaseGeneratedOption( System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity ).IsRequired();
            this.Property( x => x.IdEstado ).IsRequired();
        }

        protected override void ChaveEstrangeira()
        {
            this.HasRequired( x => x.Estado ).WithMany( x => x.Municipios ).HasForeignKey( x => x.IdEstado );            
        }

        protected override void ChavePrimaria()
        {
            this.HasKey( x => x.Id );
        }

        protected override void Tabela()
        {
            this.ToTable( "Municipios" );
        }
    }
}
