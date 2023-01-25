using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTickets.Data.Enums;

namespace eTickets.Models
{
    public class Movie
    {
        //Tabel Primary Key
        [Key]
        public int Id { get; set; }
        [Required]

        //Movie Name
        public string Name { get; set; }

        //Description of the Moviue
        public string Description { get; set; }

        //Movie Price
        public double Price { get; set; }

        //Picture Of Movie
        public string ImageURL { get; set; }

        //The Movie Start Date
        public DateTime StartDate { get; set; }

        //The Movie End Date
        public DateTime EndDate { get; set; }

        //Movie Category
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }

        //Cinema
        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }

        //Producer  
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }



    }
}
