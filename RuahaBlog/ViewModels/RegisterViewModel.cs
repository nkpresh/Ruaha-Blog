﻿using Microsoft.AspNetCore.Http;
using RuahaBlog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(20, ErrorMessage = "Name can not exceed 20 characters")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name ="Comfirm Password")]
        [Compare("Password",ErrorMessage ="Password and Confirm Password do not match")]
        public string ConfirmPassword { get; set; }
        [Required]
        public UserType User { get; set; }
        public IFormFile Photo { get; set; }

    }
}
 