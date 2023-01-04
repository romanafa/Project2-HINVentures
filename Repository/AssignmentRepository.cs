using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;
using Microsoft.Extensions.Hosting;

namespace HIN_Ventures.Repository
{
    public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
    {
        private HIN_VenturesContext _db;

        public AssignmentRepository(HIN_VenturesContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Assignment assignment)
        {
            _db.Assignments.Update(assignment);
            _db.SaveChangesAsync();
        }

        public IEnumerable<Speciality> GetAllSpecialities(int assignmentId)
        {
            IEnumerable<Speciality> specialities;
            specialities = _db.Assignments.Where(x => x.AssignmentId == assignmentId).SelectMany(s => s.Specialities).ToList();
            return specialities;
        }

        public void UpdateStatus(int assignmentId, int status)
        {
            throw new NotImplementedException();
        }
    }
}
