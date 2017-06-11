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
    public class PolishWordRepository:IWordRepository
    {

        //todo unit test
        public bool Check(string word)
        { 
            using (var db = new ForlanDbContext())
            {
                return db.PolishWord.Any(w => w.Word == word);
            }
        }

        //todo unit test
        //todo change to property
        public int Count()
        {
            using (var db = new ForlanDbContext())
            {
                return db.PolishWord.Count();
            }
        }

        //todo unit test
        //
        public IEnumerable<PolishWord> All()
        {
            using (var db = new ForlanDbContext())
            {
                IQueryable<PolishWord> words = db.PolishWord;
                return words.ToList<PolishWord>();
            }
        }

        public PolishWord Get(string word)
        {
            using (var db = new ForlanDbContext())
            {
                IQueryable<PolishWord> words = db.PolishWord;
                return words.Where(w=> w.Word==word).ToList<PolishWord>().FirstOrDefault();
            }
        }
    }
}
