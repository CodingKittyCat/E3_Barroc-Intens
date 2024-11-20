using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Classes
{
    internal class UserNote
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime CreationDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public UserNote()
        {
            CreationDate = DateTime.Now;
        }
    }
}
