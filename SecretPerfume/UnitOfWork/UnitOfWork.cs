using SecretPerfume.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly SecrectPerfumeDbContext _context;
        public UnitOfWork(SecrectPerfumeDbContext context)
        {
            _context = context;
        }
    }
}
