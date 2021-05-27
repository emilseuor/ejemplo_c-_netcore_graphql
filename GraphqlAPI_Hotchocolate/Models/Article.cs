using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphqlAPI_Hotchocolate.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Subtitle { get; set; }

        [Required, MaxLength(2000)]
        public string Body { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual IList<Tag> Tags { get; set; }

    }
}
