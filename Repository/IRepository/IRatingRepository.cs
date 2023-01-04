using HIN_Ventures.Models.Entities;

namespace HIN_Ventures.Repository.IRepository
{
    public interface IRatingRepository : IRepository<FreelancerRating>
    {
        void Update(FreelancerRating rating);
    }
}
