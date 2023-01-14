#nullable disable
namespace WebGallery.DTO;

public class User
{
    public int UserId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }
    public ICollection<PhotoItem> PhotoItems { get; set; }
}
