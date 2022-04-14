using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using MyVkQuest5.Models;

namespace MyVkQuest5.hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        public async Task Send(string message, string to)
        {
            var userName = Context.User.Identity.Name;

            if (Context.UserIdentifier != to) // если получатель и текущий пользователь не совпадают
                await Clients.User(Context.UserIdentifier).SendAsync("Notify", message, userName);
            await Clients.User(to).SendAsync("Notify", message, userName);
        }

        public override async Task OnConnectedAsync()
        {
            //await Clients.All.SendAsync("Notify", $"Приветствуем {Context.UserIdentifier}");
            await base.OnConnectedAsync();
        }



        //public async Task SendMessage(MessageModel message)
        //{
        //    await Clients.Caller.SendAsync("Receive", message);
        //}

        //public async Task Send(MessageModel user)
        //{
        //    user.WhenWrite = DateTime.Now;
        //    await Clients.Caller.SendAsync("Receive", user);
        //}

        //public class User
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //}
    }
}
