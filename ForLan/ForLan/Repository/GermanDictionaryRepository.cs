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
    class GermanDictionaryRepository : IDictionaryRepository
    {
        public void Add(string polishWord, string germanWord)
        {
            using (var db = new ForlanDbContext())
            {
                //todo check whether this word is avaible in database
                GermanWord wordGerman = new GermanWord() { Word = germanWord };
                db.GermanWord.Add(wordGerman);

                //todo check whether this word is avaible in database
                PolishWord wordPolish = new PolishWord() { Word = polishWord };
                db.PolishWord.Add(wordPolish);

                DictionaryPlDe dictionary = new DictionaryPlDe();
                dictionary.GermanWord = wordGerman;
                dictionary.PolishWord = wordPolish;
                db.DictionaryPolishGerman.Add(dictionary);
                db.SaveChanges();

            }
        }
    }
}
