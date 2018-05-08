namespace SVI.Recibo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SVI.Recibo.Context.SVIReciboDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed( SVI.Recibo.Context.SVIReciboDbContext context )
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Configuracoes.AddOrUpdate(
                new Model.Configuracao()
                {
                    Email = "novo.email@emai.com",
                    IDConfiguracao = 1,
                    Licenca = "licença basica de uso",
                    Local = "Manaus",
                    Proprietario = "novo proprietario"
                }
                );
        }
    }
}
