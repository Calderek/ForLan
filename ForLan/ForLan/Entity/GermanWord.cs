using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.Entity
{
    public class GermanWord
    {
        [Key]
        public int WordID { get; set; }
        //public virtual List<DictionaryPlDe> Dictionary { get; set; }
        public string Word { get; set; }
    }
}
