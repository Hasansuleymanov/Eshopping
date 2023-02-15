using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using WebMVC.Areas.Admin.Models;

namespace WebMVC.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class CategoryController : Controller
    {

        private readonly CategoryServices _categoryServices;
        private readonly IWebHostEnvironment _web;

        public CategoryController(CategoryServices categoryServices, IWebHostEnvironment web)
        {
            _categoryServices = categoryServices;
            _web = web;
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            CategoryListVM vm = new()
            {
                Categories = _categoryServices.GetAll(),
                Total=_categoryServices.GetCategoryCount(),
            };
            return View(vm);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category collection,IFormFile Photo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string filename=Guid.NewGuid().ToString() + Photo.FileName;
                    string wroot = Path.Combine(_web.WebRootPath, "image");
                    string fileFolder=Path.Combine(wroot, filename);
                    using FileStream f = new FileStream(fileFolder, FileMode.Create);
                    Photo.CopyTo(f);

                    collection.PhotoUrl = filename;
                    _categoryServices.Add(collection);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id==null) return NotFound();

            Category? selectedCategory = _categoryServices.GetByID(id.Value);

            if (selectedCategory==null) return NotFound();

            CategoryEditVM vm = new CategoryEditVM();
            vm.Name = selectedCategory.Name;
            vm.Id = selectedCategory.Id;
            vm.PhotoUrl = selectedCategory.PhotoUrl;
            return View(vm);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category collection, IFormFile Photo)
        {
            try
            {
                if (Photo != null)
                {
                    string filename = Guid.NewGuid().ToString() + Photo.FileName;
                    string wroot = Path.Combine(_web.WebRootPath, "image");
                    string fileFolder = Path.Combine(wroot, filename);
                    using FileStream f = new FileStream(fileFolder, FileMode.Create);
                    Photo.CopyTo(f);

                    collection.PhotoUrl = filename;
                }
                _categoryServices.Update(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Category? selectedCategory = _categoryServices.GetByID(id.Value);
            if (selectedCategory== null) return NotFound();
            return View(selectedCategory);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Category selectedCategory = _categoryServices.GetByID(id);
                _categoryServices.Delete(selectedCategory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
