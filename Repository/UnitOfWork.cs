using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;

namespace HIN_Ventures.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HIN_VenturesContext _db;

        public UnitOfWork(HIN_VenturesContext db)
        {
            _db = db;
            Assignment = new AssignmentRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            Customer = new CustomerRepository(_db);
            Freelancer = new FreelancerRepository(_db);
            Rating = new RatingRepository(_db);
            Speciality = new SpecialityRepository(_db);
            SubmittedCode = new SubmittedCodeRepository(_db);
            Message = new MessageRepository(_db);
            Subscription = new SubscriptionRepository(_db);
            Payment = new PaymentRepository(_db);
        }

        public IAssignmentRepository Assignment { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public ICustomerRepository Customer { get; private set; }
        public IFreelancerRepository Freelancer { get; private set; }
        public IRatingRepository Rating { get; private set; }
        public ISpecialityRepository Speciality { get; private set; }
        public ISubmittedCodeRepository SubmittedCode { get; private set; }
        public IMessageRepository Message { get; private set; }
        public ISubscriptionRepository Subscription { get; private set; }

        public IPaymentRepository Payment { get; private set; }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
