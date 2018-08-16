using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models;

namespace Warehouse.Controllers
{
    public class SteelProfilesController : Controller
    {
        private ApplicationDbContext _context;

        public SteelProfilesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        #region Controllers

        // GET: SteelProfiles
        public ActionResult Index()
        {
            return View();
        }

        // PUT: SteelProfiles
        public ActionResult SaveNew(SteelProfile steelProfile)
        {
            if (!ModelState.IsValid)
                return View("New");

            _context.SteelProfiles.Add(steelProfile);

            _context.SaveChanges();

            return RedirectToAction("Index", "SteelProfiles");
        }

        // PUT: SteelProfiles
        public ActionResult SaveEdited(SteelProfile steelProfile)
        {
            var steelProfileInDb = _context.SteelProfiles.Single(x => x.Id == steelProfile.Id);

            steelProfileInDb.Length = steelProfile.Length;
            steelProfileInDb.ProfileDetailsId = steelProfile.ProfileDetailsId;
            steelProfileInDb.ProjectInformations = steelProfile.ProjectInformations;
            steelProfileInDb.StatusId = steelProfile.StatusId;
            steelProfileInDb.Quantity = steelProfile.Quantity;
            steelProfileInDb.ModifiedByUser = steelProfile.ModifiedByUser;
            steelProfileInDb.ModifiedDate = steelProfile.ModifiedDate;
            steelProfileInDb.OccupiedByUser = steelProfile.OccupiedByUser;
            steelProfileInDb.OccupiedDate = steelProfile.OccupiedDate;
            
            _context.SaveChanges();

            return RedirectToAction("Index", "SteelProfiles");
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            var projectInDb = _context.SteelProfiles.SingleOrDefault(x => x.Id == id);

            if (projectInDb == null)
                return HttpNotFound();

            return View(projectInDb);
        }

        #endregion

    }
}