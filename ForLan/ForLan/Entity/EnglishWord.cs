using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.Entity
{
    public class EnglishWord
    {
        [Key]
        public int WordID { get; set; }
        //public virtual List<DictionaryPlEng> Dictionary { get; set; }
        public string Word { get; set; }

    }
}
