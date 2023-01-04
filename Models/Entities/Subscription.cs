using System.ComponentModel.DataAnnotations;

namespace HIN_Ventures.Models.Entities
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public int NumberOfLines { get; set; }
        public double Price { get; set; }
        public string? SubscriptionDescription { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
