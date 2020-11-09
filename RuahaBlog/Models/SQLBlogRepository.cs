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
            context.BlogPosts.Add(bogPost);
            context.SaveChanges();
            return bogPost;
        }

        public BogPost Delete(int id)
        {
            BogPost bogPost = context.BlogPosts.Find(id);
            if (bogPost != null)
            {
                context.BlogPosts.Remove(bogPost);
                context.SaveChanges();
            }
            return bogPost;
        }

        public IEnumerable<BogPost> GetAllBlogPost()
        {
            return context.BlogPosts;
        }

        public BogPost GetBlogPost(int Id)
        {
            return context.BlogPosts.Find(Id);
        }

        public BogPost Update(BogPost blogPostChanges)
        {
            var blogPost = context.BlogPosts.Attach(blogPostChanges);
            blogPost.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return blogPostChanges;
        }
    }
}
