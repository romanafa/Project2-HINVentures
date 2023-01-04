using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository;
using HIN_Ventures.Repository.IRepository;

namespace HIN_Ventures.Repository
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        private HIN_VenturesContext _db;

        public PaymentRepository(HIN_VenturesContext db) : base(db)
        {
            _db = db;
        }

    }
}