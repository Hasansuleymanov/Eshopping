using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HomeSliderService
    {
        private readonly ApplicationDbContext _context;
        public HomeSliderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<HomeSlider> GetAll()
        {
            return _context.HomeSliders.ToList();
        }
    }
}
