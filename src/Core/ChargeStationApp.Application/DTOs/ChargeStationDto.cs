using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargeStationApp.Application.DTOs
{
    public class ChargeStationDto
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Provider { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public int TotalPorts { get; set; }
    public int AvailablePorts { get; set; }
    public string StationType { get; set; }
    public decimal AcPrice { get; set; }
    public decimal DcPrice { get; set; }
    public string ExternalAppUrl { get; set; }
    }
}