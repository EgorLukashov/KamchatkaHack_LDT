using KamchatkaHack_MapWebApi.Data;
using KamchatkaHack_MapWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
//
using System.Security.Cryptography;
using System.Text;

namespace KamchatkaHack_MapWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RouteController : Controller
    {

        private readonly ApplicationDbContext _db;
        public RouteController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("api/route/{id}")]
        public IActionResult GetById(int id)
        {
            var route = _db.route.Find(id);

            if (route == null)
            {
                return NotFound($"Route with ID {id} not found.");
            }

            return Ok(route);
        }

        [HttpGet("api/routes")]
        public IActionResult GetAllRoutes()
        {
            var routes = _db.route.ToList();
            if (routes == null)
            {
                return NotFound($"No route was found.");
            }

            return Ok(routes);
        }

        [HttpGet("api/routes/park{parkId}")]
        public IActionResult GetByParkId(int parkId)
        {
            var routes = _db.route.Where(r => r.ParkID == parkId).ToList();

            if (!routes.Any())
            {
                return NotFound($"No routes found for ParkID {parkId}.");
            }

            return Ok(routes);
        }

        [HttpPost]
        public IActionResult Add(Models.Route newRoute)
        {
            _db.route.Add(newRoute);
            _db.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = newRoute.IDRoute }, newRoute);
        }



    }
}
