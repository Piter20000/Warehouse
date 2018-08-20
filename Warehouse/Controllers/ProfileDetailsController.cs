using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models;

namespace Warehouse.Controllers
{
    public class ProfileDetailsController : Controller
    {
        private ApplicationDbContext _context;

        public ProfileDetailsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        #region Controllers

        // GET: ProfileDetails
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProfileDetails/New
        public ActionResult New()
        {
            return View();
        }

        // PUT: ProfileDetails
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveNew(ProfileDetails profileDetails)
        {
            if (!ModelState.IsValid)
                return View("New");

            _context.ProfileDetails.Add(profileDetails);

            _context.SaveChanges();

            return RedirectToAction("Index", "ProfileDetails");
        }

        #endregion
    }
}