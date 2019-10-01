using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public interface IActorsServices
    {
        IEnumerable<Actor> GetActors(string orderBy);
        Actor GetActor(int Id);
        Actor CreateActor(Actor actor);
        bool DeleteActor(int Id);
        Actor UpdateActor(int Id, Actor actor);
    }
}
