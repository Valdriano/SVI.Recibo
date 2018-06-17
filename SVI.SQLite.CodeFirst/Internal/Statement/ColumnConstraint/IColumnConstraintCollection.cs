using System.Collections.Generic;

namespace SVI.SQLite.CodeFirst.Internal.Statement.ColumnConstraint
{
    interface IColumnConstraintCollection : ICollection<IColumnConstraint>, IColumnConstraint
    {
    }
}
