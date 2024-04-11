using EntityLayer.Concrete;
using System;

namespace TravelsalCore.Models
{
    public class ReservationModel
    {
        public AppUser AppUser { get; set; }
        public string PersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public String DestinationCity { get; set; }
        public String DestinationDayNight { get; set; }
        public double DestinationPrice { get; set; }
    }
}
