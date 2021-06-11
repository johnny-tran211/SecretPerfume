using SecretPerfume.Data;
using SecretPerfume.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Repositories
{
    public class DiscountTypeRepository : IDiscountTypeRepository
    {
     private readonly SecrectPerfumeDbContext _context;
        public DiscountTypeRepository(SecrectPerfumeDbContext context)
        {
            _context = context;
        }   
    }
}
