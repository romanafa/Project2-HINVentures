using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Models.Viewmodels;
using HIN_Ventures.Repository.IRepository;
using Microsoft.Extensions.Hosting;

namespace HIN_Ventures.Repository
{
    public class SubscriptionRepository : Repository<Subscription>, ISubscriptionRepository
    {
        private HIN_VenturesContext _db;

        public SubscriptionRepository(HIN_VenturesContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Customer> GetAllSubscribers(int? subscriptionId)
        {
            throw new NotImplementedException();
        }

        public SubscriptionVM GetSubscriptionViewModel(int? subscriptionId)
        {
            SubscriptionVM subscriptionVM;

            subscriptionVM = (from s in _db.Subscriptions
                where s.SubscriptionId == subscriptionId
                select new SubscriptionVM()
                {
                    SubscriptionId = s.SubscriptionId,
                    SubscriptionName = s.SubscriptionName,
                    Description = s.SubscriptionDescription,
                    Price = s.Price,
                    NumberOfLines = s.NumberOfLines
                    
                }).First();

            return subscriptionVM;
        }

        public async Task Save(SubscriptionVM subscription)
        {
            var s = new Subscription
            {
                SubscriptionName = subscription.SubscriptionName,
                SubscriptionDescription = subscription.Description,
                Price = subscription.Price,
                NumberOfLines = subscription.NumberOfLines
            };

            await _db.Subscriptions.AddAsync(s);
            await _db.SaveChangesAsync();
        }

        public void Update(Subscription subscription)
        {
            _db.Subscriptions.Update(subscription);
        }
    }
}
