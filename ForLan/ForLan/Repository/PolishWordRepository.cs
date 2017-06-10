using ForLan.DbModel;
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

        public int Count()
        {
            throw new NotImplementedException();
        }
    }
}
