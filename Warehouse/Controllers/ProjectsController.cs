using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warehouse.Models;

namespace Warehouse.Controllers
{
    public class ProjectsController : Controller
    {
        private ApplicationDbContext _context;

        public ProjectsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        #region Controllers

        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

        // GET: Profiles/New
        public ActionResult New()
        {
            return View();
        }

        // PUT: Projects
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveNew(ProjectInformations projectInformations)
        {
            if (!ModelState.IsValid)
                return View("New");

            _context.ProjectInformations.Add(projectInformations);

            _context.SaveChanges();

            return RedirectToAction("Index", "Projects");
        }

        public ActionResult Edit(int id)
        {
            var projectInDb = _context.ProjectInformations.SingleOrDefault(x => x.Id == id);

            if (projectInDb == null)
                return HttpNotFound();

            return View(projectInDb);
        }

        // PUT: SteelProfiles
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveEdited(ProjectInformations projectInformations)
        {
            var projectInformationsInDb = _context.ProjectInformations.Single(x => x.Id == projectInformations.Id);

            projectInformationsInDb.Name = projectInformations.Name;

            _context.SaveChanges();

            return RedirectToAction("Index", "Projects");
        }

        public ActionResult ProjectElements(string project)
        {
            ViewBag.Name = project;

            return View();
        } 

        #endregion
    }
}