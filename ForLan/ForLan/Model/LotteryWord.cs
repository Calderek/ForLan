using ForLan.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLan.Model
{
    public class LotteryWord
    {
        public string Random()
        {
            EnglishWordRepository repo = new EnglishWordRepository();
            var count=repo.Count();
            Random generator = new System.Random();
            var index = generator.Next(1, count);
            index--;
            return repo.All().ToList()[index].Word;
        }

    }
}
