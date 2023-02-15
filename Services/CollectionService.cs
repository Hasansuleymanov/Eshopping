using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CollectionService
    {
        private readonly ApplicationDbContext _context;
        public CollectionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Collection> GetAll()
        {
            return _context.Collections.ToList();
        }
    }
}
