using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SVI.SQLite.CodeFirst.Public
{
    public interface IDatabaseCreator
    {
        void Create( Database db, DbModel model );
    }
}
