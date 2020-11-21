using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public class SQLCommentRepository : ICommentRepository
    {
        private readonly AppDbContext context;

        public SQLCommentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public BlogComments Comment(BlogComments Comment)
        {
            context.BlogComments.Add(Comment);
            context.SaveChanges();
            return Comment;
        }

        public IEnumerable<BlogComments> GetAllComment()
        {
            return context.BlogComments;
        }

        public BlogComments GetComment(int Id)
        {
            var comment = context.BlogComments.FirstOrDefault(x => x.Id == Id);
            return comment;
        }

        public int GetNumberOfComments()
        {
            return context.BlogComments.Count();
        }
    }
}
