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
    public class MatiereController : Controller
    {
        
         private readonly ApplicationDbContext _context;

         public MatiereController(ApplicationDbContext context)
        {
           _context= context;
        }

        public  async Task<IActionResult> Index1 ()
        {
            return View(await _context.Matiere.ToListAsync());
        }

        /////
         public IActionResult AddandEdit(int id = 0)
        {
            if (id == 0)
                return View(new Matiere());
            else
                return View(_context.Matiere.Find(id));
        }

        /////

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddandEdit([Bind("Id,Nom")] Matiere matiere)
        {
            if (ModelState.IsValid)
            {
                if (matiere.Id == 0)
                    _context.Add(matiere);
                else
                    _context.Update(matiere);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index1));
            }
            return View(matiere);
        }


        //////

        public async Task<IActionResult> Delete(int? id)
        {
            var matiere =await _context.Matiere.FindAsync(id);
            _context.Matiere.Remove(matiere);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index1));
        }











    }
}