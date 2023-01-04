using System.ComponentModel.DataAnnotations;

namespace HIN_Ventures.Models.Entities
{
    public class Payment
    {

        [Key]
        public int PaymentId { get; set; }

        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }

        public string? FreelancerId { get; set;}
        public string? FreelancerName { get; set; }

        public double Amount { get; set; }

        public Assignment? Assignment { get; set; }

    }
}
