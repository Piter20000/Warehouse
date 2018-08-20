using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Warehouse.Models
{
    public class SteelProfile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1,1000)]
        [Display(Name = "Profile's Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Length field is required - value in [mm].")]
        [Range(1,30000, ErrorMessage = "Scope 1 - 30000 [mm].")]
        [Display(Name = "Profile's Length")]
        public float Length { get; set; }

        [StringLength(100)]
        public string CreatedByUser { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string OccupiedByUser { get; set; }

        public DateTime? OccupiedDate { get; set; }

        [StringLength(100)]
        public string ModifiedByUser { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public ProfileDetails ProfileDetails { get; set; }

        [Required]
        [Display(Name = "Profile Details")]
        public int ProfileDetailsId { get; set; }

        public ProjectInformations ProjectInformations { get; set; }

        [Required]
        [Display(Name = "Project Informations")]
        public int ProjectInformationsId { get; set; }

        public Status Status { get; set; }

        [Required]
        [Display(Name = "Status")]
        public int StatusId { get; set; }
    }
}