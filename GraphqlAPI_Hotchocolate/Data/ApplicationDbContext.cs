using GraphqlAPI_Hotchocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphqlAPI_Hotchocolate.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { 
        
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
