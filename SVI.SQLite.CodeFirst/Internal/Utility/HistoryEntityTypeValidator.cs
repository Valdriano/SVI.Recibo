using SVI.SQLite.CodeFirst.Public.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVI.SQLite.CodeFirst.Internal.Utility
{
    internal class HistoryEntityTypeValidator
    {
        public static void EnsureValidType( Type historyEntityType )
        {
            if( !typeof( IHistory ).IsAssignableFrom( historyEntityType ) )
            {
                throw new InvalidOperationException( "The Type " + historyEntityType.Name + " does not implement the IHistory interface." );
            }
            if( historyEntityType.GetConstructor( Type.EmptyTypes ) == null )
            {
                throw new InvalidOperationException( "The Type " + historyEntityType.Name + " does not provide an parameterless constructor." );
            }
        }
    }
}
