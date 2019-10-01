using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;

namespace Cinema.Services
{
    public class MoviesServices : IMoviesServices
    {
        private readonly IActorsServices actorsServices;
        List<Movie> movies;   
        public MoviesServices(IActorsServices actorsServices)
        {
            movies = new List<Movie>() {
                new Movie(){
                    Id = 1,
                    Name = "Titanic",
                    Duration = 3,
                    Genre = "Romatic",
                    ActorId = 1
                },
                new Movie(){
                    Id = 2,
                    Name = "Taxi Driver",
                    Duration = 2,
                    Genre = "Drama",
                    ActorId = 2
                }
            };
            this.actorsServices = actorsServices;
        }
        public Movie CreateMovie(int idActor, Movie movie)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMovie(int idActor, int idMovie)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovie(int idActor, int idMovie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMovies(int idActor)
        {
            throw new NotImplementedException();
        }

        public Movie UpdateMovie(int idActor, int idMovie, Movie movie)
        {
            throw new NotImplementedException();
        }
        private Actor validateActor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
