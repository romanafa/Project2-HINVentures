namespace HIN_Ventures.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IAssignmentRepository Assignment { get; }
        IApplicationUserRepository ApplicationUser { get; }
        ICustomerRepository Customer { get; }
        IFreelancerRepository Freelancer { get; }
        IRatingRepository Rating { get; }
        ISpecialityRepository Speciality{ get; }
        ISubmittedCodeRepository SubmittedCode { get; }
        IMessageRepository Message { get; }
        ISubscriptionRepository Subscription { get; }
        IPaymentRepository Payment { get; }
        void Save();
    }
}
