using SVI.Recibo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVI.Recibo.Infra.TypesConfigurations
{
    public class MunicipioTypeConfiguration : AbstractTypeConfguration<Municipio>
    {
        protected override void Campos()
        {
            throw new NotImplementedException();
        }

        protected override void ChaveEstrangeira()
        {
            this.HasOptional( x => x.Estado ).WithMany( x => x.Municipios ).HasForeignKey( x => x.IdEstado );
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
