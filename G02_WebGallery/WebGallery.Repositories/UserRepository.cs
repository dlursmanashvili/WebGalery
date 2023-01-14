using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebGallery.DTO;
using WebGallery.DTO.Interfaces;

namespace WebGallery.Repositories;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(MyDbContext dbContext) : base(dbContext)
    {
    }
}
