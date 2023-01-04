using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;

namespace HIN_Ventures.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private HIN_VenturesContext _db;

        public CustomerRepository(HIN_VenturesContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Customer customer)
        {
            _db.Customers.Update(customer);
            _db.SaveChangesAsync();

        }
    }
}
