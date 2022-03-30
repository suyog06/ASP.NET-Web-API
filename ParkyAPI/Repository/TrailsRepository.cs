using Microsoft.EntityFrameworkCore;
using ParkyAPI.Data;
using ParkyAPI.Models;
using ParkyAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Repository
{
    public class TrailsRepository : ITrailsrepository
    {
        private ApplicationDbContext _db;
        public TrailsRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateTrails(Trails trails)
        {
            _db.Trails.Add(trails);
            return Save();
        }

        public bool DeleteTrails(Trails trails)
        {
            _db.Trails.Remove(trails);
            return Save();
        }

        public Trails GetTrails(int trailsId)
        {
            return _db.Trails.Include(c => c.NationalPark).FirstOrDefault(a => a.Id == trailsId);
        }

        public ICollection<Trails> GetTrails()
        {
            return _db.Trails.Include(c => c.NationalPark).OrderBy(a => a.Name).ToList();
        }
        public bool TrailsExists(string name)
        {
            bool value = _db.Trails.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }
        public bool TrailsExists(int id)
        {
            bool value = _db.Trails.Any(a => a.Id == id);
            return value;
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateTrails(Trails trails)
        {
            _db.Trails.Update(trails);
            return Save();
        }

        public ICollection<Trails> GetTrailsInNationalPark(int npId)
        {
            return _db.Trails.Include(c => c.NationalPark).Where(c => c.NationalParkId == npId).ToList();
        }
    }
}
