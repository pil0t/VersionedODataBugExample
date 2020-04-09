using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Mvc;
using ModelAndControllers;

namespace VersionedOdataBug
{
    public class FooBarConfiguration : IModelConfiguration
    {
        public void Apply( ODataModelBuilder builder, ApiVersion apiVersion )
        {
            builder.EntitySet<Foo>( "Foos" ).EntityType.HasKey( p => p.Id );
            builder.EntitySet<Bar>( "Bars" ).EntityType.HasKey( p => p.Id );
        }
    }
}