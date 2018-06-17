using SVI.SQLite.CodeFirst.Internal.Builder.NameCreators;
using SVI.SQLite.CodeFirst.Internal.Statement;
using SVI.SQLite.CodeFirst.Internal.Utility;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace SVI.SQLite.CodeFirst.Internal.Builder
{
    internal class CreateDatabaseStatementBuilder : IStatementBuilder<CreateDatabaseStatement>
    {
        private readonly EdmModel edmModel;

        public CreateDatabaseStatementBuilder( EdmModel edmModel )
        {
            this.edmModel = edmModel;
        }

        public CreateDatabaseStatement BuildStatement()
        {
            var createTableStatements = GetCreateTableStatements();
            var createIndexStatements = GetCreateIndexStatements();
            var createStatements = createTableStatements.Concat<IStatement>( createIndexStatements );
            var createDatabaseStatement = new CreateDatabaseStatement( createStatements );
            return createDatabaseStatement;
        }

        private IEnumerable<CreateTableStatement> GetCreateTableStatements()
        {
            var associationTypeContainer = new AssociationTypeContainer( edmModel.AssociationTypes, edmModel.Container );

            foreach( var entitySet in edmModel.Container.EntitySets )
            {
                var tableStatementBuilder = new CreateTableStatementBuilder( entitySet, associationTypeContainer );
                yield return tableStatementBuilder.BuildStatement();
            }
        }

        private IEnumerable<CreateIndexStatementCollection> GetCreateIndexStatements()
        {
            foreach( var entitySet in edmModel.Container.EntitySets )
            {
                var indexStatementBuilder = new CreateIndexStatementBuilder( entitySet );
                yield return indexStatementBuilder.BuildStatement();
            }
        }
    }
}
