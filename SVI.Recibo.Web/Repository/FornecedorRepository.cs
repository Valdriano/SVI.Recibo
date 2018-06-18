using SVI.Recibo.Web.Context;
using SVI.Recibo.Web.Models;

namespace SVI.Recibo.Web.Repository
{
    public class FornecedorRepository : Repository<Fornecedor, int>
    {
        public FornecedorRepository( ApplicationDbContext context ) : base( context )
        {

        }
    }
}