﻿using System;
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
    public class ProjectsController : ApiController
    {
        private ApplicationDbContext _context;

        public ProjectsController()
        {
            _context = new ApplicationDbContext();
        }

        #region Api Controllers

        // GET: /Api/Projects
        public IHttpActionResult GetProjects(string query = null)
        {
            var projectsQuery = _context.ProjectInformations;

            if (!string.IsNullOrWhiteSpace(query)) { 
                var projectsDto = projectsQuery.ToList().Where(x => x.Name.Contains(query)).Select(Mapper.Map<ProjectInformations, ProjectInformationsDto>);
                return Ok(projectsDto);
            }
            else
            {
                var projectsDto = projectsQuery.ToList().Select(Mapper.Map<ProjectInformations, ProjectInformationsDto>);
                return Ok(projectsDto);
            }
        }

        // DELETE /Api/Projects/1
        [HttpDelete]
        public IHttpActionResult DeleteProjects(int id)
        {
            var projectInDb = _context.ProjectInformations.SingleOrDefault(c => c.Id == id);

            if (projectInDb == null)
                return NotFound();

            _context.ProjectInformations.Remove(projectInDb);
            _context.SaveChanges();

            return Ok();
        }

        #endregion
    }
}