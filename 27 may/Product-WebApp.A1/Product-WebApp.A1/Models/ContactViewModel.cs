﻿using System.ComponentModel.DataAnnotations;

namespace Product_WebApp.A1.Models
{
    public class ContactViewModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Message too long.")]
        public string Message { get; set; }
    }
}
