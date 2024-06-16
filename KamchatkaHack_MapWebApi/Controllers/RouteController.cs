//using KamchatkaHack_MapWebApi.Data;
//using KamchatkaHack_MapWebApi.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.IdentityModel.Tokens;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
////
//using System.Security.Cryptography;
//using System.Text;

//namespace KamchatkaHack_MapWebApi.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class RouteController : Controller
//    {
        
//        private readonly ApplicationDbContext _db;
//        public RouteController(ApplicationDbContext db)
//        {
//            _db = db;
//        }

//        [HttpGet("api/admins")]
//        public IActionResult Get()
//        {
//            IEnumerable<Admin> admins = _db.admins.ToList();

//            return Ok(admins);
//        }

//        //[HttpPost("login")]
//        //public IActionResult Login([FromBody] LoginRequest loginRequest)
//        //{
//        //    if (loginRequest == null || string.IsNullOrEmpty(loginRequest.UserName) || string.IsNullOrEmpty(loginRequest.Password))
//        //    {
//        //        return BadRequest("Invalid client request");
//        //    }

//        //    // Хэшируем введенный пароль для сравнения с хранимым хэшированным паролем
//        //    //var hashedPassword = ComputeSha256Hash(loginRequest.Password);

//        //    // Ищем администратора с заданными учетными данными
//        //    var admin = _db.admins
//        //        .Where(a => a.Name == loginRequest.UserName && a.Password == loginRequest.Password)
//        //        .FirstOrDefault();

//        //    if (admin != null)
//        //    {
//        //        // Создаем и возвращаем токен
//        //        var token = "exampleToken"; // Здесь должна быть логика генерации токена
//        //        return Ok(new LoginResponse
//        //        {
//        //            Admin = admin,
//        //            Token = token
//        //        });
//        //    }

//        //    return Unauthorized(new
//        //    {
//        //        //Success = false,
//        //        ErrorMessage = "Invalid username or password"
//        //    });
//        //}


        
//        //[HttpPatch("api/admin/{id}/{name}")]
//        //public async Task<IActionResult> Update(int id, string name)
//        //{
//        //    // Assuming you have a model named Flowers with properties Name, Price, and Profit
//        //    Admin admins = _db.admins.Find(id);
//        //    admins.Name = name;
//        //    _db.SaveChanges();

//        //    return Ok(admins);
//        //}
//    }
//}
