namespace HIN_Ventures.Models.Entities
{
    public class Speciality
    {
        public Speciality()
        {
            this.Freelancers = new HashSet<Freelancer>();
        }

        public int SpecialityId { get; set; }
        public string SpecialityName { get; set; }

        public virtual ICollection<Freelancer> Freelancers { get; set; }

        public virtual ICollection<Assignment>? Assignments { get; set; }
    }
}
