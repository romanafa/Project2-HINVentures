using System.Diagnostics;

namespace HIN_Ventures.Models.Entities
{
    public class Freelancer : ApplicationUser
    {
        public Freelancer()
        {
            this.Specialities = new HashSet<Speciality>();
        }

        public int TotalRating { get; set; }
        public int TimesRated { get; set; }

        public virtual ICollection<Speciality> Specialities { get; set; }
        public virtual ICollection<Score> Score { get; set; }
        public virtual List<Assignment> Assignments { get; set; }
        public virtual List<FreelancerRating> Ratings { get; set; }
    }
}
