using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assesment_2.Models;
using Microsoft.AspNetCore.Http;

namespace Assesment_2.Controllers
{
    public class CatagoriesManagementsController : Controller
    {
        private readonly Assesment_2Context _context;

        public CatagoriesManagementsController(Assesment_2Context context)
        {
            _context = context;
        }

        // GET: CatagoriesManagements
        public async Task<IActionResult> Index(string f)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Role")))
            {
                return RedirectToAction("Login", "UserManagements");
            }


            if (f == "all")
            {
                return View(_context.CatagoriesManagement.ToList());
            }

            var searcheddata = _context.CatagoriesManagement.Where(abc => abc.Name.Contains(f)).ToList();


            return View(searcheddata);
        }

        // GET: CatagoriesManagements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catagoriesManagement = await _context.CatagoriesManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (catagoriesManagement == null)
            {
                return NotFound();
            }

            return View(catagoriesManagement);
        }

        // GET: CatagoriesManagements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatagoriesManagements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Picture,Status")] CatagoriesManagement catagoriesManagement)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Role")))
            {
                return RedirectToAction("Login", "UserManagements");
            }

            if (ModelState.IsValid)
            {
                _context.Add(catagoriesManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catagoriesManagement);
        }

        // GET: CatagoriesManagements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catagoriesManagement = await _context.CatagoriesManagement.FindAsync(id);
            if (catagoriesManagement == null)
            {
                return NotFound();
            }
            return View(catagoriesManagement);
        }

        // POST: CatagoriesManagements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Picture,Status")] CatagoriesManagement catagoriesManagement)
        {
            if (id != catagoriesManagement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catagoriesManagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatagoriesManagementExists(catagoriesManagement.Id))
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
            return View(catagoriesManagement);
        }

        // GET: CatagoriesManagements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catagoriesManagement = await _context.CatagoriesManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (catagoriesManagement == null)
            {
                return NotFound();
            }

            return View(catagoriesManagement);
        }

        // POST: CatagoriesManagements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catagoriesManagement = await _context.CatagoriesManagement.FindAsync(id);
            _context.CatagoriesManagement.Remove(catagoriesManagement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatagoriesManagementExists(int id)
        {
            return _context.CatagoriesManagement.Any(e => e.Id == id);
        }
    }
}
