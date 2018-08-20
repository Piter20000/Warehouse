using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models;
using Warehouse.ViewModels;

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

        // GET: Profiles/New
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
            steelProfileInDb.Quantity = steelProfile.Quantity;
            steelProfileInDb.ModifiedByUser = User.Identity.Name;
            steelProfileInDb.ModifiedDate = DateTime.Now;
            steelProfileInDb.ProfileDetailsId = steelProfile.ProfileDetailsId;
            steelProfileInDb.ProjectInformationsId = steelProfile.ProjectInformationsId;
            steelProfileInDb.StatusId = steelProfile.StatusId;
            
            _context.SaveChanges();

            return RedirectToAction("Index", "SteelProfiles");
        }

        public ActionResult Edit(int id)
        {
            // Copy from DB
            var steelProfileInDb = _context.SteelProfiles.SingleOrDefault(x => x.Id == id);

            if (steelProfileInDb == null)
                return HttpNotFound();

            // Create ProfileDetails list
            var profileDetailsesList = _context.ProfileDetails.ToList();

            profileDetailsesList.Insert(0,steelProfileInDb.ProfileDetails);

            // Create ProjectsInformations list
            var projectInformationsList = _context.ProjectInformations.ToList();

            projectInformationsList.Insert(0,steelProfileInDb.ProjectInformations);

            // Create Status list
            var statusList = _context.Status.ToList();

            statusList.Insert(0,steelProfileInDb.Status);

            // Initial View Model
            var steelProfileEditViewModel = new SteelProfileEditViewModel()
            {
                SteelProfile = steelProfileInDb,
                ProfileDetailses = profileDetailsesList,
                ProjectInformationses = projectInformationsList,
                Statuses = statusList
            };

            return View(steelProfileEditViewModel);
        }

        #endregion

    }
}