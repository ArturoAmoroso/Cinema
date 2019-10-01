using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;

namespace Cinema.Data
{
    public class CineRepository : ICineRepository
    {
        List<Actor> actors;
        public CineRepository()
        {
            actors = new List<Actor>() {
                new Actor() {
                    Id = 111,
                    Name = "Leonardo",
                    Lastname = "DiCaprio",
                    Age = 56
                },
                new Actor(){
                    Id = 222,
                    Name = "Robert",
                    Lastname = "DeNiro",
                    Age = 75
                }
            };
        }
        public Actor CreateActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public bool DeleteActor(int id)
        {
            throw new NotImplementedException();
        }

        public Actor GetActor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetActors()
        {
            return actors;
        }

        public Actor UpdateActor(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
