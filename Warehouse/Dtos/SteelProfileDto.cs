using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.Dtos
{
    public class SteelProfileDto
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 1000)]
        public int Quantity { get; set; }

        [Required]
        [Range(1, 30000)]
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

        public ProfileDetailsDto ProfileDetails { get; set; }

        [Required]
        public int ProfileDetailsId { get; set; }

        public ProjectInformationsDto ProjectInformations { get; set; }

        [Required]
        public int ProjectInformationsId { get; set; }

        public StatusDto Status { get; set; }

        [Required]
        public int StatusId { get; set; }
    }
}