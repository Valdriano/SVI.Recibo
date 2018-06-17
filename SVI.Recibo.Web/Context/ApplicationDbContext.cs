using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using SVI.Recibo.Web.Models;

namespace SVI.Recibo.Web.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base( "DefaultConnection", throwIfV1Schema: false )
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            base.OnModelCreating( modelBuilder );

            ModelBuilderConfiguration.Configure( modelBuilder );
        }

        public virtual DbSet<Configuracao> Configuracoes { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Fornecedor> Fornecedorss { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Models.Recibo> Recibos { get; set; }
    }
}