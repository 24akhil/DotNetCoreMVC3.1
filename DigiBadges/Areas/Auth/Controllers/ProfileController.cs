using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DigiBadges.Models;

namespace DigiBadges.Areas.Auth.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IDistributedCache _cache;
        public ProfileController(IDistributedCache cache)
        {
            _cache = cache;

        }
        public IActionResult Index()
        {
            _cache.SetString("q", "qqwe");
            Console.WriteLine(_cache.GetString("q"));

            var vm = new AppUser
            {
                Claims = User.Claims,
                Email = User.Identity.Name
            };
            return View(vm);
        }
    }
}