using SVI.Recibo.Web.Context;
using SVI.Recibo.Web.Models;

namespace SVI.Recibo.Web.Repository
{
    public class EstadoRepository : Repository<Estado, int>
    {
        public EstadoRepository( ApplicationDbContext context )
            : base( context )
        {

        }
    }
}