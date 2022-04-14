using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVkQuest5.Models
{
    public class ChatModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<MessageModel> messages { get; set; }

        public User ChatCreater { get; set; }
        public string ChatCreaterId { get; set; }
        public string CreaterUserNAme { get; set; }


        public User interlocutor { get; set; }
        public string interlocutorId { get; set; }
        public string interlocutorrUserNAme { get; set; }

    }
}
