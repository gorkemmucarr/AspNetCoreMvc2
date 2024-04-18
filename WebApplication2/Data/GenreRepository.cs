using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class GenreRepository
    {
        private static readonly List<Genre> _genres = null;
        static GenreRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre
                {
                    GenreId = 1,
                    Name = "Korku"
                },
                new Genre
                {
                    GenreId = 2,
                    Name = "Komedi"
                },
                new Genre
                {
                    GenreId = 3,
                    Name = "Aksiyon"
                },
                new Genre
                {
                    GenreId = 4,
                    Name = "Savaş"
                }
            };
        }

        public static List<Genre> Genres
        {
            get
            {
                return _genres;
            }
        }

        public static void Add(Genre genre)
        {
            _genres.Add(genre);
        }

        public static Genre GetById(int id)
        {
           return _genres.FirstOrDefault(p => p.GenreId == id);
        }
    }
}
