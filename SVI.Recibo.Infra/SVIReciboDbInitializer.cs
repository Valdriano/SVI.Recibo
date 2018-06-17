using SVI.Recibo.Model;
using SVI.SQLite.CodeFirst.Public.DbInitializers;
using System.Data.Entity;

namespace SVI.Recibo.Infra
{
    public class SVIReciboDbInitializer : SqliteDropCreateDatabaseWhenModelChanges<SVIReciboDbContext>
    {
        public SVIReciboDbInitializer( DbModelBuilder modelBuilder )
            : base( modelBuilder, typeof( CustomHistory ) )
        {
            
        }

        protected override void Seed( SVIReciboDbContext context )
        {
            
        }

        private Estados IniEstado
        {
            get
            {
                return new Estados { Id = 1, Descricao = "Amazonas" };
            }
        }

        private Municipio IniMunicipio
        {
            get
            {
                return new Municipio { Id = 1, Descricao = "Manaus", IdEstado = 1 };
            }
        }

        private Configuracao IniConfiguracao
        {
            get
            {
                return new Configuracao { Id = 1, Email = "novo@email.com.br", IdEstado = 1, IdMunicipio = 1, Licenca = "Licença Basica", Proprietario = "Novo Proprietario" };
            }
        }
    }
}
