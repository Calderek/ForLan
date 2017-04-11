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
    public class LearningViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the LearningViewModel class.
        /// </summary>
        public LearningViewModel()
        {
            DrewWord = GenereteWord();
            CheckCommand = new RelayCommand(NextWord);
        }

        public RelayCommand CheckCommand { get; set; }

        public string DrewWord { get; set; }
        public string AnserwedWord { get; set; }


        public string GenereteWord()
        {




            return "notImplemented";

        }

        void NextWord()
        {
            DrewWord = GenereteWord() + "aaaaa";
            RaisePropertyChanged(nameof(DrewWord))
        }


    }
}