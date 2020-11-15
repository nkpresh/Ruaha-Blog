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
        public BogPost Blog { get; set; }
        public int UserID { get; set; }
 
    }
}
