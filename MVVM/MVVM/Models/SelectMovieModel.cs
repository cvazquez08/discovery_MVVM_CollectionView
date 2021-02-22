using System.Collections.Generic;

namespace MVVM.Models
{
    public class SelectMovieModel
    {
        public readonly List<MovieTileModel> Movies;

        public SelectMovieModel()
        {
            Movies = new List<MovieTileModel>
            {
                new MovieTileModel("Dumb and Dumber", "1994",
                    "Imbecillic best friends Lloyd Christmas and Harry Dune stumble across a suitcase full of money left behind."),
                new MovieTileModel("The Mask", "1994",
                    "When timid bank clerk Stanley Ipkiss discovers a magical mask containing the spirit of the Nose god Loki, his entire life changes."),
                new MovieTileModel("Liar Liar", "1997",
                    "Conniving attorney Fletcher Reede is an ace in the courtroom, but his dishonesty and devotion to work ruin his relationships."),
            };
        }
    }
}