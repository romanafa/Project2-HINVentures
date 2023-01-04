using System.ComponentModel.DataAnnotations;

namespace HIN_Ventures.Models.Entities
{
    public class FreelancerRating
    {
        [Key]
        public int RatingId { get; set; }
        public int RatingValue { get; set; }
        public string? Comment { get; set; }

        public string? FreelancerId { get; set; }
    }
}
