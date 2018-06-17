using System.Data.Entity.Core.Metadata.Edm;

namespace SVI.SQLite.CodeFirst.Public
{
    public interface ISqlGenerator
    {
        string Generate( EdmModel storeModel );
    }
}
