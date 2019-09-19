using BelediyeUlasimProjesi.Data;
using BelediyeUlasimProjesi.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BelediyeUlasimProjesi.Controllers
{
    public class StationController : Controller
    {
        private readonly BelediyeUlasimProjesiDbContext _context;
        public StationController(BelediyeUlasimProjesiDbContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            List<Station> list = _context.Stations.ToList();
            return View(list);
        }
        public IActionResult CreateStation()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStation(Station model)
        {
            if (ModelState.IsValid)
            {
                _context.Stations.Add(model);
                _context.SaveChanges();
                return RedirectToAction("List");
            }
            return View(model);
        }
        public IActionResult Details(int id,Station station)
        {
            Station model = _context.Stations.Where(x => x.Id == id).Include(x => x.Buses).FirstOrDefault();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            Station station = _context.Stations.Find(id);
            ViewBag.TeamDDL = _context.Stations.ToList().Select(u => new SelectListItem
            {
                Selected = false,
                Text = u.StationName,
                Value = u.StationName.ToString()
            });
            return View(station);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Station station)
        {
            if (id != station.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    Station willUpdate = _context.Stations.Find(station.Id);
                    willUpdate.StationName = station.StationName;
                    _context.SaveChanges();
                    return RedirectToAction("List");
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    if (_context.Stations.Find(id) == null)
                    {
                        return NotFound();
                    }
                    throw (ex);
                }
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            Station station = _context.Stations.Find(id);
            return View(station);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id,Station station)
        {
            if (id != station.Id)
            {
                return NotFound();
            }
            try
            {
                if (_context.Buses.Where(x => x.StationName == station.StationName).Any())
                {
                    return NotFound();
                }
                _context.Stations.Remove(station);
                _context.SaveChanges();
                return RedirectToAction("List");
            }
            catch(DbUpdateConcurrencyException ex)
            {
                throw (ex);
            }
        }
        public IActionResult TimeList(int id)
        {
            Station station = _context.Stations.Find(id);
            return View(station);
            
        }
    }
}