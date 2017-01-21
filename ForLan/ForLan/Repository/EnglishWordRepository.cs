using ForLan.DbModel;
using ForLan.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.Repository
{
    public class EnglishWordRepository : IWordRepository
    {


        //todo unit test
        public bool Check(string word)
        {
            using (var db= new ForlanDbContext())
            {
                return db.EnglishWord.Any(w => w.Word == word);
            }
        }


        //todo unit test
        public int Count()
        {
            using (var db = new ForlanDbContext())
            {
                return db.EnglishWord.Count();
            }
        }
    }
}
