using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HIN_Ventures.Repository
{
    public class FreelancerRepository : Repository<Freelancer>, IFreelancerRepository
    {
        private HIN_VenturesContext _db;
        public FreelancerRepository(HIN_VenturesContext db) : base(db)
        {
            _db = db;
        }

         public IEnumerable<Freelancer> GetAllFreelancers()
        {
            var freelancers = _db.Freelancers
                .Include(freelancer => freelancer.Score)
                .ToList();
            return freelancers;
        }

        public Freelancer GetFreelancerById(string freelancerId)
        {
            Freelancer freelancer = _db.Freelancers.Find(freelancerId);

            return freelancer;
        }

        public void UpdateRating(Freelancer freelancer, int rating) 
        {
            int totalrating = freelancer.TotalRating;
            totalrating += rating;
            freelancer.TotalRating = totalrating;
            freelancer.TimesRated++;
            _db.SaveChanges();
        }

        public int GetAverageRating(Freelancer freelancer)
        {
            int totalRating = 0;
            foreach (Score score in freelancer.Score)
            {
                totalRating += score.ScoreValue;
            }
            return totalRating / freelancer.Score.Count;
        }

        public IEnumerable<Speciality> GetAllSpecialities(string? freelancerId)
        {
            IEnumerable<Speciality> specialities;
            specialities = _db.Freelancers.Where(f => f.Id == freelancerId).SelectMany(s => s.Specialities).ToList();
            return specialities;
        }

        public async Task Update(Freelancer freelancer)
        {
            _db.Freelancers.Update(freelancer);
            await _db.SaveChangesAsync();

        }
    }
}
