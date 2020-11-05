using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public class BogPost
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid Email Format")]
        [Display(Name="Mail Adrs")]
        public string Email { get; set; }
        [Required]
        public bool Visible { get; set; }
        [Required]
        public string Headline { get; set; }
        [Required]
        public string WriteUp { get; set; }
        public string PhotoPaths { get; set; }
        public Category category { get; set; }

    }
    public enum Category
    {
        Entertainment,
        Sports,
        Business,
        Lifestyle,
        Cars,
        luxury
    }
}
