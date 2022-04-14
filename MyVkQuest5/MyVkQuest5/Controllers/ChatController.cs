using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyVkQuest5.Data;
using MyVkQuest5.Models;
using MyVkQuest5.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using MyVkQuest5.hubs;
using Microsoft.AspNetCore.Authorization;

namespace MyVkQuest5.Controllers
{

    [Authorize]
    public class ChatController : Controller
    {
        private readonly IHubContext<ChatHub> _hub ;

        private readonly MyVkDBContext _context;
        private readonly UserManager<User> _userManager;

        public ChatController(MyVkDBContext context ,UserManager<User> userManager, IHubContext<ChatHub> hub)
        {
            _context = context;
            _userManager = userManager;
            _hub = hub;
        }
        
        // GET: ChatController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChatController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChatController/Create
        [HttpGet]
        public async Task<ActionResult> Create(string User2)
        {
            try
            {
                string USer1 = User.Identity.Name;
                string sss = USer1;
                var CHAT = await _context.Chats.FirstOrDefaultAsync(o => o.ChatCreater.UserName == USer1 && o.interlocutor.UserName == User2|| o.ChatCreater.UserName == User2.ToString() && o.interlocutor.UserName == USer1.ToString());
                //var CHAT2 = await _context.Chats.FirstOrDefaultAsync(o => o.ChatCreater.UserName == User2.ToString() && o.interlocutor.UserName == User1);

                if (CHAT == null)
                {
                    var us1 = await _userManager.FindByNameAsync(USer1);
                    var us2 = await _userManager.FindByNameAsync(User2);

                    ChatModel chat = new ChatModel();
                    chat.ChatCreater = us1;
                    chat.CreaterUserNAme = USer1;
                    chat.interlocutor = us2;
                    chat.interlocutorrUserNAme = User2;
                    chat.Title = $"correspondence {us1.UserName} width {us2.UserName}";

                    _context.Chats.Add(chat);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(GoToChat),"Chat",new { id=chat.Id});
                }
                return RedirectToAction(nameof(GoToChat), "Chat", new { id = CHAT.Id });
            }
            catch
            {
                //  return RedirectToAction("Index","Home");
                return NotFound();
            }
        }
        [HttpGet]
        public async Task<IActionResult> MyChats()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var chats =await _context.Chats.Where(o => o.ChatCreater == user|| o.interlocutor ==user).ToListAsync();
            return View(chats);  
        }

        [HttpGet]
        public async Task<IActionResult> GoToChat(int id)
        {
            //var chat = await _context.Chats.FirstOrDefaultAsync(o => o.ChatCreater.UserName == USer1 && o.interlocutor.UserName == User2);
            //try
            //{
                var chat =await _context.Chats.FirstOrDefaultAsync(o => o.Id == id);
                if (chat != null) {
                    var Model = new ChatVM();
                    var messages = await _context.Messages.Where(o => o.ChatId == id).ToListAsync();
                    Model.ChatId = id;
                    Model.Messages = messages;
                    //var id =chat.i
                    // var user = _userManager.FindByIdAsync();
                    if (User.Identity.Name != chat.CreaterUserNAme)
                        ViewBag.interlocutor = chat.CreaterUserNAme;
                    else
                        ViewBag.interlocutor = chat.interlocutorrUserNAme;

                    return View(Model);
                }
                return RedirectToAction("index","home");
             
            //}
            //catch
            //{
            //    return NotFound();
            //}

        }

        // GET: ChatController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChatController/Edit/5
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

        // GET: ChatController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChatController/Delete/5
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
