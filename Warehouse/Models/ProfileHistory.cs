using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Warehouse.Models
{
    public class ProfileHistory
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string CreatedByUser { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string OccupiedByUser { get; set; }

        public DateTime? OccupiedDate { get; set; }

        [StringLength(100)]
        public string ModifiedByUser { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}