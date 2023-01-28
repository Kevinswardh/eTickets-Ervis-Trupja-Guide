using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        //Tabel Primary Key
        [Key]
        public int Id { get; set; }
        //Profilepicutre
        public string ProfilePictureURL { get; set; }

        //FullName
        public string FullName { get; set; }

        //Biography
        public string Bio { get; set; }

        //Relationships 
        public List<Movie> Movies { get; set; }
    }
}
