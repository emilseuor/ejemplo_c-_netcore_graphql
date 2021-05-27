using HotChocolate;
using HotChocolate.Types;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphqlAPI_Hotchocolate.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)] 
        [GraphQLDescription("This description will appear in documentation of the schema")]
        public string Name { get; set; }

        public virtual IList<Article> Articles { get; set; }

    }
    public class CategoryType : ObjectType<Category>
    {
        protected override void Configure(IObjectTypeDescriptor<Category> descriptor)
        {
            //base.Configure(descriptor);
            descriptor.Description("Descripting the whole Category model");
            descriptor.Field(x=> x.Id).Description("This the [GraphQLDescription()] field that in model");
        }
    }
}