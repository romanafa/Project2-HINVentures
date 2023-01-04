using HIN_Ventures.Models.Entities;

namespace HIN_Ventures.Repository.IRepository
{
    public interface IAssignmentRepository : IRepository<Assignment>
    {
        IEnumerable<Speciality> GetAllSpecialities(int assignmentId);
        void Update(Assignment assignment);
        void UpdateStatus(int assignmentId, int status);
    }
}
