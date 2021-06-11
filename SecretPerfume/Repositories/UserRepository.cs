using SecretPerfume.Data;
using SecretPerfume.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SecrectPerfumeDbContext _context;
        public UserRepository(SecrectPerfumeDbContext context)
        {
            _context = context;
        }
    }
}
