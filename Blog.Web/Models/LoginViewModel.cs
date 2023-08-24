﻿using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsPersistent { get; set; }
    }
}
