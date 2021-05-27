using GraphqlAPI_Hotchocolate.Data;
using GraphqlAPI_Hotchocolate.Models;
using HotChocolate;
using HotChocolate.Data;
using System.Linq;

namespace GraphqlAPI_Hotchocolate.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(ApplicationDbContext))] // HotChocolate.Data.EntityFramework
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Article> GetArticles([ScopedService] ApplicationDbContext _context) {
            return _context.Articles;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection, UseFiltering, UseSorting]
        public IQueryable<Category> GetCategories([ScopedService] ApplicationDbContext _context)
        {
            return _context.Categories;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection, UseFiltering, UseSorting]
        public IQueryable<Author> GetAuthors([ScopedService] ApplicationDbContext _context)
        {
            return _context.Authors;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection, UseFiltering, UseSorting]
        public IQueryable<Tag> GetTags([ScopedService] ApplicationDbContext _context)
        {
            return _context.Tags;
        }

    }
}
