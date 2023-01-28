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
        [Display (Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        //FullName
        [Display (Name = "Name")]
        public string FullName { get; set; }

        //Biography
        [Display (Name ="Biography")]
        public string Bio { get; set; }

        //RelationShips
        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
