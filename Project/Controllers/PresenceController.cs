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
    public class PresenceController : Controller
    {
        private readonly ApplicationDbContext _context;

        
        public PresenceController(ApplicationDbContext context)
        {
           _context= context;
        }


        public  async Task<IActionResult> Index ()
        {
            return View(await _context.Presence.ToListAsync());
        }

        // get 
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Presence());
            else
                return View(_context.Presence.Find(id));
        }

        // post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("id,Nomet,prenomet,idseance")] Presence presence)
        {
            if (ModelState.IsValid)
            {
                if (presence.id == 0)
                    _context.Add(presence);
                else
                    _context.Update(presence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(presence);
        }


        // GET: 
        public async Task<IActionResult> Delete(int? id)
        {
            var presence =await _context.Presence.FindAsync(id);
            _context.Presence.Remove(presence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
