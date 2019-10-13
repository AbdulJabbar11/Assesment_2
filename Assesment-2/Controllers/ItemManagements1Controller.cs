using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assesment_2.Models;

namespace Assesment_2.Controllers
{
    public class ItemManagements1Controller : Controller
    {
        private readonly Assesment_2Context _context;

        public ItemManagements1Controller(Assesment_2Context context)
        {
            _context = context;
        }

        // GET: ItemManagements1
        public async Task<IActionResult> Index(string f)
        {


            if (f == "all")
            {

                var d = _context.ItemManagement.ToList();
                return View(d);
            }


            var searchdata = _context.ItemManagement.Where(abc => abc.Name.Contains(f) ).ToList();

            return View(searchdata);
        }

        // GET: ItemManagements1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemManagement = await _context.ItemManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemManagement == null)
            {
                return NotFound();
            }

            return View(itemManagement);
        }

        // GET: ItemManagements1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemManagements1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CatagoryId,Name,Description,Quantity,Costprice,Saleprice,Mainlmage,Itemcode,Maincolor,Status")] ItemManagement itemManagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemManagement);
        }

        // GET: ItemManagements1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemManagement = await _context.ItemManagement.FindAsync(id);
            if (itemManagement == null)
            {
                return NotFound();
            }
            return View(itemManagement);
        }

        // POST: ItemManagements1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CatagoryId,Name,Description,Quantity,Costprice,Saleprice,Mainlmage,Itemcode,Maincolor,Status")] ItemManagement itemManagement)
        {
            if (id != itemManagement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemManagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemManagementExists(itemManagement.Id))
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
            return View(itemManagement);
        }

        // GET: ItemManagements1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemManagement = await _context.ItemManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemManagement == null)
            {
                return NotFound();
            }

            return View(itemManagement);
        }

        // POST: ItemManagements1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemManagement = await _context.ItemManagement.FindAsync(id);
            _context.ItemManagement.Remove(itemManagement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemManagementExists(int id)
        {
            return _context.ItemManagement.Any(e => e.Id == id);
        }

        public string DeleteAirline(int id)
        {
            ItemManagement A = _context.ItemManagement.Find(id);

            _context.ItemManagement.Remove(A);
            _context.SaveChanges();
            return "1";
        }
    }
}
