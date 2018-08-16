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

        public ProfileDetails ProfileDetails { get; set; }

        [Required]
        public int ProfileDetailsId { get; set; }

        public ProjectInformations ProjectInformations { get; set; }

        [Required]
        public int ProjectInformationsId { get; set; }

        public Status Status { get; set; }

        [Required]
        public int StatusId { get; set; }

        public ProfileHistory ProfileHistory { get; set; }

        public int ProfileHistoryId { get; set; }

    }
}