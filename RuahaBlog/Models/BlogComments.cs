using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public class BlogComments
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPicture { get; set; }
        public string UserId { get; set; }
        public int BlogPostId { get; set; }
        public string Body { get; set; }
        public DateTime TimeOfComment { get; set; }

    }
}
