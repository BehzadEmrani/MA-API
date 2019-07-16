using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Message
    {
        public int ID { get; set; }

        public string MatnMessage { get; set; }

        public int UserSenderId { get; set; }

        public int UserReciverId { get; set; }

        public DateTime SendMasseg { get; set; }


        public Message()
        { 
            SendMasseg = DateTime.Now;
        }
    }
}
