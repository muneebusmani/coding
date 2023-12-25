using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext db;
        public ProductController(ApplicationDbContext db)
        {
            this.db  = db;
        }
        public IActionResult Index()
        {
            List<Product> ProductList = db.Products.ToList();
            return View(ProductList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index","Product");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            db.Products.Where(x=>x.ProductId == id).SingleOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
                db.Update(product);
                int a=db.SaveChanges();
                return RedirectToAction("Index", "Product");
        }

        public IActionResult Delete(int? id)
        {
            var d= db.Products.Where(x=>x.ProductId == id).SingleOrDefault();
            return View(d);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
                db.Remove(product);
                int a=db.SaveChanges();
                return RedirectToAction("Index", "Product");
        }
        public IActionResult Details(int? id)
        {
            var e = db.Products.Where(x => x.ProductId == id).SingleOrDefault();
            return View(e);
        }
    }
}
