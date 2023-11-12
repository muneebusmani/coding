using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        CrudDbContext dbContext= new CrudDbContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var crudtb = dbContext.CrudTbs.ToList();
            return View(crudtb);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormModel model)
        {
            if (ModelState.IsValid)
            {
                using (var dbContext = new CrudDbContext())
                {
                    var crudTb = new CrudTb
                    {
                        Id=model.Id,
                        FirstName=model.FirstName,
                        LastName=model.LastName,
                        Gender=model.Gender,
                    };
                    dbContext.CrudTbs.Add(crudTb); // Add the data to the DbSet
                    dbContext.SaveChanges(); // Save changes to the database
                }

                return RedirectToAction("Index"); // Redirect after successful submission
            }

            // Handle ModelState not being valid (e.g., return to the form with errors)
            return View(model);
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}