namespace KamchatkaHack_MapWebApi.Models
{
    public class Admin
    {
        public int IDAdmin { get; set; }
        public string AdminLogin { get; set; }
        public string AdminName { get; set; }
        public string AdminSurname { get; set; }
        public string? AdminMiddleName { get; set; }
        public string AdminHashedPassword { get; set; }//Хранить нужно закодированный пароль
        public string AdminRole { get; set; }
        public string AdminEmail { get; set; }
    }
}
