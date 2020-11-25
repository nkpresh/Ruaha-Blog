using RuahaBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.ViewModels
{
    public class HomeDetailsViewModel
    {
        public BogPost BlogPost { get; set; }
        public BlogComments Comments { get; set; }
        public BlogLikes Likes { get; set; }
    }
}
