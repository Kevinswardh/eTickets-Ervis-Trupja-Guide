namespace eTickets.Models
{
    public class Actor_Movie
    {
        //Links Movies table and Actors Table Together
        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        public int ActorID { get; set; }
        public Actor Actor { get; set; }

    }
}
