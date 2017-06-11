using ForLan.DbModel;
using ForLan.Entity;
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
        //todo change to property
        public int Count()
        {
            using (var db = new ForlanDbContext())
            {
                return db.EnglishWord.Count();
            }
        }

        //todo unit test
        //
        public IEnumerable<EnglishWord> All()
        {
            using (var db = new ForlanDbContext())
            {
                IQueryable<EnglishWord> words = db.EnglishWord;
                return words.ToList<EnglishWord>();
            }
        }


    }
}
