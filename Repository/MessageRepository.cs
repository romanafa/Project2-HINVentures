using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;

namespace HIN_Ventures.Repository
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        private HIN_VenturesContext _db;

        public MessageRepository(HIN_VenturesContext db) : base(db)
        {
            _db = db;
        }
    }
}
