using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Warehouse.Dtos;
using Warehouse.Models;

namespace Warehouse.Controllers.Api
{
    public class SteelProfilesController : ApiController
    {
        private ApplicationDbContext _context;

        public SteelProfilesController()
        {
            _context = new ApplicationDbContext();
        }

        #region Api Controllers

        // GET: api/SteelProfiles
        public IHttpActionResult GetSteelProfiles(string query = null)
        {
            
            if (!String.IsNullOrWhiteSpace(query))
            {
                var steelProfilesQuery = _context.SteelProfiles.Where(x => x.ProfileDetails.Name.Contains(query));

                var steelProfilestDto = steelProfilesQuery.ToList().Select(Mapper.Map<SteelProfile, SteelProfileDto>);

                return Ok(steelProfilestDto);
            }
            else
            {
                var steelProfilesQuery = _context.SteelProfiles.Where(x => x.ProfileDetails.Name.Contains(query));

                var steelProfilestDto = steelProfilesQuery.ToList().Select(Mapper.Map<SteelProfile, SteelProfileDto>);

                return Ok(steelProfilestDto);
            }
        }

        // DELETE /api/project/1
        [HttpDelete]
        public IHttpActionResult DeleteProject(int id)
        {
            var steelProfileInDb = _context.SteelProfiles.SingleOrDefault(c => c.Id == id);

            if (steelProfileInDb == null)
                return NotFound();

            _context.SteelProfiles.Remove(steelProfileInDb);
            _context.SaveChanges();

            return Ok();
        }

        #endregion
    }
}
