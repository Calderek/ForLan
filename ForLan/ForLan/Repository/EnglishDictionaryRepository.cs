using ForLan.DbModel;
using ForLan.Entity;
using ForLan.Repository.Abstract;

namespace ForLan.Repository
{
    public class EnglishDictionaryRepository:IDictionaryRepository
    {
        public void Add(string polishWord, string englishWord)
        {
            using (var db= new ForlanDbContext())
            {
                //todo check whether this word is avaible in database
                EnglishWord wordEnglish = new EnglishWord() { Word = englishWord };
                db.EnglishWord.Add(wordEnglish);

                //todo check whether this word is avaible in database
                PolishWord wordPolish = new PolishWord() { Word = polishWord };
                db.PolishWord.Add(wordPolish);

                DictionaryPlEng dictionary = new DictionaryPlEng();
                dictionary.EnglishWord = wordEnglish;
                dictionary.PolishWord = wordPolish;
                db.DictionaryPolishEnglish.Add(dictionary);
                db.SaveChanges();

            }
        }


    }
}
