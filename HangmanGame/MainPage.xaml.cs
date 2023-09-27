using System.ComponentModel;

namespace HangmanGame
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        #region Fields
        List<string> words = new List<string>()
        {
            "python",
            "javascript",
            "maui",
            "csharp",
            "mongodb"
        };
        string answer = string.Empty;
        #endregion
        public MainPage()
        {
            InitializeComponent();
            PickWord();
        }

        #region Game Engine
        private void PickWord()
        {
            answer = words[new Random().Next(0, words.Count)];
        }
        #endregion
    }
}