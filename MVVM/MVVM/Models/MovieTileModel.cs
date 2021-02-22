using System.ComponentModel;

namespace MVVM.Models
{
    public class MovieTileModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public readonly string Title;
        public readonly string SubText;
        public readonly string Description;
        public bool IsSelected { get; set; }
        public bool IsNotSelected => !IsSelected;

        public MovieTileModel(string title, string subText, string description)
        {
            Title = title;
            SubText = subText;
            Description = description;
        }
    }
}