using ForLan.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ForLan.Helper.LanguageHelper;

namespace ForLan.Model
{
    public class LotteryWord
    {
        public string Random()
        {
            EnglishWordRepository repo = new EnglishWordRepository();
            var count=repo.Count();
            Random generator = new System.Random();
            var index = generator.Next(0, count-1);
            return repo.All().ToList()[index].Word;
        }

        public string Random(LanguageEnum language)
        {

            int index;
            int count;
            Random generator = new System.Random();

            switch (language)
            {
                case LanguageEnum.Polish:
                    PolishWordRepository repo2 = new PolishWordRepository();
                    count = repo2.Count();
                    index = generator.Next(0, count - 1);
                    return repo2.All().ToList()[index].Word;
                    break;
                case LanguageEnum.English:
                    EnglishWordRepository repo = new EnglishWordRepository();
                    count = repo.Count();
                    index = generator.Next(0, count - 1);
                    return repo.All().ToList()[index].Word;
                    break;
                default:
                    return null;
                    break;
            }
            
        }

    }
}
