using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoSlide4.Models;
using DemoSlide4.Iservice;

namespace DemoSlide4.Controllers
{
    public class EmployessesController : Controller
    {
        private IserviceEmployess _iserviceEmployess;
        //private readonly Logger<EmployessesController> logger;

        public EmployessesController(IserviceEmployess iserviceEmployess)
        {
            this._iserviceEmployess = iserviceEmployess;
            //this.logger = logger;
        }

        // GET: Employesses
        public async Task<IActionResult> Index()
        { 
              var ltsEmp = _iserviceEmployess.GetallEmp().ToList();
              return  View(ltsEmp) ;
        }

        // GET: Employesses/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Students == null)
        //    {
        //        return NotFound();
        //    }

        //    var employess = await _context.Students
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (employess == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(employess);
        //}

        //// GET: Employesses/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Employesses/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,NameEmp,Bithdate,SDT")] Employess employess)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(employess);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(employess);
        //}

        //// GET: Employesses/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Students == null)
        //    {
        //        return NotFound();
        //    }

        //    var employess = await _context.Students.FindAsync(id);
        //    if (employess == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(employess);
        //}

        //// POST: Employesses/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,NameEmp,Bithdate,SDT")] Employess employess)
        //{
        //    if (id != employess.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(employess);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!EmployessExists(employess.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(employess);
        //}

        //// GET: Employesses/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Students == null)
        //    {
        //        return NotFound();
        //    }

        //    var employess = await _context.Students
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (employess == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(employess);
        //}

        //// POST: Employesses/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Students == null)
        //    {
        //        return Problem("Entity set 'AppDbContext.Students'  is null.");
        //    }
        //    var employess = await _context.Students.FindAsync(id);
        //    if (employess != null)
        //    {
        //        _context.Students.Remove(employess);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool EmployessExists(int id)
        //{
        //  return (_context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
