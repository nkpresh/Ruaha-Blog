using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public class BlogComments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BlogPostId { get; set; }
        public string Body { get; set; }

    }
}
