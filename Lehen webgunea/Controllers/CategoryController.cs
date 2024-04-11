
using Lehen_webgunea.DataAccess.Data;
using Lehen_webgunea.DataAccess.Repository.IRepository;
using Lehen_webgunea.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lehen_webgunea.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository db )
        {
            _categoryRepo = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _categoryRepo.GetAll().ToList();
            return View(objCategoryList);
        }
        public IActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display Order cannot exactly match the Name.");
            }

            if (ModelState.IsValid)
            {

                _categoryRepo.Add(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Edit(int? id )
        {
            if (id==null || id == 0)
            {
                return NotFound();

            }
            Category? categoryFromDB = _categoryRepo.Get(u => u.Category21Id == id);
            //Category? categoryfromDB1 = _db.Categories.FirstOrDefault(u=>u.Category21Id==id);
            //Category? categoryfromDB2 = _db.Categories.Where(u => u.Category21Id == id).FirstOrDefault();
            if (categoryFromDB == null)
            {
                return NotFound();
            }
            return View(categoryFromDB);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
           
            if (ModelState.IsValid)
            {

                _categoryRepo.Add(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }
            Category? categoryFromDB = _db.Categories.Find(id);
           
            if (categoryFromDB == null)
            {
                return NotFound();
            }
            return View(categoryFromDB);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
