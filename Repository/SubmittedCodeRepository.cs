using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;

namespace HIN_Ventures.Repository
{
    public class SubmittedCodeRepository : Repository<SubmittedCode>, ISubmittedCodeRepository
    {
        private HIN_VenturesContext _db;
        public SubmittedCodeRepository(HIN_VenturesContext db) : base(db)
        {
            _db = db;
        }

        public void Update(SubmittedCode submittedCode)
        {
            _db.SubmittedCodes.Update(submittedCode);
            _db.SaveChangesAsync();
        }
    }
}
