using WebGallery.DTO;
using WebGallery.DTO.Interfaces;

namespace WebGallery.Repositories;

public class PhotoItemRepository : RepositoryBase<PhotoItem>, IPhotoItemRepository
{
    public PhotoItemRepository(MyDbContext dbContext) : base(dbContext)
    {
    }
}
