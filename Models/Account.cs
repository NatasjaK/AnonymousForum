﻿using System.ComponentModel.DataAnnotations;

namespace AnonymousForum.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Invalid")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Invalid")]
        public string? Password { get; set; }
    }
}
