using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Data;
using VegetableStore.Interfaces;

namespace VegetableStore.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public EFUnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
