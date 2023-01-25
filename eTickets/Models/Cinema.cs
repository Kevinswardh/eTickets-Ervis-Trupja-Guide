using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        //Tabel Primary Key
        [Key]
        public int Id { get; set; }
        [Required]

        //Cinema Picture
        public string Logo { get; set; }

        //Cinema Name
        public string Name { get; set; }

        //Description of the Cinema
        public string Description { get; set; }

        //Relationsships
        public List<Movie> Movies { get; set; }
    }
}
