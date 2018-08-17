using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Warehouse.Dtos;
using Warehouse.Models;

namespace Warehouse.Controllers.Api
{
    public class ProjectElementsController : ApiController
    {
        private ApplicationDbContext _context;

        public ProjectElementsController()
        {
            _context = new ApplicationDbContext();
        }

        #region Api Controllers

        // GET: /Api/ProjectElements
        public IHttpActionResult GetProjectElements(string query = null)
        {
            var steelProfilesQuery = _context.SteelProfiles
                .Include(x => x.ProfileDetails)
                .Include(x => x.ProjectInformations)
                .Include(x => x.Status);

                var steelProfilestDto = steelProfilesQuery.ToList().Where(x=>x.ProjectInformations.Name.Equals(query)).Select(Mapper.Map<SteelProfile, SteelProfileDto>);

                return Ok(steelProfilestDto);
        }
        
        #endregion
    }
}
