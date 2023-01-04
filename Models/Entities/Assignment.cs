using System.ComponentModel.DataAnnotations;

namespace HIN_Ventures.Models.Entities
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPayed { get; set; }
        public bool IsPayedToFreelancer { get; set; }
        public int Progress { get; set; }

        public DateTime Created { get; set; }
        public DateTime Deadline { get; set; }

        public virtual SubmittedCode SubmittedCode { get; set; }

        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? FreelancerId { get; set; }
        public string? FreelancerName { get; set; }

        public virtual ICollection<Speciality>? Specialities { get; set; }

    }
}
