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
    }
}