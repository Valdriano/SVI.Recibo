namespace SVI.Recibo.Infra.Migrations
{
    using SVI.Recibo.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SVI.Recibo.Infra.SVIReciboDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SVI.Recibo.Infra.SVIReciboDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Estados.AddOrUpdate( IniEstado );
            context.Municipios.AddOrUpdate( IniMunicipio );
            context.Configuracoes.AddOrUpdate( IniConfiguracao );
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
