namespace SVI.SQLite.CodeFirst.Internal.Statement.ColumnConstraint
{
    internal class NotNullConstraint : IColumnConstraint
    {
        public string CreateStatement()
        {
            return "NOT NULL";
        }
    }
}
