using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Warehouse.Models
{
    public class ProfileDetails
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Profile Name file is required")]
        [StringLength(100)]
        [Display(Name = "Profile Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Weigth file is required")]
        [Display(Name = "Weigth kg/m")]
        public decimal Weigth { get; set; }
    }
}