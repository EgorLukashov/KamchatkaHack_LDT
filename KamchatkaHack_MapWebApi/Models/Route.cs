using System.ComponentModel.DataAnnotations.Schema;

namespace KamchatkaHack_MapWebApi.Models
{
    public class Route
    {
        public int IDRoute { get; set; }
        public string RouteName { get; set; }
        public Park Park { get; set; }
        public int ParkID { get; set; }
        public int ActualCapacityObj { get; set; }
        public string? GpxFile { get; set; }
        public int MaxCapacityObj { get; set; }
        public string? touristList { get; set; }
    }
}
