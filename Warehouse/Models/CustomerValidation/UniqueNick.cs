using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Warehouse.Models.CustomerValidation
{
    public class UniqueNick : ValidationAttribute
    {
        private ApplicationDbContext _context;

        public UniqueNick()
        {
            _context = new ApplicationDbContext();
        }
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Get the object
            var username = value as string;

            // Check if exists
            var user = _context.Users.SingleOrDefault(x => x.Nick == value);

            if (user == null)
                return ValidationResult.Success;

            return new ValidationResult("Nick already exists");
        }
    }
}