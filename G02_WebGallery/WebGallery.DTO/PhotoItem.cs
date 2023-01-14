#nullable disable 
namespace WebGallery.DTO;

public class PhotoItem
{
    public int PhotoId { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string DraftTitle { get; set; }
    public string Description { get; set; }
    public string DraftDescription { get; set; }
    public bool IsPublished { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreateDate { get; set; }

    public User User { get; set; }
    public ICollection<Comment> Comments { get; set; }
}
