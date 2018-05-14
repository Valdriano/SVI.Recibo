using SVI.Recibo.Context;
using SVI.Recibo.Model;

namespace SVI.Recibo.Repository
{
    public class ConfiguracaoRepository : Repository<Configuracao, int>
    {
        public ConfiguracaoRepository( SVIReciboDbContext context ) : base( context )
        {

        }
    }
}
