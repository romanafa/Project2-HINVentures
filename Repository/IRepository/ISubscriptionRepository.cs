using HIN_Ventures.Models.Entities;
using HIN_Ventures.Models.Viewmodels;
using Microsoft.Extensions.Hosting;

namespace HIN_Ventures.Repository.IRepository
{
    public interface ISubscriptionRepository : IRepository<Subscription>
    {
        SubscriptionVM GetSubscriptionViewModel(int? subscriptionId);
        IEnumerable<Customer> GetAllSubscribers(int? subscriptionId);
        Task Save(SubscriptionVM subscription);
        void Update(Subscription subscription);
    }
}
