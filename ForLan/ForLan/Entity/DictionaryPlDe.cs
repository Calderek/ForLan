using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.Entity
{
    public class DictionaryPlDe
    {
        [Key]
        public int DictionaryId { get; set; }
        public int PolishWordID { get; set; }
        public PolishWord PolishWord { get; set; }
        public int GermanWordID { get; set; }
        public GermanWord GermanWord { get; set; }

    }
}
