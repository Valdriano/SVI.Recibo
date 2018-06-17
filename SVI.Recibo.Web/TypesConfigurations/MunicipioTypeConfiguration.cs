using SVI.Recibo.Web.Models;

namespace SVI.Recibo.Web.TypesConfigurations
{
    public class MunicipioTypeConfiguration : AbstractTypeConfguration<Municipio>
    {
        protected override void Campos()
        {
            Property( x => x.Descricao ).HasMaxLength( 40 );
            Property( x => x.Id ).HasDatabaseGeneratedOption( System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity ).IsRequired();
            Property( x => x.IdEstado ).IsRequired();
        }

        protected override void ChaveEstrangeira()
        {
            HasRequired( x => x.Estado ).WithMany( x => x.Municipios ).HasForeignKey( x => x.IdEstado ).WillCascadeOnDelete( false );
        }

        protected override void ChavePrimaria()
        {
            HasKey( x => x.Id );
        }

        protected override void Tabela()
        {
            ToTable( "Municipios" );
        }
    }
}