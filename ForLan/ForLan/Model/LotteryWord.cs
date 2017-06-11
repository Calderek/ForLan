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
            switch (language)
            {
                case LanguageEnum.Polish:
                    PolishWordRepository repo2 = new PolishWordRepository();
                    var count2 = repo2.Count();
                    Random generator2 = new System.Random();
                    var index2 = generator2.Next(0, count2 - 1);
                    return repo2.All().ToList()[index2].Word;
                    break;
                case LanguageEnum.English:
                    EnglishWordRepository repo = new EnglishWordRepository();
                    var count = repo.Count();
                    Random generator = new System.Random();
                    var index = generator.Next(0, count - 1);
                    return repo.All().ToList()[index].Word;
                    break;
                default:
                    return null;
                    break;
            }
            
        }

    }
}
