using System.ComponentModel.DataAnnotations;

namespace PageFilms.Models
{
    public class Film
    {
        public int ID { get; set; }
        public string Titre { get; set; } = null!;
        [DataType(DataType.Date)]
        public DateTime DateSortie { get; set; }
        public string Genre { get; set; } = null!;
        public decimal Prix { get; set; }
    }
}
