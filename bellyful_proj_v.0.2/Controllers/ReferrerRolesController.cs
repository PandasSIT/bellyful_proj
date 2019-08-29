using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bellyful_proj.Models;
using bellyful_proj_v._0._2.Data;

namespace bellyful_proj_v._0._2.Controllers
{
    public class ReferrerRolesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReferrerRolesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReferrerRoles
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReferrerRole.ToListAsync());
        }

        // GET: ReferrerRoles/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referrerRole = await _context.ReferrerRole
                .FirstOrDefaultAsync(m => m.RoleId == id);
            if (referrerRole == null)
            {
                return NotFound();
            }

            return View(referrerRole);
        }

        // GET: ReferrerRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReferrerRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleId,RoleName")] ReferrerRole referrerRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(referrerRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(referrerRole);
        }

        // GET: ReferrerRoles/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referrerRole = await _context.ReferrerRole.FindAsync(id);
            if (referrerRole == null)
            {
                return NotFound();
            }
            return View(referrerRole);
        }

        // POST: ReferrerRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("RoleId,RoleName")] ReferrerRole referrerRole)
        {
            if (id != referrerRole.RoleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(referrerRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferrerRoleExists(referrerRole.RoleId))
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
            return View(referrerRole);
        }

        // GET: ReferrerRoles/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referrerRole = await _context.ReferrerRole
                .FirstOrDefaultAsync(m => m.RoleId == id);
            if (referrerRole == null)
            {
                return NotFound();
            }

            return View(referrerRole);
        }

        // POST: ReferrerRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var referrerRole = await _context.ReferrerRole.FindAsync(id);
            _context.ReferrerRole.Remove(referrerRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReferrerRoleExists(byte id)
        {
            return _context.ReferrerRole.Any(e => e.RoleId == id);
        }
    }
}
