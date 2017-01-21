using GalaSoft.MvvmLight;

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
            

        }

        public string DrewWord { get; set; }
        public string AnserwedWord { get; set; }

    }
}