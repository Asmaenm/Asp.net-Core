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
    public class SeanceController : Controller
    {
        
         private readonly ApplicationDbContext _context;

         public SeanceController(ApplicationDbContext context)
        {
           _context= context;
        }

        public  async Task<IActionResult> Index ()
        {
            return View(await _context.Seance.ToListAsync());
        }

         public IActionResult AddandEdit(int id = 0)
        {
            if (id == 0)
                return View(new Seance());
            else
                return View(_context.Seance.Find(id));
        }

        /////

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddandEdit([Bind("Id,nomSeance")] Seance seance)
        {
            if (ModelState.IsValid)
            {
                if (seance.Id == 0)
                    _context.Add(seance);
                else
                    _context.Update(seance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seance);
        }


        //////

        public async Task<IActionResult> Delete(int? id)
        {
            var seance =await _context.Seance.FindAsync(id);
            _context.Seance.Remove(seance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        










    }
}