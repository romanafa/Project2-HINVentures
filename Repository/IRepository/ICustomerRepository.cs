using HIN_Ventures.Models.Entities;

namespace HIN_Ventures.Repository.IRepository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        void Update(Customer customer);
    }
}
