﻿using ForLan.DbModel;
using ForLan.Entity;
using ForLan.Helper;
using ForLan.Repository.Abstract;
using System.Linq;

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

        public bool Check(string polishWord, string englishWord)
        {
            PolishWordRepository polishRepo = new PolishWordRepository();
            EnglishWordRepository englishRepo = new EnglishWordRepository();
            PolishWord plWord = polishRepo.Get(polishWord);
            EnglishWord engWord = englishRepo.Get(englishWord);

            if (plWord == null)
                return false;
            if (engWord == null)
                return false;

            using (var db = new ForlanDbContext())
            {


                var x = db.DictionaryPolishEnglish.Where(d=>d.PolishWordId==plWord.WordID).Where(d=> d.EnglishWordId==engWord.WordID);
                //var xx = x.ToList();
                if (x.Count() > 0)
                    return true;
                else
                    return false;

                

            }



        }



    }
}
