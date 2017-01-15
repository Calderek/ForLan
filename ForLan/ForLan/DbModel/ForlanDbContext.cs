using ForLan.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.DbModel
{
    public class ForlanDbContext: DbContext
    {
        public ForlanDbContext()
        {

        }

        public DbSet<Log> Log{ get; set; }
        public DbSet<PolishWord> PolishWord { get; set; }
        public DbSet<EnglishWord> EnglishWord { get; set; }
        public DbSet<GermanWord> GermanWord { get; set; }
        public DbSet<DictionaryPlDe> DictionaryPolishGerman { get; set; }
        public DbSet<DictionaryPlEng> DictionaryPolishEnglish { get; set; }



    }
}
