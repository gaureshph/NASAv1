using System;
using System.Collections.Generic;

namespace NASAv1.Web.ViewModels
{
    public class RocketViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LaunchDate { get; set; }
        public IEnumerable<SatelliteViewModel> Satellites { get; set; }
    }
}
