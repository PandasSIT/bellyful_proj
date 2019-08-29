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
    public class MealTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MealTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MealTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MealType.ToListAsync());
        }

        // GET: MealTypes/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealType = await _context.MealType
                .FirstOrDefaultAsync(m => m.MealTypeId == id);
            if (mealType == null)
            {
                return NotFound();
            }

            return View(mealType);
        }

        // GET: MealTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MealTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MealTypeId,MealTypeName,ShelfLocation")] MealType mealType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mealType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mealType);
        }

        // GET: MealTypes/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealType = await _context.MealType.FindAsync(id);
            if (mealType == null)
            {
                return NotFound();
            }
            return View(mealType);
        }

        // POST: MealTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("MealTypeId,MealTypeName,ShelfLocation")] MealType mealType)
        {
            if (id != mealType.MealTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mealType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MealTypeExists(mealType.MealTypeId))
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
            return View(mealType);
        }

        // GET: MealTypes/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealType = await _context.MealType
                .FirstOrDefaultAsync(m => m.MealTypeId == id);
            if (mealType == null)
            {
                return NotFound();
            }

            return View(mealType);
        }

        // POST: MealTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var mealType = await _context.MealType.FindAsync(id);
            _context.MealType.Remove(mealType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MealTypeExists(byte id)
        {
            return _context.MealType.Any(e => e.MealTypeId == id);
        }
    }
}
