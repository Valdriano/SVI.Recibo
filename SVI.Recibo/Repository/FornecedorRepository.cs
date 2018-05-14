using SVI.Recibo.Context;
using SVI.Recibo.Model;

namespace SVI.Recibo.Repository
{
    public class FornecedorRepository : Repository<Fornecedor, int>
    {
        public FornecedorRepository( SVIReciboDbContext context ) : base( context )
        {

        }
    }
}
