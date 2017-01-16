using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.Entity
{
    public class DictionaryPlEng
    {
        [Key]
        public int DictionaryID { get; set; }
        public int PolishWordId { get; set; }
        [ForeignKey("PolishWordId")]
        public PolishWord PolishWord { get; set; }
        public int EnglishWordId { get; set; }
        [ForeignKey("EnglishWordId")]
        public virtual EnglishWord EnglishWord { get; set; }

    }
}
