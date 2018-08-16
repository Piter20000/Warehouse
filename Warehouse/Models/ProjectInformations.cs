using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Warehouse.Models
{
    public class ProjectInformations
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Project Name field is required")]
        [Display(Name = "Project Name")]
        [StringLength(300)]
        public string Name { get; set; }
    }
}