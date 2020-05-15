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
    public class EtudiantController : Controller
    {
        private readonly ApplicationDbContext _context;

        




        public EtudiantController(ApplicationDbContext context)
        {
           _context= context;
        }




        // get Etudiants
        public  async Task<IActionResult> Index ()
        {
            return View(await _context.Etudiants.ToListAsync());
        }

        // get etudiant/create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Etudiant());
            else
                return View(_context.Etudiants.Find(id));
        }

        // post  etudiant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("id,nomEt,prenomEt,tel,emailEt")] Etudiant etudiant)
        {
            if (ModelState.IsValid)
            {
                if (etudiant.id == 0)
                    _context.Add(etudiant);
                else
                    _context.Update(etudiant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(etudiant);
        }


        // GET: Etudiant/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var etudiant =await _context.Etudiants.FindAsync(id);
            _context.Etudiants.Remove(etudiant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
