using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        //Tabel Primary Key
        [Key]
        public int Id { get; set; }

        //Cinema Picture
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        //Cinema Name
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        //Description of the Cinema
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationsships
        public List<Movie> Movies { get; set; }
    }
}
