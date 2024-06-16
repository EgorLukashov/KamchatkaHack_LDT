namespace KamchatkaHack_MapWebApi.Models
{
    public class Park
    {
        public int Id { get; set; }
        public string RouteName { get; set; }
        public int ActualCapacity { get; set; }
        public int MaxCapacity { get; set; }
        public string? TouristList { get; set; }

    }
}
