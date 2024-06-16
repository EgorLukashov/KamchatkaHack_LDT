namespace KamchatkaHack_MapWebApi.Models
{
    public class Park
    {
        public int IDPark { get; set; }
        public string ParkName { get; set; }
        public int MaxCapacity { get; set; }
        public int ActualCapacity { get; set; }
        public string TouristList { get; set; }
    }
}
