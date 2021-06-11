using SecretPerfume.Data;
using SecretPerfume.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Repositories
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly SecrectPerfumeDbContext _context;
        public ProductImageRepository(SecrectPerfumeDbContext context)
        {
            _context = context;
        }
    }
}
