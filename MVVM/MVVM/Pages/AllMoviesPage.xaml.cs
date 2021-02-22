using System.Collections.Generic;
using MVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllMoviesPage : ContentPage
    {
        private readonly SelectMovieViewModel selectMovieViewModel;
        public AllMoviesPage(SelectMovieViewModel selectMovieViewModel)
        {
            this.selectMovieViewModel = selectMovieViewModel;
            InitializeComponent();
            BindingContext = selectMovieViewModel;
        }
    }
}