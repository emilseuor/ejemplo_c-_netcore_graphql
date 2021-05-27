using HotChocolate.Types;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphqlAPI_Hotchocolate.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Secret { get; set; }

        public virtual IList<Article> Articles { get; set; }

    }

    public class AuthorType : ObjectType<Author> {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            //base.Configure(descriptor);
            descriptor.Field(x => x.Secret).Ignore();
        }
    }
}
