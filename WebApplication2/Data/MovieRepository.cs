using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie
                {
                    MovieId = 1,
                    Title ="Io",
                    Description ="Açıklama 1",
                    Director ="Yönetmen 1",
                    Players = new string[]{"Oyuncu 1","Oyuncu 2"},
                    ImgUrl = "jpg1.jpg",
                    GenreId = 1
                },
                new Movie
                {
                    MovieId = 2,
                    Title ="Annihilation",
                    Description ="Açıklama 2",
                    Director ="Yönetmen 2",
                    Players = new string[]{"Oyuncu 1","Oyuncu 2"},
                    ImgUrl = "jpg2.jpg",
                    GenreId = 2
                },
                new Movie
                {
                    MovieId = 3,
                    Title ="Outlander",
                    Description ="Açıklama 3",
                    Director ="Yönetmen 3",
                    Players = new string[]{"Oyuncu 1","Oyuncu 2"},
                    ImgUrl = "jpg3.jpg",
                    GenreId = 3
                },
                new Movie
                {
                    MovieId = 4,
                    Title ="Annihilation",
                    Description ="Açıklama 4",
                    Director ="Yönetmen 4",
                    Players = new string[]{"Oyuncu 1","Oyuncu 2"},
                    ImgUrl = "jpg2.jpg"
                }
            };
        }

        public static List<Movie> Movies
        {
            get{
                return _movies;
            }
        }

        public static void Add(Movie movie)
        {
            movie.MovieId = _movies.Count + 1;
            _movies.Add(movie);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(p => p.MovieId == id);
        }
        public static void Edit(Movie m)
        {
            foreach (var movie in _movies)
            {
                if (movie.MovieId == m.MovieId)
                {
                    movie.Title = m.Title;
                    movie.Description = m.Description;
                    movie.Director = m.Director;
                    movie.GenreId = m.GenreId;
                    break;
                }
            }
        }

        public static void Delete(int MovieId)
        {
            var deletedMovie = GetById(MovieId);
            if (deletedMovie!=null)
            {
                _movies.Remove(deletedMovie);
            }
        }
    }
}
