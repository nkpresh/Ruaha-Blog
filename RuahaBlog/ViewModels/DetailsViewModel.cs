using Microsoft.AspNetCore.Identity;
using RuahaBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.ViewModels
{
    public class DetailsViewModel
    {
        public IEnumerable<BlogComments> Comments { get; set; }
        public BogPost Post { get; set; }
        public string UserPicture { get; set; }
        public CustomisedUser MyUser { get; set; }
    }
}
