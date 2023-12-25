using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Sir_Faizan_Method.Models;
using System.Linq;

namespace Sir_Faizan_Method.Controllers
{
    public class HomeController : Controller
    {
        public SirFaizanMethodContext db = new SirFaizanMethodContext();
        public IActionResult Read()
        {
            List<SirFaizanMethodTable> TableModel = db.SirFaizanMethodTables.ToList();
            return View(TableModel);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SirFaizanMethodTable Data)
        {
            if (ModelState.IsValid)
            {
                db.SirFaizanMethodTables.Add(Data);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Update(int? id)
        {
            SirFaizanMethodTable? data = db.SirFaizanMethodTables.Where(x => x.Id == id).SingleOrDefault();
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(SirFaizanMethodTable Data)
        {
            if (ModelState.IsValid)
            {
                db.Update(Data);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            SirFaizanMethodTable? data = db.SirFaizanMethodTables.Where(x => x.Id == id).SingleOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(SirFaizanMethodTable Data)
        {
            if (ModelState.IsValid)
            {
                db.Remove(Data);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Details(int? id)
        {
            SirFaizanMethodTable? data = db.SirFaizanMethodTables.Where(x => x.Id == id).SingleOrDefault();
            return View(data);
        }
    }
}
