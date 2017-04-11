using ForLan.DbModel;
using ForLan.Entity;
using ForLan.Helper;
using ForLan.Repository.Abstract;

namespace ForLan.Repository
{
    public class EnglishDictionaryRepository:IDictionaryRepository
    {

        //todo unit test
        public void Add(string polishWord, string englishWord)
        {
            using (var db= new ForlanDbContext())
            {

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



        public void Add(string word, string wordSaved, DictionaryHelper.DictionaryEnum dictionaryType)
        {
            using (var db = new ForlanDbContext())
            {

                switch (dictionaryType)
                {
                    case DictionaryHelper.DictionaryEnum.PolishToEnglish:
                        {

                            //todo check whether this word is avaible in database
                            EnglishWord wordEnglish = new EnglishWord() { Word = word };
                            db.EnglishWord.Add(wordEnglish);

                            //todo check whether this word is avaible in database
                            PolishWord wordPolish = new PolishWord() { Word = wordSaved };
                            db.PolishWord.Add(wordPolish);

                            DictionaryPlEng dictionary = new DictionaryPlEng();
                            dictionary.EnglishWord = wordEnglish;
                            dictionary.PolishWord = wordPolish;
                            db.DictionaryPolishEnglish.Add(dictionary);
                            break;
                        }
                    case DictionaryHelper.DictionaryEnum.EnglishToPolish:
                        {
                            //todo check whether this word is avaible in database
                            EnglishWord wordEnglish = new EnglishWord() { Word = wordSaved };
                            db.EnglishWord.Add(wordEnglish);

                            //todo check whether this word is avaible in database
                            PolishWord wordPolish = new PolishWord() { Word = word };
                            db.PolishWord.Add(wordPolish);

                            DictionaryPlEng dictionary = new DictionaryPlEng();
                            dictionary.EnglishWord = wordEnglish;
                            dictionary.PolishWord = wordPolish;
                            db.DictionaryPolishEnglish.Add(dictionary);
                        }
                        break;
                    default:
                        {

                        }
                        break;
                }


                db.SaveChanges();

                

            }
        }



    }
}
