using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyVkQuest5.Models
{
    public class MessageModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Message { get; set; }
        public ChatModel Chat { get; set; }
        public int ChatId { get; set; }
        public DateTime SentDate { get; set; }
        //[Required]
        public string FromUser { get; set; }
        //[Required]
        //public DateTime WhenWrite { get; set; }
        //[Required]
        //public string UserId { get; set; }
        //[Required]
        //public User User { get; set; }

        //public User ToUser { get; set; }
        //public string ToUserId { get; set; }
    }
}
