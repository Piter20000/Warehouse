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

        // GET: Profiles/Create
        public ActionResult New()
        {
            ViewBag.ProfileDetailsId = new SelectList(_context.ProfileDetails, "Id", "Name");
            ViewBag.ProjectInformationsId = new SelectList(_context.ProjectInformations, "Id", "Name");
            ViewBag.StatusId = new SelectList(_context.Status, "Id", "Name");

            return View();
        }

        // PUT: SteelProfiles
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveNew(SteelProfile steelProfile)
        {
            if (!ModelState.IsValid)
                return View("New");

            steelProfile.CreatedByUser = User.Identity.Name;
            steelProfile.CreatedDate = DateTime.Now;
            _context.SteelProfiles.Add(steelProfile);

            _context.SaveChanges();

            return RedirectToAction("Index", "SteelProfiles");
        }

        // PUT: SteelProfiles
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveEdited(SteelProfile steelProfile)
        {
            var steelProfileInDb = _context.SteelProfiles.Single(x => x.Id == steelProfile.Id);

            steelProfileInDb.Length = steelProfile.Length;
            steelProfileInDb.ProfileDetailsId = steelProfile.ProfileDetailsId;
            steelProfileInDb.ProjectInformations = steelProfile.ProjectInformations;
            steelProfileInDb.StatusId = steelProfile.StatusId;
            steelProfileInDb.Quantity = steelProfile.Quantity;
            steelProfileInDb.ModifiedByUser = User.Identity.Name;
            steelProfileInDb.ModifiedDate = DateTime.Now;
            
            _context.SaveChanges();

            return RedirectToAction("Index", "SteelProfiles");
        }

        public ActionResult Edit(int id)
        {
            var projectInDb = _context.SteelProfiles.SingleOrDefault(x => x.Id == id);

            if (projectInDb == null)
                return HttpNotFound();

            ViewBag.ProfileDetailsId = new SelectList(_context.ProfileDetails, "Id", "Name");
            ViewBag.ProjectInformationsId = new SelectList(_context.ProjectInformations, "Id", "Name");
            ViewBag.StatusId = new SelectList(_context.Status, "Id", "Name");

            return View(projectInDb);
        }

        #endregion

    }
}