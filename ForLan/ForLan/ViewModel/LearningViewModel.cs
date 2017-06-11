using ForLan.Model;
using ForLan.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using static ForLan.Helper.LanguageHelper;

namespace ForLan.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class LearningViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the LearningViewModel class.
        /// </summary>
        public LearningViewModel()
        {
            NextWordCommand = new RelayCommand(Generate);
            CheckWordCommand = new RelayCommand(Check);

        }

        public string DrewWord { get; set; }
        public string AnserwedWord { get; set; }
        public RelayCommand NextWordCommand { get; set; }
        public RelayCommand CheckWordCommand { get; set; }


        public void Generate()
        {
            LotteryWord generator = new LotteryWord();
            var generatedWord= generator.Random(LanguageEnum.Polish);
            DrewWord = generatedWord;
            RaisePropertyChanged(nameof(DrewWord));
        }

        public void Check()
        {
            EnglishDictionaryRepository repo = new EnglishDictionaryRepository();
            if (repo.Check(DrewWord,AnserwedWord))
            {
                DrewWord = "tak";
            }
            else
            {
                DrewWord = "nie";
            }
        }

    }
}