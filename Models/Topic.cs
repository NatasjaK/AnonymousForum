using System.ComponentModel.DataAnnotations;

namespace AnonymousForum.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public virtual ICollection<ForumThread> ForumThreads { get; set; }
    }
}
