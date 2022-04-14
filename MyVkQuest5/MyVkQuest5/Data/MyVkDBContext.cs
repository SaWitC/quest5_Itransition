using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyVkQuest5.Models;

namespace MyVkQuest5.Data
{
    public class MyVkDBContext:IdentityDbContext<User>
    {
        public MyVkDBContext(DbContextOptions<MyVkDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<MessageModel> Messages { get; set; }
        public DbSet<ChatModel> Chats { get; set; }
    }
}
