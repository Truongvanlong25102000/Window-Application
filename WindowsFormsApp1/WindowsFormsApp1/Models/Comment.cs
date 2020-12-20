using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Comment
    {
        public string avatarCustomer { get; set; }
        public string content { get; set; }
        public string nameCustomer { get; set; }
        public string time { get; set; }

        public Comment()
        {

        }

        public string toString() => avatarCustomer+"\t"+content+"\t"+nameCustomer+"\t"+time;
    }
}
