using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDAC_project.Models
{
    public class Vessel
    {
        public string vesselName { get; set; }
        public string containers { get; set; }
        public string destinationYard { get; set; }
        public string arrivalYard { get; set; }
    }
}