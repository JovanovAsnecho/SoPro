using System.ComponentModel.DataAnnotations;

namespace SoPro.Models
{
    public class Movie
    {

        public Movie()
        {
            People = new List<Person>();
            Genres = new List<Genre>();

        }
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public float Rating { get; set; }

        public string IMBDLink { get; set; }

        public string ImgUrl { get; set; }

        public string ReleaseDate { get; set; }

        public Person Person { get; set; }

        public Genre Genre { get; set; }

        public virtual ICollection<Person> People{ get; set; }

        public virtual ICollection<Genre> Genres { get; set; }

    }

}
