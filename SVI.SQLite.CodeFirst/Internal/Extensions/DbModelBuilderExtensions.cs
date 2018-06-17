using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVI.SQLite.CodeFirst.Internal.Extensions
{
    internal static class DbModelBuilderExtensions
    {
        public static void RegisterAttributeAsColumnAnnotation<TAttribute>( this DbModelBuilder modelBuilder )
            where TAttribute : class
        {
            modelBuilder.Properties()
                .Having( x => x.GetCustomAttributes( false ).OfType<TAttribute>().FirstOrDefault() )
                .Configure( ( config, attribute ) => config.HasColumnAnnotation( typeof( TAttribute ).Name, attribute ) );
        }
    }
}
