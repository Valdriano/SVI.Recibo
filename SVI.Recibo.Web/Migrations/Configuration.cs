namespace SVI.Recibo.Web.Migrations
{
    using SVI.Recibo.Web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SVI.Recibo.Web.Context.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed( SVI.Recibo.Web.Context.ApplicationDbContext context )
        {
            context.Estados.AddOrUpdate( GetEstado );
            context.Municipios.AddOrUpdate( GetMunicipio );
            context.Configuracoes.AddOrUpdate( GetConfiguracao );
        }

        private Estado GetEstado => new Estado { Id = 1, Descricao = "Amazonas" };
        private Municipio GetMunicipio => new Municipio { Id = 1, Descricao = "Manaus", IdEstado = 1 };
        private Configuracao GetConfiguracao => new Configuracao { Id = 1, Email = "novo@email.com.br", IdEstado = 1, IdMunicipio = 1, Licenca = "Licença Basica", Proprietario = "Novo Proprietário" };
    }
}
