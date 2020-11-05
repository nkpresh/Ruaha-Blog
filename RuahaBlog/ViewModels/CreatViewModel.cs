using Microsoft.AspNetCore.Http;
using RuahaBlog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.ViewModels
{
    public class CreatViewModel
    {
        [Required]
        [MaxLength(50,ErrorMessage ="Name can not exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        public bool Visible { get; set; }
        [Required]
        public Category category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string WriteUp { get; set; }
        public IFormFile Photo { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }
    }
}
