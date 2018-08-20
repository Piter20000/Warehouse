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
    public class ProfileDetailsController : ApiController
    {
        private ApplicationDbContext _context;

        public ProfileDetailsController()
        {
            _context = new ApplicationDbContext();
        }

        #region Api Controllers

        // GET: /Api/ProfileDetails
        public IHttpActionResult GetProfileDetails(string query = null)
        {
            var profileDetailsQuery = _context.ProfileDetails;

            if (!string.IsNullOrWhiteSpace(query))
            {
                var profileDetailsDto = profileDetailsQuery.ToList().Where(x => x.Name.Contains(query)).Select(Mapper.Map<ProfileDetails, ProfileDetailsDto>);
                return Ok(profileDetailsDto);
            }
            else
            {
                var profileDetailsDto = profileDetailsQuery.ToList().Select(Mapper.Map<ProfileDetails, ProfileDetailsDto>);
                return Ok(profileDetailsDto);
            }
        }

        // DELETE /Api/ProfileDetails/1
        [HttpDelete]
        public IHttpActionResult DeleteProfileDetails(int id)
        {
            var profileDetailsInDb = _context.ProfileDetails.SingleOrDefault(c => c.Id == id);
            var steelProdilesInDB = _context.SteelProfiles.Where(x => x.ProfileDetailsId == id).ToList();

            if (profileDetailsInDb == null)
                return NotFound();

            // Remove Profile Detail
            _context.ProfileDetails.Remove(profileDetailsInDb);

            // Remove all Steel Profiles of the Profile Detail
            foreach (var steelProfile in steelProdilesInDB)
            {
                _context.SteelProfiles.Remove(steelProfile);
            }

            _context.SaveChanges();

            return Ok();
        }

        #endregion
    }
}
