using HIN_Ventures.Models.Entities;

namespace HIN_Ventures.Repository.IRepository
{
    public interface ISubmittedCodeRepository : IRepository<SubmittedCode>
    {
        void Update(SubmittedCode submittedCode);
    }
}
