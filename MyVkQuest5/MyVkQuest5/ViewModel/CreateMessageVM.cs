using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVkQuest5.ViewModel
{
    public class CreateMessageVM
    {
        [Required]
        public string Message { get; set; }
    }
}
