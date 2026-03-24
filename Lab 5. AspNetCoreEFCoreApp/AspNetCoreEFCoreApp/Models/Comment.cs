
namespace AspNetCoreEFCoreApp.Models;

public class Comment
{
    public int CommentId { get; set; }

    public string Content { get; set; } = null!;
 
    public DateTime Date { get; set; }

    public int PostId { get; set; }

    public Post? Post { get; set; }
    public ICollection<Comment>? Comments { get; set; }    
}
