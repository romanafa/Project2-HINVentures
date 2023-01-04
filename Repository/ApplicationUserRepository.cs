using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;

namespace HIN_Ventures.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private HIN_VenturesContext _db;

        public ApplicationUserRepository(HIN_VenturesContext db) : base(db)
        {
            _db = db;
        }
    }
}
