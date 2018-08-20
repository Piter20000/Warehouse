using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.ViewModels
{
    public class SteelProfileEditViewModel
    {
        public SteelProfile SteelProfile { get; set; }
        public IEnumerable<ProfileDetails> ProfileDetailses { get; set; }
        public IEnumerable<ProjectInformations> ProjectInformationses { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}