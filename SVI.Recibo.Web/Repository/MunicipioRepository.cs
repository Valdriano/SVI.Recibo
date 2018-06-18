using SVI.Recibo.Web.Context;
using SVI.Recibo.Web.Models;

namespace SVI.Recibo.Web.Repository
{
    public class MunicipioRepository : Repository<Municipio, int>
    {
        public MunicipioRepository( ApplicationDbContext context )
            : base( context )
        {

        }
    }
}