using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public class CommentViewModel
    {
        public int PostId { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }
        public string Comment { get; set; }
        public CustomisedUser GetUser { get; set; }
        public IEnumerable<BlogComments> ListOfComments { get; set; }
    }
}
