using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesDAT
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        [ForeignKey("GenreId")]
        public virtual ICollection<Genre> MovieGenres { get; set; }
        [ForeignKey("UserId")]
        public int MovieDirectorId { get; set; }
        public virtual ICollection<User> MovieAcceptedActors { get; set; }
        public virtual ICollection<User> MovieConsideredActors { get; set; }

        public Movie(int movieId, string movieName, string movieDescription, ICollection<Genre> movieGenres, int movieDirectorId, ICollection<User> movieAcceptedActors, ICollection<User> movieConsideredActors)
        {
            MovieId = movieId;
            MovieName = movieName;
            MovieDescription = movieDescription;
            MovieGenres = movieGenres;
            MovieDirectorId = movieDirectorId;
            MovieAcceptedActors = movieAcceptedActors;
            MovieConsideredActors = movieConsideredActors;
        }
    }
}
