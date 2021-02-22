using System.Collections.ObjectModel;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public class SelectMovieViewModel
    {
        private readonly SelectMovieModel model;
        public ObservableCollection<MovieTileViewModel> Movies { get; set; } =
            new ObservableCollection<MovieTileViewModel>();

        public SelectMovieViewModel(SelectMovieModel model)
        {
            this.model = model;
           
            this.model.Movies.ForEach(movies => Movies.Add(new MovieTileViewModel(movies)));
        }
    }
}