using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SVI.Recibo.Web.Context;
using SVI.Recibo.Web.Models;

namespace SVI.Recibo.Web.Repository
{
    public class FornecedorRepository : Repository<Fornecedor, int>
    {
        public FornecedorRepository( ApplicationDbContext context ) : base( context )
        {

        }

        public override List<Fornecedor> GetList( Expression<Func<Fornecedor, bool>> where = null )
        {
            if( where == null )
            {
                return dbContext.Set<Fornecedor>().Include( x => x.Estado ).Include( x => x.Municipio ).ToList();
            }
            else
            {
                return dbContext.Set<Fornecedor>().Where( where ).Include( x => x.Estado ).Include( x => x.Municipio ).ToList();
            }
        }
    }
}