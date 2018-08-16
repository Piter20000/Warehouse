﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Warehouse.Models
{
    public class Status
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}