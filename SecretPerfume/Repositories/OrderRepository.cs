using SecretPerfume.Data;
using SecretPerfume.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SecrectPerfumeDbContext _context;
        public OrderRepository(SecrectPerfumeDbContext context)
        {
            _context = context;
        }
    }
}
