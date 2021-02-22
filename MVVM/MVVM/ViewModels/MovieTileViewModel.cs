using System.ComponentModel;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public class MovieTileViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public readonly MovieTileModel Model;
        
        public string Title => Model.Title;
        public string SubText => Model.SubText;
        public string Description => Model.Description;

        public bool IsSelected
        {
            get => Model.IsSelected;
            set => Model.IsSelected = value;
        }

        public bool IsNotSelected => Model.IsNotSelected;

        public MovieTileViewModel(MovieTileModel model)
        {
            this.Model = model;
        }
    }
}