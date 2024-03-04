using System.ComponentModel.DataAnnotations;

namespace AnonymousForum.Models
{
    public class ForumThread
    {
        public int ForumThreadId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }
        public int TopicId { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
    }
}
