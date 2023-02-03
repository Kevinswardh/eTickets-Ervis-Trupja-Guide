using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        //Tabel Primary Key
        [Key]
        public int Id { get; set; }
        
        //Profilepicutre
        [Display (Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        //FullName
        [Display (Name = "Name")]
        [Required(ErrorMessage = "A name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be in between 3 and 50 chars")]
        public string FullName { get; set; }

        //Biography
        [Display (Name ="Biography")]
        [Required(ErrorMessage = "A biography is required")]
        public string Bio { get; set; }

        //RelationShips
        public List<Actor_Movie>? Actor_Movies { get; set; }

    }
}
