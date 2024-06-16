namespace KamchatkaHack_MapWebApi.Models
{
    public class LoginResponse
    {
        public Route Admin { get; set; }
        public string Token { get; set; }
        public string ErrorMessage { get; set; }
    }
}
