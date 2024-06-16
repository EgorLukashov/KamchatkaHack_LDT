// Controllers/AccountController.cs
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;
using MVC_AdminPanel.Models;
using System.Security.Cryptography;
using System.Text;
using MVC_AdminPanel.Data;
namespace MVC_AdminPanel.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string adminLogin, string adminHashedPassword)
        {
            string hashedPassword = ComputeSha256Hash(adminHashedPassword);
            var admin = await _context.Admin.FirstOrDefaultAsync(a => a.AdminLogin == adminLogin && a.AdminHashedPassword == hashedPassword);

            if (admin != null)
            {
                var claims = new[]
                {
                new Claim(ClaimTypes.Name, admin.AdminLogin),
                //new Claim(ClaimTypes.Role, "Admin")
            };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Неверный логин или пароль");
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Admin admin)
        {
            if (ModelState.IsValid)
            {
                // Проверка уникальности логина
                bool loginExists = await _context.Admin.AnyAsync(a => a.AdminLogin == admin.AdminLogin);
                if (loginExists)
                {
                    ModelState.AddModelError("AdminLogin", "Логин уже используется.");
                    return View(admin);
                }

                admin.AdminHashedPassword = ComputeSha256Hash(admin.AdminHashedPassword); // Хеширование пароля

                _context.Add(admin);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }

            return View(admin);
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult Hello()
        {
            return View();
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}