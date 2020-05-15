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
    public class MatiereProfController : Controller
    {
        
         private readonly ApplicationDbContext _context;

         public MatiereProfController(ApplicationDbContext context)
        {
           _context= context;
        }

        public  async Task<IActionResult> Index ()
        {
            return View(await _context.MatiereProf.ToListAsync());
        }

        
        public IActionResult AddandEdit(int id = 0)
        {
            if (id == 0)
                return View(new MatiereProf());
            else
                return View(_context.MatiereProf.Find(id));
        }

        /////

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddandEdit([Bind("Id,Nom")] MatiereProf matiereProf)
        {
            if (ModelState.IsValid)
            {
                if (matiereProf.Id == 0)
                    _context.Add(matiereProf);
                else
                    _context.Update(matiereProf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matiereProf);
        }


        //////

        public async Task<IActionResult> Delete(int? id)
        {
            var matiereProf =await _context.MatiereProf.FindAsync(id);
            _context.MatiereProf.Remove(matiereProf);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }











    }
}