using GraphqlAPI_Hotchocolate.Data;
using GraphqlAPI_Hotchocolate.Models;
using HotChocolate;
using HotChocolate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlAPI_Hotchocolate.GraphQL
{
    public class Mutations
    {
        public record AddCategoryInput(string name);
        public record AddTagInput(string name);
        public record AddArticleInput(string title, string subtitle, string body, int categoryId);

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Category> AddCategoryAsync(AddCategoryInput input, [ScopedService] ApplicationDbContext _context) {
            
            Category new_category = new Category { 
                Name = input.name
            };
            _context.Categories.Add(new_category);
            await _context.SaveChangesAsync();

            return new_category;
        }
        
        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Category> UpdateCategoryAsync(Category input, [ScopedService] ApplicationDbContext _context)
        {
            _context.Categories.Update(input);
            await _context.SaveChangesAsync();

            return input;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Tag> AddTagAsync(AddTagInput input, [ScopedService] ApplicationDbContext _context)
        {

            Tag new_tag = new Tag
            {
                Name = input.name
            };
            _context.Tags.Add(new_tag);
            await _context.SaveChangesAsync();

            return new_tag;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Tag> UpdateTagAsync(Tag input, [ScopedService] ApplicationDbContext _context)
        {
            _context.Tags.Update(input);
            await _context.SaveChangesAsync();

            return input;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Article> AddArticleAsync(AddArticleInput input, [ScopedService] ApplicationDbContext _context)
        {

            Article new_article = new Article
            {
                Title = input.title,
                Subtitle = input.subtitle,
                Body = input.body,
                CategoryId = input.categoryId
            };

            _context.Articles.Add(new_article);
            
            await _context.SaveChangesAsync();

            return new_article;
        }
    }
}
