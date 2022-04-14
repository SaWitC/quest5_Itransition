using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyVkQuest5.Data;
using MyVkQuest5.Models;

namespace MyVkQuest5.ViewModel
{
    public class WriteMessageVM
    {
        public MessageModel message { get; set; }
        public int ChatId { get; set; }
    }
}
