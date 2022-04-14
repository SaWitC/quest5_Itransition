using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyVkQuest5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MyVkQuest5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using MyVkQuest5.hubs;

namespace MyVkQuest5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IHubContext<ChatHub> hubContext;

        //private readonly Fake_VK_DbContext _context;
        //private readonly UserManager<User> _userManager;

        public HomeController(ILogger<HomeController> logger/*,IHubContext<ChatHub> hubContext*//*, UserManager<User> userManager, Fake_VK_DbContext context*/)
        {
            _logger = logger;
            //this.hubContext = hubContext;

            //_userManager = userManager;
            //_context = context;
        }

        public async Task<IActionResult> Index()
        {
            //var currentUser = await _userManager.GetUserAsync(User);
            //ViewBag.CurrentName = currentUser.UserName;
            //var messages = _context.Messages.ToListAsync();
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
