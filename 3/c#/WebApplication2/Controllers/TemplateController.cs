using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TemplateController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TemplateController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Template
        public async Task<IActionResult> Index()
        {
              return _context.templateTbs != null ? 
                          View(await _context.templateTbs.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.templateTbs'  is null.");
        }

        // GET: Template/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.templateTbs == null)
            {
                return NotFound();
            }

            var templateTb = await _context.templateTbs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (templateTb == null)
            {
                return NotFound();
            }

            return View(templateTb);
        }

        // GET: Template/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Template/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Email,PhoneNumber,Password")] TemplateTb templateTb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(templateTb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(templateTb);
        }

        // GET: Template/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.templateTbs == null)
            {
                return NotFound();
            }

            var templateTb = await _context.templateTbs.FindAsync(id);
            if (templateTb == null)
            {
                return NotFound();
            }
            return View(templateTb);
        }

        // POST: Template/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Email,PhoneNumber,Password")] TemplateTb templateTb)
        {
            if (id != templateTb.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(templateTb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TemplateTbExists(templateTb.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(templateTb);
        }

        // GET: Template/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.templateTbs == null)
            {
                return NotFound();
            }

            var templateTb = await _context.templateTbs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (templateTb == null)
            {
                return NotFound();
            }

            return View(templateTb);
        }

        // POST: Template/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.templateTbs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.templateTbs'  is null.");
            }
            var templateTb = await _context.templateTbs.FindAsync(id);
            if (templateTb != null)
            {
                _context.templateTbs.Remove(templateTb);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TemplateTbExists(int id)
        {
          return (_context.templateTbs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
