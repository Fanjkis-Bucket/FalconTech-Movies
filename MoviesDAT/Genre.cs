using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesDAT
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }
        public string GenreDescription { get; set; }
        public virtual  ICollection<Movie> Movies { get; set; }


        public Genre(int genreId, string genreName, string genreDescription, ICollection<Movie> movies)
        {
            GenreId = genreId;
            GenreName = genreName;
            GenreDescription = genreDescription;
            Movies = movies;
        }
    }
}
