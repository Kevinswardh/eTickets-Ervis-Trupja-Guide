using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        //Tabel Primary Key
        [Key]
        public int Id { get; set; }
        [Required]
        //Profilepicutre
        public string ProfilePictureURL { get; set; }

        //FullName
        public string FullName { get; set; }

        //Biography
        public string Bio { get; set; }

        //RelationShips
        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
