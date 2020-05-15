using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;


namespace Project.Controllers
{
    public class ClasseController : Controller
    {
        
     private readonly ApplicationDbContext _context;

        public ClasseController(ApplicationDbContext context)
        {
           _context= context;
        }
        // get classes
        public  async Task<IActionResult> Index2 ()
        {
            return View(await _context.Classe.ToListAsync());
        }
        
        public  async Task<IActionResult> Liste (int id)
        {
            return View(await _context.Etudiants.Where(a=>a.classe.id==id).ToListAsync());
        }
      ////

     

        public IActionResult AddEdit(int id = 0)
        {
            if (id == 0)
                return View(new Classe());
            else
                return View(_context.Classe.Find(id));
        }

        // post  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEdit([Bind("id,nomClasse,filiere")] Classe classe)
        {
            if (ModelState.IsValid)
            {
                if (classe.id == 0)
                    _context.Add(classe);
                else
                    _context.Update(classe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index2));
            }
            return View(classe);
        }

        
       


        //
        public async Task<IActionResult> Delete(int? id)
        {
            var classe =await _context.Classe.FindAsync(id);
            _context.Classe.Remove(classe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index2));
        }
    }
}
