using System.ComponentModel.DataAnnotations;

namespace SoPro.Models
{
    public class Person
    {
        public enum Role
        {
            Actor, Director, Producer, AdditionalCast
        };

        public Person()
        {
            Movies = new List<Movie>();
        }

        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        Role role { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
