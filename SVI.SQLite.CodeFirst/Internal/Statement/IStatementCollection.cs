using System.Collections.Generic;

namespace SVI.SQLite.CodeFirst.Internal.Statement
{
    public interface IStatementCollection : IStatement, ICollection<IStatement>
    {
    }
}
