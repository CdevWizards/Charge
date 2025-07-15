using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargeStationApp.Domain.Entities
{
    public class ChargeStation : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int TotalPorts { get; set; }
        public int AvailablePorts { get; set; }

        public string Provider { get; set; } = string.Empty;      // Firma
        public string StationType { get; set; } = string.Empty;   // AC / DC
        public decimal AcPrice { get; set; }
        public decimal DcPrice { get; set; }
        public string ExternalAppUrl { get; set; } = string.Empty;
    }
}