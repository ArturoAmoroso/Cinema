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
            var lastActor = actors.OrderByDescending(a => a.Id).FirstOrDefault();
            int nextId = lastActor == null ? 1 : lastActor.Id + 1;
            actor.Id = nextId;
            actors.Add(actor);
            return actor;
        }

        public bool DeleteActor(Actor actor)
        {
            return actors.Remove(actor);
        }

        public Actor GetActor(int id)
        {
            var actor = actors.SingleOrDefault(a => a.Id == id);
            return actor;
        }

        public IEnumerable<Actor> GetActors()
        {
            return actors;
        }

        public Actor UpdateActor(Actor actor)
        {
            var actorFound = actors.SingleOrDefault(a => a.Id == actor.Id);
            actorFound.Name = actor.Name;
            actorFound.Lastname = actor.Lastname;
            actorFound.Age= actor.Age;
            return actorFound;
        }
    }
}
