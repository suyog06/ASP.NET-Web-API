using ParkyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Repository.IRepository
{
    public interface ITrailsrepository
    {
        ICollection<Trails> GetTrails();
        ICollection<Trails> GetTrailsInNationalPark(int npId);
        Trails GetTrails(int trailsId);
        bool TrailsExists(string name);
        bool TrailsExists(int id);
        bool CreateTrails(Trails trails);
        bool UpdateTrails(Trails trails);
        bool DeleteTrails(Trails trails);
        bool Save();
    }
}
