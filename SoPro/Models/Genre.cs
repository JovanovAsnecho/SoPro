using System.ComponentModel.DataAnnotations;

namespace SoPro.Models
{
    public class Genre
    {
        public Genre()
        {
            Movies = new List<Movie>();
        }
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public virtual ICollection<Movie> Movies { get; set; }



    }
}
