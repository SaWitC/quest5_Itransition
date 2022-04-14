using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyVkQuest5.Data;
using MyVkQuest5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyVkQuest5.ViewModel;
using Microsoft.AspNetCore.SignalR;
using MyVkQuest5.hubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;

namespace MyVkQuest5.Controllers
{
    public class MessageController : Controller
    {
        private readonly MyVkDBContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IHubContext<ChatHub> hubContext;

        public MessageController(UserManager<User> userManager, MyVkDBContext context, IHubContext<ChatHub> hubContext)
        {
            _userManager = userManager;
            _context = context;
            this.hubContext = hubContext;
        }
        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            //var currentUser = await _userManager.GetUserAsync(User);
            //ViewBag.CurrentName = currentUser.UserName;
            //var messages = _context.Messages.ToListAsync();
            return View(await _context.Messages.ToListAsync());
        }

        // GET: MessageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MessageController/Create
        [Authorize]
        [HttpGet]

        public IActionResult Create()
        {
            
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetMessages()
        {
            var res = await _context.Messages.ToListAsync();
            return Ok(res);
        }

        // POST: MessageController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string message,int ChatId,string userId)
        {
            if (ModelState.IsValid)
            {
                var messageModel = new MessageModel();

                var Chat = await _context.Chats.FirstOrDefaultAsync(o=>o.Id== ChatId);
                messageModel.Chat = Chat;
                messageModel.SentDate = DateTime.Now;
                messageModel.Message = message;
                messageModel.FromUser = User.Identity.Name;

                _context.Messages.Add(messageModel);
                await _context.SaveChangesAsync();

                //var response ="< a href = "#" class="btn btn-info btn-lg active" role="button" aria-pressed="true">@item.Message</a>
                //var htmlrsponse = new HtmlString($"< a class=\"btn btn-info btn-lg active\" role=\"button\" aria-pressed=\"true\">{messageModel.Message}</a>");
                await hubContext.Clients.User(userId).SendAsync("Notify", messageModel.Message);

                return RedirectToAction("GoToChat","chat",new{ id = ChatId});
            }
            return RedirectToAction("Index","Home");
        }

        // GET: MessageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MessageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MessageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
