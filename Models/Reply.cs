﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AnonymousForum.Models
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }

        [StringLength(40)]
        [DisplayName("Title")]
        public string? ReplyTitle { get; set; }

        [Required(ErrorMessage = "Please insert a text")]
        [StringLength(500, MinimumLength = 3)]
        [DisplayName("Description")]
        public string? ReplyDescription { get; set; }

        [Required]
        [DisplayName("Thread")]
        public int FkThreadId { get; set; }

        [JsonIgnore]
        public virtual Thread? Thread { get; set; } // Navigation property to Thread
    }
}
