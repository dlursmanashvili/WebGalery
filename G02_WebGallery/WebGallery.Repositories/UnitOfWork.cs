
using WebGallery.DTO.Interfaces;

namespace WebGallery.Repositories;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly MyDbContext _context;
    private Lazy<ICommentRepository> _commentRepository;
    private Lazy<IPhotoItemRepository> _photoItemRepository;
    private Lazy<IUserRepository> _userRepository;
    public UnitOfWork()
    {
        _context = new();
        _commentRepository = new Lazy<ICommentRepository> (() => new CommentRepository(_context));
        _photoItemRepository = new Lazy<IPhotoItemRepository>(() => new PhotoItemRepository(_context));
        _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_context));
    }

    public ICommentRepository CommentRepository => _commentRepository.Value;    
    public IPhotoItemRepository PhotoItemRepository => _photoItemRepository.Value;
    public IUserRepository UserRepository => _userRepository.Value;
    public void Commit() => _context.SaveChanges();
    public void Dispose() => _context.Dispose();

}
