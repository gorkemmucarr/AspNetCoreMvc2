using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required(ErrorMessage ="Başlık Kısmı Boş Olamaz!!!")]
        [StringLength(40,MinimumLength =1,ErrorMessage ="Başlık Kısmı 1-40 Karakter Arasında Olmalıdır!!!")]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Director { get; set; }
        public string[] Players { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        public int? GenreId { get; set; }
    }
}
