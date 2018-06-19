using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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

        public override List<Municipio> GetList( Expression<Func<Municipio, bool>> where = null )
        {
            if( where == null )
            {
                return dbContext.Set<Municipio>().Include( x => x.Estado ).ToList();
            }
            else
            {
                return dbContext.Set<Municipio>().Where( where ).Include( x => x.Estado ).ToList();
            }
        }
    }
}