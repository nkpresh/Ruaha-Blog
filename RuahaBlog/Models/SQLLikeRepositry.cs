﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public class SQLLikeRepositry : ILikeRepository
    {
        private readonly AppDbContext context;
        public SQLLikeRepositry(AppDbContext context)
        {
            this.context = context;

        }
        public BlogLikes CreateLikes(BlogLikes like)
        {
            context.BlogLikes.Add(like);
            context.SaveChanges();
            return like;
        }
        public IEnumerable<BlogLikes> GetAllBlogLikes()
        {
            return context.BlogLikes;
        }
        public int GetNumberOfLikes(int Number)
        {
            int CountIt;
            //if (context.BlogLikes.Where(x => x.BlogId == Number).Count() != 0)
            //{
                var post = context.BlogLikes.Where(x => x.BlogId == Number);
            //post.Count();
            //}
            //else
            //{
                CountIt = 1;
            //}
            return CountIt;
        }
        public BlogLikes RemoveLike(BlogLikes likeToRemve)
        {
            context.BlogLikes.Remove(likeToRemve);
            context.SaveChanges();
            return likeToRemve;
        }

    }
}
