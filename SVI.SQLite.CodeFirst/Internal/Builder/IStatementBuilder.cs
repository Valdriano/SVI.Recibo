using SVI.SQLite.CodeFirst.Internal.Statement;

namespace SVI.SQLite.CodeFirst.Internal.Builder
{
    internal interface IStatementBuilder<out TStatement>
        where TStatement : IStatement
    {
        TStatement BuildStatement();
    }
}
