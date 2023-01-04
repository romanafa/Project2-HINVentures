using HIN_Ventures.Data;
using HIN_Ventures.Models.Entities;
using HIN_Ventures.Repository.IRepository;
using Microsoft.Extensions.Hosting;

namespace HIN_Ventures.Repository
{
    public class RatingRepository : Repository<FreelancerRating>, IRatingRepository
    {
        private HIN_VenturesContext _db;
        public RatingRepository(HIN_VenturesContext db) : base(db)
        {
            _db = db;
        }

        public void Update(FreelancerRating rating)
        {
            //_db.Ratings.Update(rating);
            //_db.saveChanges.....
            throw new NotImplementedException();
        }
    }
}
