using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.Entity
{
    public class Log
    {
        public int LogID { get; set; }
        public string Message { get; set; }
        public DateTime onCreated { get; set; }
    }
}
