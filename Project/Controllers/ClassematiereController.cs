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
    public class ClassematiereController : Controller
    {
        
     private readonly ApplicationDbContext _context;

        public ClassematiereController(ApplicationDbContext context)
        {
           _context= context;
        }
        // get classes
        public  async Task<IActionResult> Index ()
        {
            return View(await _context.Classematiere.ToListAsync());
        }
        
        public  async Task<IActionResult> Liste (int id)
        {
            return View(await _context.Etudiants.Where(a=>a.classe.id==id).ToListAsync());
        }
      ////

     

        public IActionResult AddEdit(int id = 0)
        {
            if (id == 0)
                return View(new Classematiere());
            else
                return View(_context.Classematiere.Find(id));
        }

        // post  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEdit([Bind("id,nomClasse,filiere")] Classematiere classematiere)
        {
            if (ModelState.IsValid)
            {
                if (classematiere.id == 0)
                    _context.Add(classematiere);
                else
                    _context.Update(classematiere);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(classematiere);
        }

        
       


        //
        public async Task<IActionResult> Delete(int? id)
        {
            var classematiere =await _context.Classematiere.FindAsync(id);
            _context.Classematiere.Remove(classematiere);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
