using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        //Tabel Primary Key
        [Key]
        public int Id { get; set; }
        //Profilepicutre
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        //FullName
        [Display(Name = "Name")]
        public string FullName { get; set; }

        //Biography
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships 
        public List<Movie> Movies { get; set; }
    }
}
