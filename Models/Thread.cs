﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AnonymousForum.Models
{
    public class Thread
    {
        [Key]
        public int ThreadId { get; set; }

        [Required(ErrorMessage = "Please insert a valid title")]
        [StringLength(40, MinimumLength = 3), DisplayName("Title")]
        public string? ThreadTitle { get; set; }

        [Required(ErrorMessage = "Please insert a description")]
        [DisplayName("Description")]
        public string? ThreadDescription { get; set; }

        [Required]
        [DisplayName("Topic")]
        public int FkTopicId { get; set; }

        [JsonIgnore]
        public virtual Topic? Topic { get; set; }

        [JsonIgnore]
        public List<Reply>? Replies { get; set; }
    }
}
