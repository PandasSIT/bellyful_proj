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
    public class ReferralReasonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReferralReasonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReferralReasons
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReferralReason.ToListAsync());
        }

        // GET: ReferralReasons/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referralReason = await _context.ReferralReason
                .FirstOrDefaultAsync(m => m.ReferralReasonId == id);
            if (referralReason == null)
            {
                return NotFound();
            }

            return View(referralReason);
        }

        // GET: ReferralReasons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReferralReasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReferralReasonId,Content")] ReferralReason referralReason)
        {
            if (ModelState.IsValid)
            {
                _context.Add(referralReason);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(referralReason);
        }

        // GET: ReferralReasons/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referralReason = await _context.ReferralReason.FindAsync(id);
            if (referralReason == null)
            {
                return NotFound();
            }
            return View(referralReason);
        }

        // POST: ReferralReasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("ReferralReasonId,Content")] ReferralReason referralReason)
        {
            if (id != referralReason.ReferralReasonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(referralReason);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferralReasonExists(referralReason.ReferralReasonId))
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
            return View(referralReason);
        }

        // GET: ReferralReasons/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referralReason = await _context.ReferralReason
                .FirstOrDefaultAsync(m => m.ReferralReasonId == id);
            if (referralReason == null)
            {
                return NotFound();
            }

            return View(referralReason);
        }

        // POST: ReferralReasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var referralReason = await _context.ReferralReason.FindAsync(id);
            _context.ReferralReason.Remove(referralReason);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReferralReasonExists(byte id)
        {
            return _context.ReferralReason.Any(e => e.ReferralReasonId == id);
        }
    }
}
