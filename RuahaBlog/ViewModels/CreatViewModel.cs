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
        public bool Visible { get; set; }
        [Required]
        public Category category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string WriteUp { get; set; }
        public IFormFile Photo { get; set; }
    }
}
