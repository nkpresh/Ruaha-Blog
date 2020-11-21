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
        [Required]
        public bool Visible { get; set; }
        [Required]
        public string Headline { get; set; }
        [Required]
        public string WriteUp { get; set; }
        public string PhotoPaths { get; set; }
        public Category Category { get; set; }
        public DateTime PostTime { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfComments { get; set; }

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
