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
    public class ProfesseurController : Controller
    {
        private readonly ApplicationDbContext _context;

        




        public ProfesseurController(ApplicationDbContext context)
        {
           _context= context;
        }


        public  async Task<IActionResult> Index ()
        {
            return View(await _context.Professeur.ToListAsync());
        }

        // get prof/create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Professeur());
            else
                return View(_context.Professeur.Find(id));
        }

        // post  professeur/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("id,nomProf,prenomProf,tel,emailProf")] Professeur professeur)
        {
            if (ModelState.IsValid)
            {
                if (professeur.id == 0)
                    _context.Add(professeur);
                else
                    _context.Update(professeur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(professeur);
        }


        // GET: prof/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var professeur =await _context.Professeur.FindAsync(id);
            _context.Professeur.Remove(professeur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
