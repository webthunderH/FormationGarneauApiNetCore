using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDonneeSql
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContextGarneau _context;

        public UnitOfWork(DbContextGarneau context)
        {
            _context = context;
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }

        public void SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}
