using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public class SQLBlogRepository : IBlogPostRepository
    {
        private readonly AppDbContext context;

        public SQLBlogRepository(AppDbContext context)
        {
            this.context = context;
        }
        public BogPost Creat(BogPost bogPost)
        {
            context.blogPosts.Add(bogPost);
            context.SaveChanges();
            return bogPost;
        }

        public BogPost Delete(int id)
        {
            BogPost bogPost = context.blogPosts.Find(id);
            if (bogPost != null)
            {
                context.blogPosts.Remove(bogPost);
                context.SaveChanges();
            }
            return bogPost;
        }

        public IEnumerable<BogPost> GetAllBlogPost()
        {
            return context.blogPosts;
        }

        public BogPost GetBlogPost(int Id)
        {
            return context.blogPosts.Find(Id);
        }

        public BogPost Update(BogPost blogPostChanges)
        {
            var blogPost = context.blogPosts.Attach(blogPostChanges);
            blogPost.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return blogPostChanges;
        }
    }
}
