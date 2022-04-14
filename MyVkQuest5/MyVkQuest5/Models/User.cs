using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MyVkQuest5.Models
{
    public class User:IdentityUser
    {
        public virtual ICollection<MessageModel> messages { get; set; }
    }
}
