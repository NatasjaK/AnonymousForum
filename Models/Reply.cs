namespace AnonymousForum.Models
{
    public class Reply
    {
        public int ReplyId { get; set; }
        public string Content { get; set; }
        public int ForumThreadId { get; set; }

        public virtual ForumThread ForumThread { get; set; }
    }
}
