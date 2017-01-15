using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.Entity
{
    public class DictionaryPlEng
    {
        [Key]
        public int DictionaryID { get; set; }
        public int PolishWordID { get; set; }
        public PolishWord PolishWord { get; set; }
        public int EnglishWordID { get; set; }
        public EnglishWord EnglishWord { get; set; }

    }
}
