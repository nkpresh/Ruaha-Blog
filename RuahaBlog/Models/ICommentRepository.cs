using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public interface ICommentRepository
    {
        BlogComments Comment(BlogComments Comment);
        IEnumerable<BlogComments> GetAllComment();
        BlogComments GetComment(int Id);
        int GetNumberOfComments();
    }
}
