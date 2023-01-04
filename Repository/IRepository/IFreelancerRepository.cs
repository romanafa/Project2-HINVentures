using HIN_Ventures.Models.Entities;

namespace HIN_Ventures.Repository.IRepository
{
    public interface IFreelancerRepository : IRepository<Freelancer>
    {
        public IEnumerable<Freelancer> GetAllFreelancers();
        public void UpdateRating(Freelancer freelancer, int rating);
        public int GetAverageRating(Freelancer freelancer);
        IEnumerable<Speciality> GetAllSpecialities(string? freelancerId);
        public Freelancer GetFreelancerById(string freelancerId);

        Task Update(Freelancer freelancer);
    }
}
