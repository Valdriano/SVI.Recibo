using SVI.SQLite.CodeFirst.Public.Attributes;
using System.Text;

namespace SVI.SQLite.CodeFirst.Internal.Statement.ColumnConstraint
{
    internal class UniqueConstraint : IColumnConstraint
    {
        private const string Template = "UNIQUE {conflict-clause}";

        public OnConflictAction OnConflict { get; set; }

        public string CreateStatement()
        {
            var sb = new StringBuilder( Template );

            sb.Replace( "{conflict-clause}", OnConflict != OnConflictAction.None ? "ON CONFLICT " + OnConflict.ToString().ToUpperInvariant() : string.Empty );

            return sb.ToString().Trim();
        }
    }
}
