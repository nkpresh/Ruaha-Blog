using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public interface ILikeRepository
    {
        BlogLikes RemoveLike(BlogLikes likeToRemve);
        BlogLikes CreateLikes(BlogLikes like);
        int GetNumberOfLikes(int Number);
        public IEnumerable<BlogLikes> GetAllBlogLikes();

    }
}
