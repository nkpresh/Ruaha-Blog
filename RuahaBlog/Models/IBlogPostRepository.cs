using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public interface IBlogPostRepository
    {
        BogPost Creat(BogPost bogPost);
        BogPost GetBlogPost(int Id);
        IEnumerable<BogPost> GetAllBlogPost();
        BogPost Update(BogPost blogPostChange);
        BogPost Delete(int id);

    }
}
