using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JmmTest.Models;

namespace JmmTest.Controllers
{
    public class TestController : Controller
    {
        private readonly DbContex _context;

        public TestController(DbContex context)
        {
            _context = context;
        }

        // GET: Test
        public async Task<IActionResult> Index()
        {
            return View(await _context.JmmTest.ToListAsync());
        }

        // GET: Test/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jmm = await _context.JmmTest
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jmm == null)
            {
                return NotFound();
            }

            return View(jmm);
        }

        // GET: Test/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,MobileNumber,title,description,Gduedate,priority,Status")] Jmm jmm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jmm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jmm);
        }

        // GET: Test/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jmm = await _context.JmmTest.FindAsync(id);
            if (jmm == null)
            {
                return NotFound();
            }
            return View(jmm);
        }

        // POST: Test/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,MobileNumber,title,description,Gduedate,priority,Status")] Jmm jmm)
        {
            if (id != jmm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jmm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JmmExists(jmm.Id))
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
            return View(jmm);
        }

        // GET: Test/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jmm = await _context.JmmTest
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jmm == null)
            {
                return NotFound();
            }

            return View(jmm);
        }

        // POST: Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jmm = await _context.JmmTest.FindAsync(id);
            if (jmm != null)
            {
                _context.JmmTest.Remove(jmm);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JmmExists(int id)
        {
            return _context.JmmTest.Any(e => e.Id == id);
        }
    }
}
