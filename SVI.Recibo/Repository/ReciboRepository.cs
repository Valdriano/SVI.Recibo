using SVI.Recibo.Context;
using SVI.Recibo.Model;
using System.Linq;
using System.Data.Entity;

namespace SVI.Recibo.Repository
{
    public class ReciboRepository : Repository<Model.Recibo, int>
    {
        public ReciboRepository( SVIReciboDbContext context ) : base( context )
        {

        }

        public Fornecedor GetFornecedor( int ID )
        {
            return context.Fornecedores.Find( ID );
        }

        public int MaxID()
        {
            return context.Recibos.Max( m => m.IDRecibo );
        }

        public override Model.Recibo SelecionarPorId( int key )
        {
            //return base.SelecionarPorId( key );

            return context.Set<Model.Recibo>().Include( i => i._Fornecedor ).SingleOrDefault( s => s.IDRecibo == key );
        }
    }
}
