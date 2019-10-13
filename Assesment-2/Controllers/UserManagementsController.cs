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
    public class UserManagementsController : Controller
    {
        private readonly Assesment_2Context _context;

        public UserManagementsController(Assesment_2Context context)
        {
            _context = context;
        }

        // GET: UserManagements
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserManagement.ToListAsync());
        }

        // GET: UserManagements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userManagement = await _context.UserManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userManagement == null)
            {
                return NotFound();
            }

            return View(userManagement);
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Logout()
        {

            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Login));
            
        }


        [HttpPost]
        public IActionResult Login(UserManagement _U)
        {

            UserManagement U = _context.UserManagement.Where(abc => abc.Username == _U.Username && abc.Password == _U.Password).FirstOrDefault();

            if (U == null)
            {
                ViewBag.Message = "Invalid Credentials";
                return View(_U);
            }

            HttpContext.Session.SetString("Role", U.Role);
            HttpContext.Session.SetString("Username", U.Username);

            if (U.Role == "Admin")
            {
                return RedirectToAction(nameof(AdminDashboard));
            }
            else if (U.Role == "Staff")
            {
                return RedirectToAction(nameof(StaffDashboard));
            }


            return View();
        }


        public IActionResult AdminDashboard()
        {
            if (HttpContext.Session.GetString("Role") != null)
            {
                return View();
            }


            return RedirectToAction(nameof(Login));
        }

        public IActionResult StaffDashboard()
        {
            if (HttpContext.Session.GetString("Role") != null)
            {
                return View();
            }


            return RedirectToAction(nameof(Login));
        }

        // GET: UserManagements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserManagements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Displayname,Password,Email,Status,Role,ProfilePicture,RegisteredDate")] UserManagement userManagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userManagement);
        }

        // GET: UserManagements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userManagement = await _context.UserManagement.FindAsync(id);
            if (userManagement == null)
            {
                return NotFound();
            }
            return View(userManagement);
        }

        // POST: UserManagements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Displayname,Password,Email,Status,Role,ProfilePicture,RegisteredDate")] UserManagement userManagement)
        {
            if (id != userManagement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userManagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserManagementExists(userManagement.Id))
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
            return View(userManagement);
        }

        // GET: UserManagements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userManagement = await _context.UserManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userManagement == null)
            {
                return NotFound();
            }

            return View(userManagement);
        }

        // POST: UserManagements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userManagement = await _context.UserManagement.FindAsync(id);
            _context.UserManagement.Remove(userManagement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserManagementExists(int id)
        {
            return _context.UserManagement.Any(e => e.Id == id);
        }
    }
}
