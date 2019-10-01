using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Exceptions;
using Cinema.Models;

namespace Cinema.Services
{
    public class ActorsServices : IActorsServices
    {
        List<Actor> actors;
        private HashSet<string> allowebOrderBy;
        public ActorsServices()
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
            allowebOrderBy = new HashSet<string>() { "name", "lastname", "age", "id"};
        }

        public Actor CreateActor(Actor actor)
        {
            var lastActor = actors.OrderByDescending(a => a.Id).FirstOrDefault();
            int nextId = lastActor == null ? 1 : lastActor.Id + 1;
            /*if (lastActor == null)
                int nextId = 1;
            else
                int nextId = lastActor.Id +1;
            */
            actor.Id = nextId;
            actors.Add(actor);
            return actor;
        }

        public bool DeleteActor(int Id)
        {
            var actorFound = validateActor(Id);
            return actors.Remove(actorFound);
        }

        public Actor GetActor(int Id)
        {
            var actorFound = validateActor(Id);
            return actorFound;
        }

        public IEnumerable<Actor> GetActors(string orderBy)
        {
            if (orderBy == null)
                throw new BadRequestEx("OrderBy needs a value");

            var ordeByLower = orderBy.ToLower();
            if (!allowebOrderBy.Contains(ordeByLower))
            {
                throw new BadRequestEx($"Actors cannot orderBy:{orderBy} , only by: {string.Join(" , ", allowebOrderBy) }");
            }
            switch (ordeByLower)
            {
                case "name":
                    return actors.OrderBy(x => x.Name);
                case "lastname":
                    return actors.OrderBy(x => x.Lastname);
                case "age":
                    return actors.OrderBy(x => x.Age);
                default:
                    return actors;
            }
            //return actors;
        }
        public Actor UpdateActor(int Id, Actor actor)
        {
            var actorFound = validateActor(Id);
            if (actor.Id == 0)
            {
                actor.Id = Id;
            }
            if (Id != actor.Id)
            {
                throw new BadRequestEx("URL Id and Body Id must be equal");
            }
            actorFound.Name = actor.Name;
            actorFound.Lastname = actor.Lastname;
            actorFound.Age = actor.Age;
            return actorFound;
        }
        private Actor validateActor(int id)
        {
            var actorFound = actors.SingleOrDefault(a => a.Id == id);
            if (actorFound == null)
                throw new NotFoundEx($"There isn't an actor with Id: {id}");
            return actorFound;
        }
    }
}
