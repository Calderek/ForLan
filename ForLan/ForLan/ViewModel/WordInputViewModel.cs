﻿using ForLan.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ForLan.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class WordInputViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the WordInputViewModel class.
        /// </summary>
        public WordInputViewModel()
        {
            SaveWordCommand = new RelayCommand(SaveWord);

        }

        public string PolishWord { get; set; }
        public string ForeignhWord { get; set; }
        public RelayCommand SaveWordCommand{ get; set; }

        private void SaveWord()
        {
            EnglishDictionaryRepository repo = new EnglishDictionaryRepository();
            repo.Add(PolishWord, ForeignhWord);
        }
    }
}