using BelediyeUlasimProjesi.Data;
using BelediyeUlasimProjesi.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BelediyeUlasimProjesi.Controllers
{

    public class BusController : Controller
    {
        public readonly BelediyeUlasimProjesiDbContext _context;
        public BusController(BelediyeUlasimProjesiDbContext context)
        {
            _context = context;
        }

        //Otobüsleri Listeleyecek
        public IActionResult List()
        {
            List<Bus> model = _context.Buses.ToList();
            return View(model);
        }
        //Yeni Otobüs Oluşturma Penceresi
        public IActionResult CreateBus()
        {
            ViewBag.TeamDDL = _context.Stations.ToList().Select(u => new SelectListItem
            {
                Selected = false,
                Text = u.StationName,
                Value = u.StationName.ToString()
            }).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBus(Bus model)
        {
            
            
            if (ModelState.IsValid)
            {
                Station station = _context.Stations.Where(x => x.StationName == model.StationName).First();
                model.StationId = station.Id;
                _context.Buses.Add(model);
                _context.SaveChanges();
                return RedirectToAction("List");
            }

            return View(model);
        }
        //Otobüs Detayları
        public IActionResult Details(int id)
        {
            var model = _context.Buses.Find(id);
            ViewBag.Stops = _context.Stations.ToList().Select(u => new SelectListItem
            {
                Selected = false,
                Text = "Ara Duraklar",
                Value = (u.Durak1, u.Durak2, u.Durak3, u.Durak4, u.Durak5, u.Durak6, u.Durak7, u.Durak8, 
                u.Durak9, u.Durak10, u.Durak11, u.Durak12, u.Durak13, u.Durak14, u.Durak15).ToString()
            });
            return View(model);
        }

        //Otobüs Düzenleme
        public IActionResult Edit(int id)
        {
            Bus model = _context.Buses.Find(id);
            ViewBag.TeamsDDL = _context.Stations.ToList().Select(u => new SelectListItem
            {
                Selected = false,
                Text = u.StationName,
                Value = u.StationName.ToString()
            }).ToList();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Bus model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    Bus willUpdate = _context.Buses.Find(model.Id);
                    willUpdate.BusName = model.BusName;
                    willUpdate.StationName = model.StationName;
                    willUpdate.CreatedDate = DateTime.UtcNow;
                    _context.SaveChanges();
                    return RedirectToAction("List");
                }
                catch (DBConcurrencyException ex)
                {
                    if (_context.Buses.Find(id) == null)
                    {
                        return NotFound();
                    }
                    throw (ex);
                }
            }
            return View();
        }
        //Otobüs Silme İşlemleri
        public IActionResult Delete(int id)
        {
            Bus model = _context.Buses.Find(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public IActionResult Delete(int id, Bus model)
        {
            if (_context.Buses.Find(model.Id) == null || id != model.Id)
            {
                return NotFound();
            }
            try
            {
                Bus bus = _context.Buses.Find(id);
                _context.Buses.Remove(bus);
                _context.SaveChanges();
                return RedirectToAction("List");
            }
            catch (DBConcurrencyException ex)
            {
                throw (ex);
            }
        }
    }
}