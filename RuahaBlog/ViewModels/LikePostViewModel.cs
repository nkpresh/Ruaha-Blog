using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using RuahaBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.ViewModels
{
    public class LikePostViewModel
    {
        public int ID { get; set; }
        public int BlogID { get; set; }
        public int UserID { get; set; }

        private readonly UserManager<IdentityUser> user;
        private readonly BlogLikes likes;
        private readonly AppDbContext context;

        public LikePostViewModel(UserManager<IdentityUser> user, BlogLikes likes,
            AppDbContext context)
        {
            this.user = user;
            this.likes = likes;
            this.context = context;
        }

    }
}
