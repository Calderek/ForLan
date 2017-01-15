using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.Entity
{
    public class PolishWord
    {
        [Key]
        public int WordID { get; set; }
        //public virtual List<DictionaryPlEng> DictionaryEng { get; set; }
        //public virtual List<DictionaryPlDe> DictionaryDe { get; set; }

        public string Word { get; set; }
    }
}
