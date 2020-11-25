using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public class CustomisedUser:IdentityUser
    {
       public  string ProfilePicture { get; set; }
    }
}
