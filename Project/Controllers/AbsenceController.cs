using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Project.Data;
using Project.Models;

namespace Project.Controllers
{
    public class AbsenceController : Controller
    {
        private readonly ApplicationDbContext _context;

        




        public AbsenceController(ApplicationDbContext context)
        {
           _context= context;
        }


        public  async Task<IActionResult> Index ()
        {
            return View(await _context.Absence.ToListAsync());
        }

        // get 
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Absence());
            else
                return View(_context.Absence.Find(id));
        }

        // post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("id,Nomet,prenomet,idseance")] Absence absence)
        {
            if (ModelState.IsValid)
            {
                if (absence.id == 0)
                    _context.Add(absence);
                else
                    _context.Update(absence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(absence);
        }


        // GET: 
        public async Task<IActionResult> Delete(int? id)
        {
            var absence =await _context.Absence.FindAsync(id);
            _context.Absence.Remove(absence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
