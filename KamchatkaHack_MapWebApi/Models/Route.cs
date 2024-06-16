namespace KamchatkaHack_MapWebApi.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Park ParkId { get; set; }
        public int ActualCapacityObj { get; set; }
        public string? GpxFile { get; set; }
        public int MaxCapacityObj { get; set; }
        public string? TouristList { get; set; }
        //public ICollection<Park> ParkId { get; set; }
    }
}
