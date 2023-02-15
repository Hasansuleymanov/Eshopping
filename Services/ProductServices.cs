using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HomeSliderservices
    {
        private readonly ApplicationDbContext _context;
        public HomeSliderservices(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<HomeSlider> GetAll()
        {
            return _context.HomeSliders.Where(c => !c.IsDeleted).ToList();
        }

        public List<HomeSlider> GetHomeSliderIsNew()
        {
            return _context.HomeSliders.Where(p=>p.IsDeleted).ToList() ;
        }

        public List<HomeSlider> GetDiscountHomeSliders()
        {
            return _context.HomeSliders.Where(p=>!p.IsDeleted).ToList();
        }


        public HomeSlider? GetByID(int id)
        {
            return _context.HomeSliders.FirstOrDefault(c => c.Id == id);
        }

        
        public void Add(HomeSlider HomeSlider)
        {
            _context.Add(HomeSlider);
            _context.SaveChanges();
        }
        public void Update(HomeSlider HomeSlider)
        {
            _context.Update(HomeSlider);
            _context.SaveChanges();
        }
        public void Delete(HomeSlider HomeSlider)
        {
            HomeSlider.IsDeleted = true;
            _context.SaveChanges();
        }
    }
}
