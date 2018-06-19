using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SVI.Recibo.Web.Context;
using System.Data.Entity;
using System.Linq;
using SVI.Recibo.Web.Models;

namespace SVI.Recibo.Web.Repository
{
    public class ReciboRepository : Repository<Models.Recibo, int>
    {
        public ReciboRepository( ApplicationDbContext context )
            : base( context )
        {

        }

        public override List<Models.Recibo> GetList( Expression<Func<Models.Recibo, bool>> where = null )
        {
            if( where == null )
            {
                return dbContext.Set<Models.Recibo>().Include( x => x.Fornecedor ).Include( x => x.Estado ).Include( x => x.Municipio ).ToList();
            }
            else
            {
                return dbContext.Set<Models.Recibo>().Where( where ).Include( x => x.Fornecedor ).Include( x => x.Estado ).Include( x => x.Municipio ).ToList();
            }
        }

        internal Models.Recibo Get( object id )
        {
            return dbContext.Set<Models.Recibo>().Find( id );
        }
    }
}