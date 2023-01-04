using System.ComponentModel.DataAnnotations;
using HIN_Ventures.Models.Entities;

namespace HIN_Ventures.Models.Viewmodels
{
    public class SubscriptionVM
    {
        
        public int SubscriptionId { get; set; }
        [Required(ErrorMessage = "Tittel mangler")]
        public string SubscriptionName { get; set; }
        [Required(ErrorMessage = "Pris mangler")]
        [Range(1, double.MaxValue)]
        public double Price { get; set; }
        [Required(ErrorMessage = "Beskrivelse mangler")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Antall linjer mangler")]
        [Range(1, int.MaxValue)]
        public int NumberOfLines { get; set; }

        public IEnumerable<Customer> Subscribers { get; set; }
        public string CustomerId { get; set; }
    }
}
