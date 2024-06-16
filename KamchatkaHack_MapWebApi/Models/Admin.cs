namespace KamchatkaHack_MapWebApi.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }//Хранить нужно закодированный пароль
        public string Role { get; set; }
    }
}
