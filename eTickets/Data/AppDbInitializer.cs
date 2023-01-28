using eTickets.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicescope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                        {
                        new Cinema()
                        {
                          
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the First Cinema",

                        },
                        new Cinema()
                        {

                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the Second Cinema",
                        }
                }); 
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                        { 
                        new Actor()
                        {
                            FullName = "Actor 1",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            Bio = "Bio on first Actor",

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            Bio = "Bio on second Actor",
                        }
                });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        { 
                          ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg",
                          FullName ="Producer 1",
                          Bio = "About the Producer",
                         
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
        
                    context.Movies.AddRange(new List<Movie>()
                        {
                        new Movie()
                        {
                          
                            Name = "Movie 1",
                            Description = "About movie 1",
                            Price = 10.99,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 5,
                            ProducerID = 1,
                            MovieCategory = Enums.MovieCategory.Action,

                        },
                        new Movie()
                        {
                           
                            Name = "Movie 2",
                            Description = "About movie 2",
                            Price = 12.99,
                            ImageURL = "http://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate = DateTime.Now.AddDays(+10),
                            EndDate = DateTime.Now.AddDays(+20),
                            CinemaID = 6,
                            ProducerID = 1,
                            MovieCategory = Enums.MovieCategory.Drama,
                        }
                }) ;
                    context.SaveChanges();
                }

                //Actor & Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorID= 1,
                            MovieID= 28,
                        },
                        new Actor_Movie()
                        {
                            ActorID= 2,
                            MovieID= 28,
                        },
                        new Actor_Movie()
                        {
                            ActorID= 1,
                            MovieID= 29,
                        }
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}
