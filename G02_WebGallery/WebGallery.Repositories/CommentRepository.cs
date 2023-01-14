using WebGallery.DTO;
using WebGallery.DTO.Interfaces;

namespace WebGallery.Repositories;

public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
{
    public CommentRepository(MyDbContext dbContext) : base(dbContext)
    {
    }
}