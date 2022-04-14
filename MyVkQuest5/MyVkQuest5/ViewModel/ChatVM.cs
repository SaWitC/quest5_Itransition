using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyVkQuest5.Models;


namespace MyVkQuest5.ViewModel
{
    public class ChatVM
    {
        public IEnumerable<MessageModel> Messages { get; set; }
        public int ChatId { get; set; }

        public string recipientName { get; set; }
    }
}
